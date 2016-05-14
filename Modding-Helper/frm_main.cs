using FolderSelect;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Modding_Helper.CustomControls;

namespace Modding_Helper
{
    public partial class frm_main : Form
    {
        #region Constructor
        private Blue.Windows.StickyWindow stickyWindow;
        #endregion

        #region frm_main
        public frm_main()
        {
            InitializeComponent();

            stickyWindow = new Blue.Windows.StickyWindow(this);

            if (Properties.Settings.Default.FolderButtonStringCollection == null)
            {
                Properties.Settings.Default.FolderButtonStringCollection = new StringCollection();
            }

            if (Properties.Settings.Default.ProgramButtonStringCollection == null)
            {
                Properties.Settings.Default.ProgramButtonStringCollection = new StringCollection();
            }

            if (Properties.Settings.Default.WebsiteButtonStringCollection == null)
            {
                Properties.Settings.Default.WebsiteButtonStringCollection = new StringCollection();
            }

            if (Properties.Settings.Default.donotchangethis)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.donotchangethis = false;
            }

            selectButton(btn_modding, pnl_modding);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            mainBackground.BackColor = Color.FromArgb(255, 105, 105, 105);
            pnl_modding.BackColor = Color.FromArgb(255, 105, 105, 105);
            pnl_programs.BackColor = Color.FromArgb(255, 105, 105, 105);
            pnl_folder.BackColor = Color.FromArgb(255, 105, 105, 105);
            pnl_websites.BackColor = Color.FromArgb(255, 105, 105, 105);
            pnl_settings.BackColor = Color.FromArgb(255, 105, 105, 105);

            if (!(Properties.Settings.Default.controllocation == null))
            {
                this.Location = Properties.Settings.Default.controllocation;
            }

            if (!(Properties.Settings.Default.controlsize == null))
            {
                this.Size = Properties.Settings.Default.controlsize;
            }

            cb_alwaysOnTop.Checked = Properties.Settings.Default.alwaysontop;
            cb_minimizeToTray.Checked = Properties.Settings.Default.minimizetotray;
            cb_closeToTray.Checked = Properties.Settings.Default.closetotray;
            cb_stickyWindow.Checked = Properties.Settings.Default.stickywindow;

            this.TopMost = Properties.Settings.Default.alwaysontop;
            stickyWindow.StickOnMove = Properties.Settings.Default.stickywindow;

