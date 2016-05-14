////////////////////////////////////////////////////////////////////////////////
// StickyWindows
// 
// Copyright (c) 2004 Corneliu I. Tusnea
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the author be held liable for any damages arising from 
// the use of this software.
// Permission to use, copy, modify, distribute and sell this software for any 
// purpose is hereby granted without fee, provided that the above copyright 
// notice appear in all copies and that both that copyright notice and this 
// permission notice appear in supporting documentation.
//
// Notice: Check CodeProject for details about using this class
//
//////////////////////////////////////////////////////////////////////////////////
using System;

#region Blue.Win32Imports
namespace Blue.Private.Win32Imports
{
    using System.Runtime.InteropServices;

    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDesktopWindow();

        public class VK
        {
            public const int VK_SHIFT = 0x10;
            public const int VK_CONTROL = 0x11;
            public const int VK_MENU = 0x12;
            public const int VK_ESCAPE = 0x1B;

            public static bool IsKeyPressed(int KeyCode)
            {
                return (GetAsyncKeyState(KeyCode) & 0x0800) == 0;
            }
        }

        public class WM
        {
            public const int WM_MOUSEMOVE = 0x0200;
            public const int WM_NCMOUSEMOVE = 0x00A0;
            public const int WM_NCLBUTTONDOWN = 0x00A1;
            public const int WM_NCLBUTTONUP = 0x00A2;
            public const int WM_NCLBUTTONDBLCLK = 0x00A3;
            public const int WM_LBUTTONDOWN = 0x0201;
            public const int WM_LBUTTONUP = 0x0202;
            public const int WM_KEYDOWN = 0x0100;
        }

        public class HT
        {
            public const int HTERROR = (-2);
            public const int HTTRANSPARENT = (-1);
            public const int HTNOWHERE = 0;
            public const int HTCLIENT = 1;
            public const int HTCAPTION = 2;
            public const int HTSYSMENU = 3;
            public const int HTGROWBOX = 4;
            public const int HTSIZE = HTGROWBOX;
            public const int HTMENU = 5;
            public const int HTHSCROLL = 6;
            public const int HTVSCROLL = 7;
            public const int HTMINBUTTON = 8;
            public const int HTMAXBUTTON = 9;
            public const int HTLEFT = 10;
            public const int HTRIGHT = 11;
            public const int HTTOP = 12;
            public const int HTTOPLEFT = 13;
            public const int HTTOPRIGHT = 14;
            public const int HTBOTTOM = 15;
            public const int HTBOTTOMLEFT = 16;
            public const int HTBOTTOMRIGHT = 17;
            public const int HTBORDER = 18;
            public const int HTREDUCE = HTMINBUTTON;
            public const int HTZOOM = HTMAXBUTTON;
            public const int HTSIZEFIRST = HTLEFT;
            public const int HTSIZELAST = HTBOTTOMRIGHT;
            public const int HTOBJECT = 19;
            public const int HTCLOSE = 20;
            public const int HTHELP = 21;
        }

        public class Bit
        {
            public static int HiWord(int iValue)
            {
                return ((iValue >> 16) & 0xFFFF);
            }
            public static int LoWord(int iValue)
            {
                return (iValue & 0xFFFF);
            }
        }
    }
}
#endregion

namespace Blue.Windows
{
    using System.Windows.Forms;
    using System.Drawing;
    using System.Collections;

    using Blue.Private.Win32Imports;

    public class StickyWindow : System.Windows.Forms.NativeWindow
    {
        private static ArrayList GlobalStickyWindows = new ArrayList();

        #region ResizeDir
        private enum ResizeDir
        {
            Top = 2,
            Bottom = 4,
            Left = 8,
            Right = 16
        };
        #endregion

        #region Message Processor
        private delegate bool ProcessMessage(ref Message m);
        private ProcessMessage MessageProcessor;

        private ProcessMessage DefaultMessageProcessor;
        private ProcessMessage MoveMessageProcessor;
        private ProcessMessage ResizeMessageProcessor;
        #endregion

        #region Internal properties
        private bool movingForm;
        private Point formOffsetPoint;
        private Point offsetPoint;

