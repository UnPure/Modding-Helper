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

        private void frm_website_Load(object sender, EventArgs e)
        {
            this.TopMost = Modding_Helper.Properties.Settings.Default.alwaysontop;
        }

        public static string websiteName;
        public static string websiteURL;
        public static int cancel;

        int toggleMove;
        int MValX;
        int MValY;

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
                        cancel = 0;
                        this.Close();
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
            cancel = 1;
            this.Close();
        }

        private void btn_save_MouseDown(object sender, MouseEventArgs e)
        {
            btn_save.FlatAppearance.BorderSize = 1;
        }

        private void btn_save_MouseUp(object sender, MouseEventArgs e)
        {
            btn_save.FlatAppearance.BorderSize = 0;
        }

        private void btn_cancel_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cancel.FlatAppearance.BorderSize = 1;
        }

        private void btn_cancel_MouseUp(object sender, MouseEventArgs e)
        {
            btn_cancel.FlatAppearance.BorderSize = 0;
        }

        private void moveBox_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
        private void mainBoxTop_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
        private void mainBoxBottom_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
        private void labelName_MouseDown(object sender, MouseEventArgs e)
        {
            toggleMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void moveBox_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = 0;
        }
        private void mainBoxTop_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = 0;
        }
        private void mainBoxBottom_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = 0;
        }
        private void labelName_MouseUp(object sender, MouseEventArgs e)
        {
            toggleMove = 0;
        }

        private void moveBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX - 8, MousePosition.Y - MValY - 8);
            }
        }
        private void mainBoxTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        private void mainBoxBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY - 48);
            }
        }
        private void labelName_MouseMove(object sender, MouseEventArgs e)
        {
            if (toggleMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX - 15, MousePosition.Y - MValY - 15);
            }
        }
    }
}
