//////////////////////////////////////////////////////////////////////////////
// Modding-Helper
//
// Copyright (c) 2016 UnPure-Gaming - All rights reserved.
//
// This software is provided 'as-is', without any express or implied warranty.
// In no event will the author be held liable for any damages arising from
// the use of this software.
//
//////////////////////////////////////////////////////////////////////////////

using System.Windows.Forms;
using System.Drawing;

namespace Modding_Helper
{
    public class CustomButton : System.Windows.Forms.Button
    {
        public CustomButton()
            : base()
        {
            Size = new Size(75, 25);
        }

        private bool _DisplayFocusCues = true;
        protected override bool ShowFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
        }
        public bool DisplayFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
            set
            {
                _DisplayFocusCues = value;
            }
        }

        private string ownerDrawText;
        public string OwnerDrawText
        {
            get { return ownerDrawText; }
            set { ownerDrawText = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(ownerDrawText))
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(ownerDrawText, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            base.FlatAppearance.BorderSize = 1;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            base.FlatAppearance.BorderSize = 0;
        }
    }
}
