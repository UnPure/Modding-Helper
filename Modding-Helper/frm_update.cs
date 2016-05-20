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
using System.Windows.Forms;

namespace Modding_Helper
{
    public partial class frm_update : Form
    {
        public frm_update()
        {
            InitializeComponent();
        }

        #region Properties
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
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
        private void btn_download_Click(object sender, EventArgs e)
        {
            string downloadURL = "http://unpure-gaming.de/index/files/download/where/55/target/1";

            if (frm_main.CheckForInternetConnection())
            {
                System.Diagnostics.Process.Start(@downloadURL);
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
