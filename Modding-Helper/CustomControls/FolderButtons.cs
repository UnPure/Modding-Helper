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
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Modding_Helper
{
    public partial class FolderButtons : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;
                return parms;
            }
        }

        private string _openFolderText = string.Empty;
        public string openFolderText
        {
            get { return _openFolderText; }
            set { _openFolderText = value; }
        }

        private string _openFolderPath = string.Empty;
        public string openFolderPath
        {
            get { return _openFolderPath; }
            set { _openFolderPath = value; }
        }

        public frm_main frm;

        public FolderButtons(frm_main frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void FolderButtons_Load(object sender, EventArgs e)
        {
            openFolder.Text = openFolderText;
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(openFolderPath))
            {
                System.Diagnostics.Process.Start(@openFolderPath);
            }
            else
            {
                MessageBox.Show("Folder does not exist!");
            }
        }

        private void openFolder_MouseDown(object sender, MouseEventArgs e)
        {
            openFolder.FlatAppearance.BorderSize = 1;
        }

        private void openFolder_MouseUp(object sender, MouseEventArgs e)
        {
            openFolder.FlatAppearance.BorderSize = 0;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            Properties.Settings.Default.FolderButtonStringCollection.Remove(String.Format("{0};{1}", openFolderText, openFolderPath));
        }

        private void removeButton_MouseDown(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 1;
        }

        private void removeButton_MouseUp(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 0;
        }

        private void openFolder_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, 0, 0, openFolder.Width + 1, openFolder.Height);
            pen.Dispose();
        }

        private void removeButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, 0, 0, removeButton.Width, removeButton.Height);
            pen.Dispose();
        }
    }
}
