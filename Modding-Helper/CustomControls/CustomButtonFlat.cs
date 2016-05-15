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
    public class CustomButtonFlat : System.Windows.Forms.Button
    {
        public CustomButtonFlat()
            : base()
        {
            Size = new Size(75, 25);
            TabStop = false;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //FlatAppearance.BorderSize = 0;
            //FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private bool _DisplayFocusCues = false;
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

        private bool drawBorder = true;
        public bool DrawBorder
        {
            get { return drawBorder; }
            set { drawBorder = value; }
        }

        private bool drawClickBorder = true;
        public bool DrawClickBorder
        {
            get { return drawClickBorder; }
            set { drawClickBorder = value; }
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

            if(drawBorder)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                Brush brush = new SolidBrush(this.BackColor);
                g.DrawRectangle(pen, 0, 0, this.Width, this.Height);
                pen.Dispose();
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if(drawClickBorder)
                this.FlatAppearance.BorderSize = 1;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            if (drawClickBorder)
                this.FlatAppearance.BorderSize = 0;
        }
    }
}