        private bool resizingForm;
        private ResizeDir resizeDirection;
        private Rectangle formOffsetRect;
        private Point mousePoint;

        private Form originalForm;
        private Rectangle formRect;
        private Rectangle formOriginalRect;
        #endregion

        private static int stickGap = 20;
        private bool stickOnResize;
        private bool stickOnMove;
        private bool stickToScreen;
        private bool stickToOther;

        #region Public operations and properties
        public int StickGap
        {
            get { return stickGap; }
            set { stickGap = value; }
        }

        public bool StickOnResize
        {
            get { return stickOnResize; }
            set { stickOnResize = value; }
        }

        public bool StickOnMove
        {
            get { return stickOnMove; }
            set { stickOnMove = value; }
        }

        public bool StickToScreen
        {
            get { return stickToScreen; }
            set { stickToScreen = value; }
        }

        public bool StickToOther
        {
            get { return stickToOther; }
            set { stickToOther = value; }
        }

        public static void RegisterExternalReferenceForm(Form frmExternal)
        {
            GlobalStickyWindows.Add(frmExternal);
        }

        public static void UnregisterExternalReferenceForm(Form frmExternal)
        {
            GlobalStickyWindows.Remove(frmExternal);
        }
        #endregion

        #region StickyWindow Constructor
        public StickyWindow(Form form)
        {
            resizingForm = false;
            movingForm = false;

            originalForm = form;

            formRect = Rectangle.Empty;
            formOffsetRect = Rectangle.Empty;

            formOffsetPoint = Point.Empty;
            offsetPoint = Point.Empty;
            mousePoint = Point.Empty;

            stickOnMove = true;
            stickOnResize = false;
            stickToScreen = true;
            stickToOther = false;

            DefaultMessageProcessor = new ProcessMessage(DefaultMsgProcessor);
            MoveMessageProcessor = new ProcessMessage(MoveMsgProcessor);
            ResizeMessageProcessor = new ProcessMessage(ResizeMsgProcessor);
            MessageProcessor = DefaultMessageProcessor;

            AssignHandle(originalForm.Handle);
        }
        #endregion

        #region OnHandleChange
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void OnHandleChange()
        {
            if ((int)this.Handle != 0)
            {
                GlobalStickyWindows.Add(this.originalForm);
            }
            else
            {
                GlobalStickyWindows.Remove(this.originalForm);
            }
        }
        #endregion

        #region WndProc
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            if (!MessageProcessor(ref m))
                base.WndProc(ref m);
        }
        #endregion

        #region DefaultMsgProcessor
        private bool DefaultMsgProcessor(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM.WM_NCLBUTTONDOWN:
                    {
                        originalForm.Activate();
                        mousePoint.X = (short)Win32.Bit.LoWord((int)m.LParam);
                        mousePoint.Y = (short)Win32.Bit.HiWord((int)m.LParam);
                        if (OnNCLButtonDown((int)m.WParam, mousePoint))
                        {
                            m.Result = (IntPtr)((resizingForm || movingForm) ? 1 : 0);
                            return true;
                        }
                        break;
                    }
            }

