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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modding_Helper
{
    public partial class frm_website : Form
    {
        public frm_website()
        {
            InitializeComponent();
        }

        #region Properties
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;

        public static string websiteName;
        public static string websiteURL;
        public static bool cancel;
        #endregion

        #region Overrides
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == WM_NCLBUTTONDBLCLK)
            {
                message.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
            {
                message.Result = (IntPtr)HTCAPTION;
            }
        }
        #endregion

        #region Buttons
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txt_websiteName.Text)) && !(string.IsNullOrWhiteSpace(txt_websiteURL.Text)))
            {
                string newWebsiteURL = txt_websiteURL.Text.Trim();
                string regular = @"^(ht|f|sf)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";

                if (Regex.IsMatch(newWebsiteURL, regular))
                {
                    if (frm_main.CheckForInternetConnection())
                    {
                        websiteName = txt_websiteName.Text;
                        websiteURL = txt_websiteURL.Text;
                        cancel = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Could not connect to the internet!");
                    }
                }
                else
                {
                    txt_websiteURL.Focus();
                    txt_websiteURL.Text = "http://";
                    txt_websiteURL.SelectionStart = txt_websiteURL.Text.Length;
                }
            }
            else
            {
                txt_websiteName.Focus();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }
        #endregion

        #region Misc
        private void txt_websiteURL_Enter(object sender, EventArgs e)
        {
            txt_websiteURL.SelectionStart = txt_websiteURL.TextLength;
        }
        #endregion
    }
}
