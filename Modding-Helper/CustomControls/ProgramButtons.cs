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

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Modding_Helper
{
    public partial class ProgramButtons : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private string _openProgramText = string.Empty;
        public string openProgramText
        {
            get { return _openProgramText; }
            set { _openProgramText = value; }
        }

        private string _openProgramPath = string.Empty;
        public string openProgramPath
        {
            get { return _openProgramPath; }
            set { _openProgramPath = value; }
        }

        private bool drawBorder = true;
        public bool DrawBorder
        {
            get { return drawBorder; }
            set { drawBorder = value; }
        }

        public frm_main frm;

        public ProgramButtons(frm_main frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ProgramButtons_Load(object sender, EventArgs e)
        {
            openProgram.Text = openProgramText;

            Icon iconForFile = SystemIcons.WinLogo;
            iconForFile = Icon.ExtractAssociatedIcon(openProgramPath);

            programImageList.Images.Add(iconForFile);
            openProgram.Image = programImageList.Images[0];
        }

        private void openProgram_Click(object sender, EventArgs e)
        {
            if(File.Exists(openProgramPath))
            {
                System.Diagnostics.Process.Start(@openProgramPath);
            }
            else
            {
                MessageBox.Show("Program does not exist!");
            }
        }

        private void openProgram_MouseDown(object sender, MouseEventArgs e)
        {
            openProgram.FlatAppearance.BorderSize = 1;
        }

        private void openProgram_MouseUp(object sender, MouseEventArgs e)
        {
            openProgram.FlatAppearance.BorderSize = 0;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            Properties.Settings.Default.ProgramButtonStringCollection.Remove(String.Format("{0};{1}", openProgramText, openProgramPath));
        }

        private void removeButton_MouseDown(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 1;
        }

        private void removeButton_MouseUp(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 0;
        }

        private void openProgram_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(this.BackColor);
            g.DrawRectangle(pen, 0, 0, openProgram.Width + 1, openProgram.Height);
            pen.Dispose();
        }

        private void removeButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(this.BackColor);
            g.DrawRectangle(pen, 0, 0, removeButton.Width, removeButton.Height);
            pen.Dispose();
        }
    }
}