            return false;
        }
        #endregion

        #region OnNCLButtonDown
        private bool OnNCLButtonDown(int iHitTest, Point point)
        {
            Rectangle rParent = originalForm.Bounds;
            offsetPoint = point;

            switch (iHitTest)
            {
                case Win32.HT.HTCAPTION:
                    {
                        if (stickOnMove)
                        {
                            offsetPoint.Offset(-rParent.Left, -rParent.Top);
                            StartMove();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case Win32.HT.HTTOPLEFT:
                    return StartResize(ResizeDir.Top | ResizeDir.Left);
                case Win32.HT.HTTOP:
                    return StartResize(ResizeDir.Top);
                case Win32.HT.HTTOPRIGHT:
                    return StartResize(ResizeDir.Top | ResizeDir.Right);
                case Win32.HT.HTRIGHT:
                    return StartResize(ResizeDir.Right);
                case Win32.HT.HTBOTTOMRIGHT:
                    return StartResize(ResizeDir.Bottom | ResizeDir.Right);
                case Win32.HT.HTBOTTOM:
                    return StartResize(ResizeDir.Bottom);
                case Win32.HT.HTBOTTOMLEFT:
                    return StartResize(ResizeDir.Bottom | ResizeDir.Left);
                case Win32.HT.HTLEFT:
                    return StartResize(ResizeDir.Left);
            }
            return false;
        }
        #endregion

        #region ResizeOperations
        private bool StartResize(ResizeDir resDir)
        {
            if (stickOnResize)
            {
                resizeDirection = resDir;
                formRect = originalForm.Bounds;
                formOriginalRect = originalForm.Bounds;

                if (!originalForm.Capture)
                    originalForm.Capture = true;

                MessageProcessor = ResizeMessageProcessor;

                return true;
            }
            else
                return false;
        }
        private bool ResizeMsgProcessor(ref Message m)
        {
            if (!originalForm.Capture)
            {
                Cancel();
                return false;
            }

            switch (m.Msg)
            {
                case Win32.WM.WM_LBUTTONUP:
                    {
                        EndResize();
                        break;
                    }
                case Win32.WM.WM_MOUSEMOVE:
                    {
                        mousePoint.X = (short)Win32.Bit.LoWord((int)m.LParam);
                        mousePoint.Y = (short)Win32.Bit.HiWord((int)m.LParam);
                        Resize(mousePoint);
                        break;
                    }
                case Win32.WM.WM_KEYDOWN:
                    {
                        if ((int)m.WParam == Win32.VK.VK_ESCAPE)
                        {
                            originalForm.Bounds = formOriginalRect;
                            Cancel();
                        }
                        break;
                    }
            }

            return false;
        }
        private void EndResize()
        {
            Cancel();
        }
        #endregion

        #region Resize Computing
        private void Resize(Point p)
        {
            p = originalForm.PointToScreen(p);
            Screen activeScr = Screen.FromPoint(p);
            formRect = originalForm.Bounds;

            int iRight = formRect.Right;
            int iBottom = formRect.Bottom;

            if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
            {
                formRect.Width = formRect.X - p.X + formRect.Width;
                formRect.X = iRight - formRect.Width;
            }
            if ((resizeDirection & ResizeDir.Right) == ResizeDir.Right)
                formRect.Width = p.X - formRect.Left;

            if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
            {
                formRect.Height = formRect.Height - p.Y + formRect.Top;
                formRect.Y = iBottom - formRect.Height;
            }
            if ((resizeDirection & ResizeDir.Bottom) == ResizeDir.Bottom)
                formRect.Height = p.Y - formRect.Top;

            formOffsetRect.X = stickGap + 1;
            formOffsetRect.Y = stickGap + 1;
            formOffsetRect.Height = 0;
            formOffsetRect.Width = 0;

            if (stickToScreen)
                Resize_Stick(activeScr.WorkingArea, false);

            if (stickToOther)
            {
                foreach (Form sw in GlobalStickyWindows)
                {
                    if (sw != this.originalForm)
                        Resize_Stick(sw.Bounds, true);
                }
            }

            if (formOffsetRect.X == stickGap + 1)
                formOffsetRect.X = 0;
            if (formOffsetRect.Width == stickGap + 1)
                formOffsetRect.Width = 0;
            if (formOffsetRect.Y == stickGap + 1)
                formOffsetRect.Y = 0;
            if (formOffsetRect.Height == stickGap + 1)
                formOffsetRect.Height = 0;

            if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
            {
                int iNewWidth = formRect.Width + formOffsetRect.Width + formOffsetRect.X;

                if (originalForm.MaximumSize.Width != 0)
                    iNewWidth = Math.Min(iNewWidth, originalForm.MaximumSize.Width);

                iNewWidth = Math.Min(iNewWidth, SystemInformation.MaxWindowTrackSize.Width);
                iNewWidth = Math.Max(iNewWidth, originalForm.MinimumSize.Width);
                iNewWidth = Math.Max(iNewWidth, SystemInformation.MinWindowTrackSize.Width);

                formRect.X = iRight - iNewWidth;
                formRect.Width = iNewWidth;
            }
            else
            {
                formRect.Width += formOffsetRect.Width + formOffsetRect.X;
            }

            if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
            {
                int iNewHeight = formRect.Height + formOffsetRect.Height + formOffsetRect.Y;

                if (originalForm.MaximumSize.Height != 0)
                    iNewHeight = Math.Min(iNewHeight, originalForm.MaximumSize.Height);

                iNewHeight = Math.Min(iNewHeight, SystemInformation.MaxWindowTrackSize.Height);
                iNewHeight = Math.Max(iNewHeight, originalForm.MinimumSize.Height);
                iNewHeight = Math.Max(iNewHeight, SystemInformation.MinWindowTrackSize.Height);

                formRect.Y = iBottom - iNewHeight;
                formRect.Height = iNewHeight;
            }
            else
            {
                formRect.Height += formOffsetRect.Height + formOffsetRect.Y;
            }

            originalForm.Bounds = formRect;
        }

        private void Resize_Stick(Rectangle toRect, bool bInsideStick)
        {
            if (formRect.Right >= (toRect.Left - stickGap) && formRect.Left <= (toRect.Right + stickGap))
            {
                if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
                {
                    if (Math.Abs(formRect.Top - toRect.Bottom) <= Math.Abs(formOffsetRect.Top) && bInsideStick)
                        formOffsetRect.Y = formRect.Top - toRect.Bottom;
                    else if (Math.Abs(formRect.Top - toRect.Top) <= Math.Abs(formOffsetRect.Top))
                        formOffsetRect.Y = formRect.Top - toRect.Top;
                }

                if ((resizeDirection & ResizeDir.Bottom) == ResizeDir.Bottom)
                {
                    if (Math.Abs(formRect.Bottom - toRect.Top) <= Math.Abs(formOffsetRect.Bottom) && bInsideStick)
                        formOffsetRect.Height = toRect.Top - formRect.Bottom;
                    else if (Math.Abs(formRect.Bottom - toRect.Bottom) <= Math.Abs(formOffsetRect.Bottom))
                        formOffsetRect.Height = toRect.Bottom - formRect.Bottom;
                }
            }

            if (formRect.Bottom >= (toRect.Top - stickGap) && formRect.Top <= (toRect.Bottom + stickGap))
            {
                if ((resizeDirection & ResizeDir.Right) == ResizeDir.Right)
                {
                    if (Math.Abs(formRect.Right - toRect.Left) <= Math.Abs(formOffsetRect.Right) && bInsideStick)
                        formOffsetRect.Width = toRect.Left - formRect.Right;
                    else if (Math.Abs(formRect.Right - toRect.Right) <= Math.Abs(formOffsetRect.Right))
                        formOffsetRect.Width = toRect.Right - formRect.Right;
                }

                if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
                {
                    if (Math.Abs(formRect.Left - toRect.Right) <= Math.Abs(formOffsetRect.Left) && bInsideStick)
                        formOffsetRect.X = formRect.Left - toRect.Right;
                    else if (Math.Abs(formRect.Left - toRect.Left) <= Math.Abs(formOffsetRect.Left))
                        formOffsetRect.X = formRect.Left - toRect.Left;
                }
            }
        }
        #endregion

        #region Move Operations
        private void StartMove()
        {
            formRect = originalForm.Bounds;
            formOriginalRect = originalForm.Bounds;

            if (!originalForm.Capture)
                originalForm.Capture = true;

            MessageProcessor = MoveMessageProcessor;
        }

        private bool MoveMsgProcessor(ref Message m)
        {
            if (!originalForm.Capture)
            {
                Cancel();
                return false;
            }

            switch (m.Msg)
            {
                case Win32.WM.WM_LBUTTONUP:
                    {
                        EndMove();
                        break;
                    }
                case Win32.WM.WM_MOUSEMOVE:
                    {
                        mousePoint.X = (short)Win32.Bit.LoWord((int)m.LParam);
                        mousePoint.Y = (short)Win32.Bit.HiWord((int)m.LParam);
                        Move(mousePoint);
                        break;
                    }
                case Win32.WM.WM_KEYDOWN:
                    {
                        if ((int)m.WParam == Win32.VK.VK_ESCAPE)
                        {
                            originalForm.Bounds = formOriginalRect;
                            Cancel();
                        }
                        break;
                    }
            }
            return false;
        }
        private void EndMove()
        {
            Cancel();
        }
        #endregion

        #region Move Computing
        private void Move(Point p)
        {
            p = originalForm.PointToScreen(p);
            Screen activeScr = Screen.FromPoint(p);

            if (!activeScr.WorkingArea.Contains(p))
            {
                p.X = NormalizeInside(p.X, activeScr.WorkingArea.Left, activeScr.WorkingArea.Right);
                p.Y = NormalizeInside(p.Y, activeScr.WorkingArea.Top, activeScr.WorkingArea.Bottom);
            }

            p.Offset(-offsetPoint.X, -offsetPoint.Y);

            formRect.Location = p;

            formOffsetPoint.X = stickGap + 1;
            formOffsetPoint.Y = stickGap + 1;

            if (stickToScreen)
                Move_Stick(activeScr.WorkingArea, false);

            if (stickToOther)
            {
                foreach (Form sw in GlobalStickyWindows)
                {
                    if (sw != this.originalForm)
                        Move_Stick(sw.Bounds, true);
                }
            }

            if (formOffsetPoint.X == stickGap + 1)
                formOffsetPoint.X = 0;
            if (formOffsetPoint.Y == stickGap + 1)
                formOffsetPoint.Y = 0;

            formRect.Offset(formOffsetPoint);

            originalForm.Bounds = formRect;
        }

        private void Move_Stick(Rectangle toRect, bool bInsideStick)
        {
            if (formRect.Bottom >= (toRect.Top - stickGap) && formRect.Top <= (toRect.Bottom + stickGap))
            {
                if (bInsideStick)
                {
                    if ((Math.Abs(formRect.Left - toRect.Right) <= Math.Abs(formOffsetPoint.X)))
                    {
                        formOffsetPoint.X = toRect.Right - formRect.Left;
                    }
                    if ((Math.Abs(formRect.Left + formRect.Width - toRect.Left) <= Math.Abs(formOffsetPoint.X)))
                    {
                        formOffsetPoint.X = toRect.Left - formRect.Width - formRect.Left;
                    }
                }

                if (Math.Abs(formRect.Left - toRect.Left) <= Math.Abs(formOffsetPoint.X))
                {
                    formOffsetPoint.X = toRect.Left - formRect.Left;
                }
                if (Math.Abs(formRect.Left + formRect.Width - toRect.Left - toRect.Width) <= Math.Abs(formOffsetPoint.X))
                {
                    formOffsetPoint.X = toRect.Left + toRect.Width - formRect.Width - formRect.Left;
                }
            }
            if (formRect.Right >= (toRect.Left - stickGap) && formRect.Left <= (toRect.Right + stickGap))
            {
                if (bInsideStick)
                {
                    if (Math.Abs(formRect.Top - toRect.Bottom) <= Math.Abs(formOffsetPoint.Y) && bInsideStick)
                    {
                        formOffsetPoint.Y = toRect.Bottom - formRect.Top;
                    }
                    if (Math.Abs(formRect.Top + formRect.Height - toRect.Top) <= Math.Abs(formOffsetPoint.Y) && bInsideStick)
                    {
                        formOffsetPoint.Y = toRect.Top - formRect.Height - formRect.Top;
                    }
                }

                if (Math.Abs(formRect.Top - toRect.Top) <= Math.Abs(formOffsetPoint.Y))
                {
                    formOffsetPoint.Y = toRect.Top - formRect.Top;
                }
                if (Math.Abs(formRect.Top + formRect.Height - toRect.Top - toRect.Height) <= Math.Abs(formOffsetPoint.Y))
                {
                    formOffsetPoint.Y = toRect.Top + toRect.Height - formRect.Height - formRect.Top;
                }
            }
        }
        #endregion

        #region Utilities
        private int NormalizeInside(int iP1, int iM1, int iM2)
        {
            if (iP1 <= iM1)
                return iM1;
            else
                if (iP1 >= iM2)
                return iM2;
            return iP1;
        }
        #endregion

        #region Cancel
        private void Cancel()
        {
            originalForm.Capture = false;
            movingForm = false;
            resizingForm = false;
            MessageProcessor = DefaultMessageProcessor;
        }
        #endregion
    }
}
