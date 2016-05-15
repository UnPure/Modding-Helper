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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modding_Helper
{
    public partial class WebsiteButtons : UserControl
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

        private string _openWebsiteName = string.Empty;
        public string openWebsiteName
        {
            get { return _openWebsiteName; }
            set { _openWebsiteName = value; }
        }

        private string _openWebsiteURL = string.Empty;
        public string openWebsiteURL
        {
            get { return _openWebsiteURL; }
            set { _openWebsiteURL = value; }
        }

        public frm_main frm;

        public WebsiteButtons(frm_main frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void WebsiteButtons_Load(object sender, EventArgs e)
        {
            openWebsite.Text = openWebsiteName;

            if(frm_main.CheckForInternetConnection())
            {
                websiteImageList.Images.Add(frm_main.GetImageFromURL("http://www.google.com/s2/favicons?domain_url=" + openWebsiteURL));
                openWebsite.Image = websiteImageList.Images[0];
            }
            else
            {
                openWebsite.Image = Modding_Helper.Properties.Resources.icon_21x21;
            }
        }

        private void openWebsite_Click(object sender, EventArgs e)
        {
            string regular = @"^(ht|f|sf)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";
            string regular123 = @"^(www.)[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

            string newOpenWebsiteURL = openWebsiteURL.Trim();
            if (Regex.IsMatch(newOpenWebsiteURL, regular))
            {
                if(frm_main.CheckForInternetConnection())
                {
                    System.Diagnostics.Process.Start(@openWebsiteURL);
                }
            }
            else if (Regex.IsMatch(newOpenWebsiteURL, regular123))
            {
                if (frm_main.CheckForInternetConnection())
                {
                    System.Diagnostics.Process.Start(@openWebsiteURL);
                }
            }
        }

        private void openWebsite_MouseDown(object sender, MouseEventArgs e)
        {
            openWebsite.FlatAppearance.BorderSize = 1;
        }

        private void openWebsite_MouseUp(object sender, MouseEventArgs e)
        {
            openWebsite.FlatAppearance.BorderSize = 0;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            Properties.Settings.Default.WebsiteButtonStringCollection.Remove(String.Format("{0};{1}", openWebsiteName, openWebsiteURL));
        }

        private void removeButton_MouseDown(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 1;
        }

        private void removeButton_MouseUp(object sender, MouseEventArgs e)
        {
            removeButton.FlatAppearance.BorderSize = 0;
        }

        private void openWebsite_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(this.BackColor);
            g.DrawRectangle(pen, 0, 0, openWebsite.Width + 1, openWebsite.Height);
            pen.Dispose();
        }

        private void removeButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(this.BackColor);
            g.DrawRectangle(pen, 0, 0, removeButton.Width + 1, removeButton.Height);
            pen.Dispose();
        }
    }
}