            foreach (string line in Properties.Settings.Default.FolderButtonStringCollection)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 2)
                    {
                        string nextButtonName = Convert.ToString(parts[0]);
                        string nextButtonPath = Convert.ToString(parts[1]);

                        createNewFolderButton(nextButtonName, nextButtonPath);
                    }
                }
            }

            foreach (string line in Properties.Settings.Default.ProgramButtonStringCollection)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 2)
                    {
                        string nextButtonName = Convert.ToString(parts[0]);
                        string nextButtonPath = Convert.ToString(parts[1]);

                        createNewProgramButton(nextButtonName, nextButtonPath);
                    }
                }
            }

            foreach (string line in Properties.Settings.Default.WebsiteButtonStringCollection)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 2)
                    {
                        string nextButtonName = Convert.ToString(parts[0]);
                        string nextButtonPath = Convert.ToString(parts[1]);

                        createNewWebsiteButton(nextButtonName, nextButtonPath);
                    }
                }
            }

            if (CheckForInternetConnection())
            {
                imageList.Images.Add(GetImageFromURL("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/apps/311210/bd3e3a9516b480164df25d16e49ae4ce4a063cb4.jpg"));
                imageList.Images.Add(GetImageFromURL("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/apps/455130/bd3e3a9516b480164df25d16e49ae4ce4a063cb4.jpg"));

                btn_launchBlackOpsIII.Image = imageList.Images[0];
                btn_launchBlackRadiant.Image = imageList.Images[1];

                //imgModding.BackgroundImage = GetImageFromURL("https://steamcdn-a.akamaihd.net/steam/apps/311210/header.jpg");
                //imgSettings.BackgroundImage = GetImageFromURL("https://steamcdn-a.akamaihd.net/steam/apps/311210/header.jpg");
            }
            else
            {
                btn_launchBlackOpsIII.Image = Properties.Resources.icon_21x21;
                btn_launchBlackRadiant.Image = Properties.Resources.icon_21x21;

                //imgModding.BackgroundImage = Properties.Resources.defaultlogo;
                //imgSettings.BackgroundImage = Properties.Resources.defaultlogo;
            }

            imgModding.BackgroundImage = Properties.Resources.defaultlogo;
            imgSettings.BackgroundImage = Properties.Resources.defaultlogo;
        }

        private void frm_main_Resize(object sender, EventArgs e)
        {
            int test = this.Width / 5;
            btn_modding.Width = test;
            btn_programs.Width = test;
            btn_settings.Width = test;
            btn_websites.Width = test;

            int test2 = this.Width - btn_modding.Width - btn_programs.Width - btn_settings.Width - btn_websites.Width;
            btn_folder.Width = test2;

            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar && Properties.Settings.Default.minimizetotray)
            {
                minimizeToTray();
            }
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((Properties.Settings.Default.closetotray) && !(closeNow))
            {
                e.Cancel = true;

                minimizeToTray();
            }

            Properties.Settings.Default.controlsize = this.Size;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Properties
        private string addFolderText;
        private string addFolderPath;

        private string addProgramText;
        private string addProgramPath;

        private string addWebsiteName;
        private string addWebsiteURL;

        private bool closeNow = false;
        #endregion

        #region Overrides
        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;
            const UInt32 WM_NCLBUTTONDBLCLK = 0x00A3;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOP2 = 2;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 8;

            bool handled = false;

            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>()
                {
                    {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
                    {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
                    {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE / 2) },
                    {HTTOP2, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width, 30) },
                    {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
                    {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)}
                };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            if (!handled)
            {
                base.WndProc(ref m);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        #endregion

        #region TabButtons
        private void btn_modding_Click(object sender, EventArgs e)
        {
            selectButton(btn_modding, pnl_modding);
        }

        private void btn_programs_Click(object sender, EventArgs e)
        {
            selectButton(btn_programs, pnl_programs);
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            selectButton(btn_folder, pnl_folder);
        }

        private void btn_websites_Click(object sender, EventArgs e)
        {
            selectButton(btn_websites, pnl_websites);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            selectButton(btn_settings, pnl_settings);
        }
        #endregion

        #region HeaderButtons
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Functions
        private void make_newFolderButtonAndStore(string name, string path)
        {
            createNewFolderButton(name, path);

            Properties.Settings.Default.FolderButtonStringCollection.Add(String.Format("{0};{1}", addFolderText, addFolderPath));
            Properties.Settings.Default.Save();
        }

        private void createNewFolderButton(string newFolderText, string newFolderPath)
        {
            var newButton = new FolderButtons(this) { openFolderText = newFolderText, openFolderPath = newFolderPath, Anchor = (AnchorStyles.Left | AnchorStyles.Right) };
            flowFolder.Controls.Add(newButton);

            addFolderText = newFolderText;
            addFolderPath = newFolderPath;
        }

        private void make_newProgramButtonAndStore(string name, string path)
        {
            createNewProgramButton(name, path);

            Properties.Settings.Default.ProgramButtonStringCollection.Add(String.Format("{0};{1}", addProgramText, addProgramPath));
            Properties.Settings.Default.Save();
        }

        private void createNewProgramButton(string newProgramText, string newProgramPath)
        {
            var newButton = new ProgramButtons(this) { openProgramText = newProgramText, openProgramPath = newProgramPath, Anchor = (AnchorStyles.Left | AnchorStyles.Right) };
            flowPrograms.Controls.Add(newButton);

            addProgramText = newProgramText;
            addProgramPath = newProgramPath;
        }

        private void make_newWebsiteButtonAndStore(string name, string path)
        {
            createNewWebsiteButton(name, path);

            Properties.Settings.Default.WebsiteButtonStringCollection.Add(String.Format("{0};{1}", addWebsiteName, addWebsiteURL));
            Properties.Settings.Default.Save();
        }

        private void createNewWebsiteButton(string newWebsiteName, string newWebsiteURL)
        {
            var newButton = new WebsiteButtons(this) { openWebsiteName = newWebsiteName, openWebsiteURL = newWebsiteURL, Anchor = (AnchorStyles.Left | AnchorStyles.Right) };
            flowWebsite.Controls.Add(newButton);

            addWebsiteName = newWebsiteName;
            addWebsiteURL = newWebsiteURL;
        }

        private void minimizeToTray()
        {
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.Hide();
        }

        private void openFromTray()
        {
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
        }

        private void selectButton(CustomTabButton currentButton, Panel currentPanel)
        {
            UserControl[] btn_array = { btn_modding, btn_programs, btn_folder, btn_websites, btn_settings };

            foreach (CustomTabButton i in btn_array)
            {
                i.Enabled = true;
                i.Part1 = Properties.Resources.tabButton1;
                i.Part2 = Properties.Resources.tabButton2;
                i.Part3 = Properties.Resources.tabButton3;
            }

            currentPanel.BringToFront();
            currentButton.Part1 = Properties.Resources.tabButton1_active;
            currentButton.Part2 = Properties.Resources.tabButton2_active;
            currentButton.Part3 = Properties.Resources.tabButton3_active;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static Image GetImageFromURL(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = httpWebReponse.GetResponseStream();
            return Image.FromStream(stream);
        }
        #endregion

        #region MainButtons_Click
        private void btn_addFolder_Click(object sender, EventArgs e)
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "Select Folder";
            fsd.InitialDirectory = @"c:\";

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                frm_folder frm_folderName = new frm_folder();
                frm_folderName.ShowDialog();

                if (frm_folder.cancel == 0)
                {
                    make_newFolderButtonAndStore(frm_folder.folderName, fsd.FileName);
                }
            }
        }

        private void btn_addProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Application";
            ofd.Filter = "Applications (*.exe)|*.exe|Batch files (*.bat)|*.bat";
            ofd.InitialDirectory = @"c:\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frm_program frm_programName = new frm_program();
                frm_programName.ShowDialog();

                if (frm_program.cancel == 0)
                {
                    make_newProgramButtonAndStore(frm_program.programName, ofd.FileName);
                }
            }
        }

        private void btn_addWebsite_Click(object sender, EventArgs e)
        {
            frm_website frm_websiteName = new frm_website();
            frm_websiteName.ShowDialog();

            if (frm_website.cancel == 0)
            {
                make_newWebsiteButtonAndStore(frm_website.websiteName, frm_website.websiteURL);
            }
        }

        private void btn_launchBlackOpsIII_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                System.Diagnostics.Process.Start("steam://run/311210");
            }
            else
            {
                MessageBox.Show("Could not find Steam.");
            }
        }

        private void btn_launchBlackRadiant_Click(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");

            if (regKey != null)
            {
                System.Diagnostics.Process.Start("steam://run/455130");
            }
            else
            {
                MessageBox.Show("Could not find Steam.");
            }
        }

        private void btn_importSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Config";
            ofd.Filter = "Config (*.config)|*.config";
            ofd.InitialDirectory = @"c:\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileAttributes attr = File.GetAttributes(ofd.FileName);
                if (!(attr.HasFlag(FileAttributes.ReadOnly)))
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                    var configPath = System.IO.Path.GetDirectoryName(config.FilePath);

                    if (!Directory.Exists(configPath))
                    {
                        Directory.CreateDirectory(configPath);
                    }

                    System.IO.File.Copy(ofd.FileName, config.FilePath, true);

                    Properties.Settings.Default.Reload();
                    Properties.Settings.Default.Save();

                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Can't import read-only files!");
                }
            }
        }

        private void btn_exportSettings_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

            if (!File.Exists(config.FilePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "modding-helper.config";
                savefile.Filter = "Config (*.config)|*.config";
                savefile.InitialDirectory = @"c:\";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.Save();
                    System.IO.File.Copy(config.FilePath, savefile.FileName, true);
                }
            }
        }

        private void btn_resetSettings_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to reset settings?", "Reset Settings", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }
        #endregion

        #region HoverEffects
        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Properties.Resources.button_minimize_hover;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Properties.Resources.button_minimize;
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.button_close_hover;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.button_close;
        }
        #endregion

        #region Checkboxes
        private void cb_minimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_minimizeToTray.Checked)
            {
                Properties.Settings.Default.minimizetotray = true;
            }
            else
            {
                Properties.Settings.Default.minimizetotray = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cb_closeToTray_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_closeToTray.Checked)
            {
                Properties.Settings.Default.closetotray = true;
            }
            else
            {
                Properties.Settings.Default.closetotray = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cb_alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_alwaysOnTop.Checked)
            {
                Properties.Settings.Default.alwaysontop = true;
                this.TopMost = true;
            }
            else
            {
                Properties.Settings.Default.alwaysontop = false;
                this.TopMost = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cb_stickyWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_stickyWindow.Checked)
            {
                Properties.Settings.Default.stickywindow = true;
                stickyWindow.StickOnMove = true;
            }
            else
            {
                Properties.Settings.Default.stickywindow = false;
                stickyWindow.StickOnMove = false;
            }
            Properties.Settings.Default.Save();
        }
        #endregion

        #region TrayStuff
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFromTray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeNow = true;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
            Application.Exit();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            openFromTray();
        }

        private void frm_main_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.controllocation = this.Location;
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
