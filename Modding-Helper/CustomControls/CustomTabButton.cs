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

using System.Drawing;
using System.Windows.Forms;

namespace Modding_Helper.CustomControls
{
    public partial class CustomTabButton : UserControl
    {
        public CustomTabButton()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private string ownerDrawText;
        public string OwnerDrawText
        {
            get { return ownerDrawText; }
            set { ownerDrawText = value; Invalidate(); }
        }

        private Image part1;
        public Image Part1
        {
            get { return part1; }
            set { part1 = value; pictureBox1.BackgroundImage = value; Invalidate(); }
        }

        private Image part2;
        public Image Part2
        {
            get { return part2; }
            set { part2 = value; this.BackgroundImage = value; Invalidate(); }
        }

        private Image part3;
        public Image Part3
        {
            get { return part3; }
            set { part3 = value; pictureBox2.BackgroundImage = value; Invalidate(); }
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
    }
}
