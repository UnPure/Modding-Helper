namespace Modding_Helper
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.buttonBox = new System.Windows.Forms.Panel();
            this.btn_websites = new Modding_Helper.CustomControls.CustomTabButton();
            this.btn_settings = new Modding_Helper.CustomControls.CustomTabButton();
            this.btn_folder = new Modding_Helper.CustomControls.CustomTabButton();
            this.btn_programs = new Modding_Helper.CustomControls.CustomTabButton();
            this.btn_modding = new Modding_Helper.CustomControls.CustomTabButton();
            this.pnl_modding = new System.Windows.Forms.Panel();
            this.imgModding = new System.Windows.Forms.PictureBox();
            this.seperator1 = new System.Windows.Forms.PictureBox();
            this.btn_launchBlackRadiant = new Modding_Helper.CustomButtonFlat();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btn_launchBlackOpsIII = new Modding_Helper.CustomButtonFlat();
            this.pnl_programs = new System.Windows.Forms.Panel();
            this.bottomSpacer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addProgram = new Modding_Helper.CustomButtonFlat();
            this.flowPrograms = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_folder = new System.Windows.Forms.Panel();
            this.bottomSpacer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addFolder = new Modding_Helper.CustomButtonFlat();
            this.flowFolder = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_websites = new System.Windows.Forms.Panel();
            this.bottomSpacer3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addWebsite = new Modding_Helper.CustomButtonFlat();
            this.flowWebsite = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.btn_about = new Modding_Helper.CustomButtonFlat();
            this.btn_checkForUpdate = new Modding_Helper.CustomButtonFlat();
            this.cb_checkForUpdates = new Modding_Helper.CustomCheckBox();
            this.btn_resetSettings = new Modding_Helper.CustomButtonFlat();
            this.btn_exportSettings = new Modding_Helper.CustomButtonFlat();
            this.btn_importSettings = new Modding_Helper.CustomButtonFlat();
            this.cb_stickyWindow = new Modding_Helper.CustomCheckBox();
            this.cb_alwaysOnTop = new Modding_Helper.CustomCheckBox();
            this.cb_closeToTray = new Modding_Helper.CustomCheckBox();
            this.cb_minimizeToTray = new Modding_Helper.CustomCheckBox();
            this.mainBackground = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_minimize = new Modding_Helper.CustomButtonFlat();
            this.btn_close = new Modding_Helper.CustomButtonFlat();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBoxHeaderCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxHeaderBack = new Modding_Helper.CustomPictureBox();
            this.mainBoxHeaderRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxHeaderLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopLeft = new Modding_Helper.CustomPictureBox();
            this.buttonBox.SuspendLayout();
            this.pnl_modding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgModding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperator1)).BeginInit();
            this.pnl_programs.SuspendLayout();
            this.pnl_folder.SuspendLayout();
            this.pnl_websites.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            this.cms_notify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBox
            // 
            this.buttonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBox.Controls.Add(this.btn_websites);
            this.buttonBox.Controls.Add(this.btn_settings);
            this.buttonBox.Controls.Add(this.btn_folder);
            this.buttonBox.Controls.Add(this.btn_programs);
            this.buttonBox.Controls.Add(this.btn_modding);
            this.buttonBox.Location = new System.Drawing.Point(0, 30);
            this.buttonBox.MaximumSize = new System.Drawing.Size(0, 20);
            this.buttonBox.MinimumSize = new System.Drawing.Size(320, 20);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(320, 20);
            this.buttonBox.TabIndex = 5;
            // 
            // btn_websites
            // 
            this.btn_websites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_websites.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_websites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_websites.BackgroundImage")));
            this.btn_websites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_websites.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_websites.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_websites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_websites.Location = new System.Drawing.Point(192, 0);
            this.btn_websites.MaximumSize = new System.Drawing.Size(0, 20);
            this.btn_websites.MinimumSize = new System.Drawing.Size(64, 20);
            this.btn_websites.Name = "btn_websites";
            this.btn_websites.OwnerDrawText = "Websites";
            this.btn_websites.Part1 = ((System.Drawing.Image)(resources.GetObject("btn_websites.Part1")));
            this.btn_websites.Part2 = ((System.Drawing.Image)(resources.GetObject("btn_websites.Part2")));
            this.btn_websites.Part3 = ((System.Drawing.Image)(resources.GetObject("btn_websites.Part3")));
            this.btn_websites.Size = new System.Drawing.Size(64, 20);
            this.btn_websites.TabIndex = 7;
            this.btn_websites.Click += new System.EventHandler(this.btn_websites_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_settings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_settings.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_settings.Location = new System.Drawing.Point(256, 0);
            this.btn_settings.MaximumSize = new System.Drawing.Size(0, 20);
            this.btn_settings.MinimumSize = new System.Drawing.Size(64, 20);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.OwnerDrawText = "Settings";
            this.btn_settings.Part1 = ((System.Drawing.Image)(resources.GetObject("btn_settings.Part1")));
            this.btn_settings.Part2 = ((System.Drawing.Image)(resources.GetObject("btn_settings.Part2")));
            this.btn_settings.Part3 = ((System.Drawing.Image)(resources.GetObject("btn_settings.Part3")));
            this.btn_settings.Size = new System.Drawing.Size(64, 20);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_folder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_folder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_folder.BackgroundImage")));
            this.btn_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_folder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_folder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_folder.Location = new System.Drawing.Point(128, 0);
            this.btn_folder.MaximumSize = new System.Drawing.Size(0, 20);
            this.btn_folder.MinimumSize = new System.Drawing.Size(64, 20);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.OwnerDrawText = "Folder";
            this.btn_folder.Part1 = ((System.Drawing.Image)(resources.GetObject("btn_folder.Part1")));
            this.btn_folder.Part2 = ((System.Drawing.Image)(resources.GetObject("btn_folder.Part2")));
            this.btn_folder.Part3 = ((System.Drawing.Image)(resources.GetObject("btn_folder.Part3")));
            this.btn_folder.Size = new System.Drawing.Size(64, 20);
            this.btn_folder.TabIndex = 5;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_programs
            // 
            this.btn_programs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_programs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_programs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_programs.BackgroundImage")));
            this.btn_programs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_programs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_programs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_programs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_programs.Location = new System.Drawing.Point(64, 0);
            this.btn_programs.MaximumSize = new System.Drawing.Size(0, 20);
            this.btn_programs.MinimumSize = new System.Drawing.Size(64, 20);
            this.btn_programs.Name = "btn_programs";
            this.btn_programs.OwnerDrawText = "Programs";
            this.btn_programs.Part1 = ((System.Drawing.Image)(resources.GetObject("btn_programs.Part1")));
            this.btn_programs.Part2 = ((System.Drawing.Image)(resources.GetObject("btn_programs.Part2")));
            this.btn_programs.Part3 = ((System.Drawing.Image)(resources.GetObject("btn_programs.Part3")));
            this.btn_programs.Size = new System.Drawing.Size(64, 20);
            this.btn_programs.TabIndex = 4;
            this.btn_programs.Click += new System.EventHandler(this.btn_programs_Click);
            // 
            // btn_modding
            // 
            this.btn_modding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_modding.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_modding.BackgroundImage = global::Modding_Helper.Properties.Resources.tabButton2_active;
            this.btn_modding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modding.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_modding.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_modding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_modding.Location = new System.Drawing.Point(0, 0);
            this.btn_modding.MaximumSize = new System.Drawing.Size(0, 20);
            this.btn_modding.MinimumSize = new System.Drawing.Size(64, 20);
            this.btn_modding.Name = "btn_modding";
            this.btn_modding.OwnerDrawText = "Modding";
            this.btn_modding.Part1 = global::Modding_Helper.Properties.Resources.tabButton1_active;
            this.btn_modding.Part2 = global::Modding_Helper.Properties.Resources.tabButton2_active;
            this.btn_modding.Part3 = global::Modding_Helper.Properties.Resources.tabButton3_active;
            this.btn_modding.Size = new System.Drawing.Size(64, 20);
            this.btn_modding.TabIndex = 3;
            this.btn_modding.Click += new System.EventHandler(this.btn_modding_Click);
            // 
            // pnl_modding
            // 
            this.pnl_modding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_modding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_modding.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_modding.Controls.Add(this.imgModding);
            this.pnl_modding.Controls.Add(this.seperator1);
            this.pnl_modding.Controls.Add(this.btn_launchBlackRadiant);
            this.pnl_modding.Controls.Add(this.btn_launchBlackOpsIII);
            this.pnl_modding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_modding.Location = new System.Drawing.Point(8, 58);
            this.pnl_modding.MinimumSize = new System.Drawing.Size(304, 333);
            this.pnl_modding.Name = "pnl_modding";
            this.pnl_modding.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_modding.Size = new System.Drawing.Size(304, 333);
            this.pnl_modding.TabIndex = 16;
            // 
            // imgModding
            // 
            this.imgModding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgModding.BackgroundImage = global::Modding_Helper.Properties.Resources.defaultlogo;
            this.imgModding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgModding.Location = new System.Drawing.Point(0, 191);
            this.imgModding.Name = "imgModding";
            this.imgModding.Size = new System.Drawing.Size(304, 142);
            this.imgModding.TabIndex = 6;
            this.imgModding.TabStop = false;
            // 
            // seperator1
            // 
            this.seperator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seperator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seperator1.BackgroundImage")));
            this.seperator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seperator1.Location = new System.Drawing.Point(0, 184);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(304, 8);
            this.seperator1.TabIndex = 5;
            this.seperator1.TabStop = false;
            // 
            // btn_launchBlackRadiant
            // 
            this.btn_launchBlackRadiant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_launchBlackRadiant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_launchBlackRadiant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_launchBlackRadiant.BackgroundImage")));
            this.btn_launchBlackRadiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_launchBlackRadiant.DisplayFocusCues = false;
            this.btn_launchBlackRadiant.DrawBorder = true;
            this.btn_launchBlackRadiant.DrawClickBorder = true;
            this.btn_launchBlackRadiant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_launchBlackRadiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_launchBlackRadiant.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_launchBlackRadiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_launchBlackRadiant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_launchBlackRadiant.ImageList = this.imageList;
            this.btn_launchBlackRadiant.Location = new System.Drawing.Point(10, 44);
            this.btn_launchBlackRadiant.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_launchBlackRadiant.Name = "btn_launchBlackRadiant";
            this.btn_launchBlackRadiant.OwnerDrawText = "Launch Black Radiant";
            this.btn_launchBlackRadiant.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_launchBlackRadiant.Size = new System.Drawing.Size(284, 25);
            this.btn_launchBlackRadiant.TabIndex = 4;
            this.btn_launchBlackRadiant.TabStop = false;
            this.btn_launchBlackRadiant.UseVisualStyleBackColor = true;
            this.btn_launchBlackRadiant.Click += new System.EventHandler(this.btn_launchBlackRadiant_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(21, 21);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_launchBlackOpsIII
            // 
            this.btn_launchBlackOpsIII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_launchBlackOpsIII.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_launchBlackOpsIII.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_launchBlackOpsIII.BackgroundImage")));
            this.btn_launchBlackOpsIII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_launchBlackOpsIII.DisplayFocusCues = false;
            this.btn_launchBlackOpsIII.DrawBorder = true;
            this.btn_launchBlackOpsIII.DrawClickBorder = true;
            this.btn_launchBlackOpsIII.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_launchBlackOpsIII.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_launchBlackOpsIII.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_launchBlackOpsIII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_launchBlackOpsIII.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_launchBlackOpsIII.ImageList = this.imageList;
            this.btn_launchBlackOpsIII.Location = new System.Drawing.Point(10, 13);
            this.btn_launchBlackOpsIII.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_launchBlackOpsIII.Name = "btn_launchBlackOpsIII";
            this.btn_launchBlackOpsIII.OwnerDrawText = "Launch Black Ops III";
            this.btn_launchBlackOpsIII.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_launchBlackOpsIII.Size = new System.Drawing.Size(284, 25);
            this.btn_launchBlackOpsIII.TabIndex = 3;
            this.btn_launchBlackOpsIII.TabStop = false;
            this.btn_launchBlackOpsIII.UseVisualStyleBackColor = true;
            this.btn_launchBlackOpsIII.Click += new System.EventHandler(this.btn_launchBlackOpsIII_Click);
            // 
            // pnl_programs
            // 
            this.pnl_programs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_programs.AutoScroll = true;
            this.pnl_programs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_programs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_programs.Controls.Add(this.bottomSpacer2);
            this.pnl_programs.Controls.Add(this.btn_addProgram);
            this.pnl_programs.Controls.Add(this.flowPrograms);
            this.pnl_programs.Location = new System.Drawing.Point(8, 58);
            this.pnl_programs.Name = "pnl_programs";
            this.pnl_programs.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_programs.Size = new System.Drawing.Size(304, 333);
            this.pnl_programs.TabIndex = 29;
            // 
            // bottomSpacer2
            // 
            this.bottomSpacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomSpacer2.Location = new System.Drawing.Point(10, 38);
            this.bottomSpacer2.MinimumSize = new System.Drawing.Size(0, 10);
            this.bottomSpacer2.Name = "bottomSpacer2";
            this.bottomSpacer2.Size = new System.Drawing.Size(284, 10);
            this.bottomSpacer2.TabIndex = 9;
            // 
            // btn_addProgram
            // 
            this.btn_addProgram.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addProgram.BackgroundImage")));
            this.btn_addProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addProgram.DisplayFocusCues = false;
            this.btn_addProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addProgram.DrawBorder = true;
            this.btn_addProgram.DrawClickBorder = true;
            this.btn_addProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addProgram.FlatAppearance.BorderSize = 0;
            this.btn_addProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProgram.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_addProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_addProgram.Location = new System.Drawing.Point(10, 13);
            this.btn_addProgram.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_addProgram.Name = "btn_addProgram";
            this.btn_addProgram.OwnerDrawText = "Add new program";
            this.btn_addProgram.Size = new System.Drawing.Size(284, 25);
            this.btn_addProgram.TabIndex = 1;
            this.btn_addProgram.TabStop = false;
            this.toolTip.SetToolTip(this.btn_addProgram, "Add new program");
            this.btn_addProgram.UseVisualStyleBackColor = false;
            this.btn_addProgram.Click += new System.EventHandler(this.btn_addProgram_Click);
            // 
            // flowPrograms
            // 
            this.flowPrograms.AutoSize = true;
            this.flowPrograms.ColumnCount = 1;
            this.flowPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPrograms.Location = new System.Drawing.Point(10, 10);
            this.flowPrograms.Name = "flowPrograms";
            this.flowPrograms.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.flowPrograms.RowCount = 1;
            this.flowPrograms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowPrograms.Size = new System.Drawing.Size(284, 3);
            this.flowPrograms.TabIndex = 4;
            // 
            // pnl_folder
            // 
            this.pnl_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_folder.AutoScroll = true;
            this.pnl_folder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_folder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_folder.Controls.Add(this.bottomSpacer1);
            this.pnl_folder.Controls.Add(this.btn_addFolder);
            this.pnl_folder.Controls.Add(this.flowFolder);
            this.pnl_folder.Location = new System.Drawing.Point(8, 58);
            this.pnl_folder.Name = "pnl_folder";
            this.pnl_folder.Padding = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.pnl_folder.Size = new System.Drawing.Size(304, 333);
            this.pnl_folder.TabIndex = 30;
            // 
            // bottomSpacer1
            // 
            this.bottomSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomSpacer1.Location = new System.Drawing.Point(10, 38);
            this.bottomSpacer1.MinimumSize = new System.Drawing.Size(0, 10);
            this.bottomSpacer1.Name = "bottomSpacer1";
            this.bottomSpacer1.Size = new System.Drawing.Size(284, 10);
            this.bottomSpacer1.TabIndex = 8;
            // 
            // btn_addFolder
            // 
            this.btn_addFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addFolder.BackgroundImage")));
            this.btn_addFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addFolder.DisplayFocusCues = false;
            this.btn_addFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addFolder.DrawBorder = true;
            this.btn_addFolder.DrawClickBorder = true;
            this.btn_addFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addFolder.FlatAppearance.BorderSize = 0;
            this.btn_addFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_addFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_addFolder.Location = new System.Drawing.Point(10, 13);
            this.btn_addFolder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_addFolder.Name = "btn_addFolder";
            this.btn_addFolder.OwnerDrawText = "Add new folder";
            this.btn_addFolder.Size = new System.Drawing.Size(284, 25);
            this.btn_addFolder.TabIndex = 3;
            this.btn_addFolder.TabStop = false;
            this.toolTip.SetToolTip(this.btn_addFolder, "Add new folder");
            this.btn_addFolder.UseVisualStyleBackColor = false;
            this.btn_addFolder.Click += new System.EventHandler(this.btn_addFolder_Click);
            // 
            // flowFolder
            // 
            this.flowFolder.AutoSize = true;
            this.flowFolder.ColumnCount = 1;
            this.flowFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowFolder.Location = new System.Drawing.Point(10, 10);
            this.flowFolder.Name = "flowFolder";
            this.flowFolder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.flowFolder.RowCount = 1;
            this.flowFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowFolder.Size = new System.Drawing.Size(284, 3);
            this.flowFolder.TabIndex = 7;
            // 
            // pnl_websites
            // 
            this.pnl_websites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_websites.AutoScroll = true;
            this.pnl_websites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_websites.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_websites.Controls.Add(this.bottomSpacer3);
            this.pnl_websites.Controls.Add(this.btn_addWebsite);
            this.pnl_websites.Controls.Add(this.flowWebsite);
            this.pnl_websites.Location = new System.Drawing.Point(8, 58);
            this.pnl_websites.Name = "pnl_websites";
            this.pnl_websites.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_websites.Size = new System.Drawing.Size(304, 333);
            this.pnl_websites.TabIndex = 31;
            // 
            // bottomSpacer3
            // 
            this.bottomSpacer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomSpacer3.Location = new System.Drawing.Point(10, 38);
            this.bottomSpacer3.MinimumSize = new System.Drawing.Size(0, 10);
            this.bottomSpacer3.Name = "bottomSpacer3";
            this.bottomSpacer3.Size = new System.Drawing.Size(284, 10);
            this.bottomSpacer3.TabIndex = 9;
            // 
            // btn_addWebsite
            // 
            this.btn_addWebsite.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addWebsite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addWebsite.BackgroundImage")));
            this.btn_addWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addWebsite.DisplayFocusCues = false;
            this.btn_addWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addWebsite.DrawBorder = true;
            this.btn_addWebsite.DrawClickBorder = true;
            this.btn_addWebsite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addWebsite.FlatAppearance.BorderSize = 0;
            this.btn_addWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addWebsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_addWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_addWebsite.Location = new System.Drawing.Point(10, 13);
            this.btn_addWebsite.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_addWebsite.Name = "btn_addWebsite";
            this.btn_addWebsite.OwnerDrawText = "Add new website";
            this.btn_addWebsite.Size = new System.Drawing.Size(284, 25);
            this.btn_addWebsite.TabIndex = 5;
            this.btn_addWebsite.TabStop = false;
            this.toolTip.SetToolTip(this.btn_addWebsite, "Add new website");
            this.btn_addWebsite.UseVisualStyleBackColor = false;
            this.btn_addWebsite.Click += new System.EventHandler(this.btn_addWebsite_Click);
            // 
            // flowWebsite
            // 
            this.flowWebsite.AutoSize = true;
            this.flowWebsite.ColumnCount = 1;
            this.flowWebsite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowWebsite.Location = new System.Drawing.Point(10, 10);
            this.flowWebsite.Name = "flowWebsite";
            this.flowWebsite.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.flowWebsite.RowCount = 1;
            this.flowWebsite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowWebsite.Size = new System.Drawing.Size(284, 3);
            this.flowWebsite.TabIndex = 6;
            // 
            // pnl_settings
            // 
            this.pnl_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_settings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_settings.Controls.Add(this.btn_about);
            this.pnl_settings.Controls.Add(this.btn_checkForUpdate);
            this.pnl_settings.Controls.Add(this.cb_checkForUpdates);
            this.pnl_settings.Controls.Add(this.btn_resetSettings);
            this.pnl_settings.Controls.Add(this.btn_exportSettings);
            this.pnl_settings.Controls.Add(this.btn_importSettings);
            this.pnl_settings.Controls.Add(this.cb_stickyWindow);
            this.pnl_settings.Controls.Add(this.cb_alwaysOnTop);
            this.pnl_settings.Controls.Add(this.cb_closeToTray);
            this.pnl_settings.Controls.Add(this.cb_minimizeToTray);
            this.pnl_settings.Location = new System.Drawing.Point(8, 58);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_settings.Size = new System.Drawing.Size(304, 333);
            this.pnl_settings.TabIndex = 32;
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_about.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_about.BackgroundImage")));
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.DisplayFocusCues = false;
            this.btn_about.DrawBorder = true;
            this.btn_about.DrawClickBorder = true;
            this.btn_about.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_about.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_about.Location = new System.Drawing.Point(13, 249);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_about.Name = "btn_about";
            this.btn_about.OwnerDrawText = "About";
            this.btn_about.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_about.Size = new System.Drawing.Size(278, 25);
            this.btn_about.TabIndex = 14;
            this.btn_about.TabStop = false;
            this.toolTip.SetToolTip(this.btn_about, "Import saved settings");
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_checkForUpdate
            // 
            this.btn_checkForUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkForUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_checkForUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_checkForUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_checkForUpdate.BackgroundImage")));
            this.btn_checkForUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkForUpdate.DisplayFocusCues = false;
            this.btn_checkForUpdate.DrawBorder = true;
            this.btn_checkForUpdate.DrawClickBorder = true;
            this.btn_checkForUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_checkForUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkForUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_checkForUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_checkForUpdate.Location = new System.Drawing.Point(13, 218);
            this.btn_checkForUpdate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_checkForUpdate.Name = "btn_checkForUpdate";
            this.btn_checkForUpdate.OwnerDrawText = "Check for Updates";
            this.btn_checkForUpdate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_checkForUpdate.Size = new System.Drawing.Size(278, 25);
            this.btn_checkForUpdate.TabIndex = 13;
            this.btn_checkForUpdate.TabStop = false;
            this.toolTip.SetToolTip(this.btn_checkForUpdate, "Import saved settings");
            this.btn_checkForUpdate.UseVisualStyleBackColor = false;
            this.btn_checkForUpdate.Click += new System.EventHandler(this.btn_checkForUpdate_Click);
            // 
            // cb_checkForUpdates
            // 
            this.cb_checkForUpdates.AutoSize = true;
            this.cb_checkForUpdates.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_checkForUpdates.DisplayFocusCues = false;
            this.cb_checkForUpdates.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_checkForUpdates.Location = new System.Drawing.Point(13, 101);
            this.cb_checkForUpdates.Name = "cb_checkForUpdates";
            this.cb_checkForUpdates.Size = new System.Drawing.Size(158, 18);
            this.cb_checkForUpdates.TabIndex = 12;
            this.cb_checkForUpdates.Text = "Auto-Check for Updates";
            this.cb_checkForUpdates.UseVisualStyleBackColor = false;
            this.cb_checkForUpdates.CheckedChanged += new System.EventHandler(this.cb_checkForUpdates_CheckedChanged);
            // 
            // btn_resetSettings
            // 
            this.btn_resetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resetSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_resetSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_resetSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_resetSettings.BackgroundImage")));
            this.btn_resetSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resetSettings.DisplayFocusCues = false;
            this.btn_resetSettings.DrawBorder = true;
            this.btn_resetSettings.DrawClickBorder = true;
            this.btn_resetSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_resetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_resetSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_resetSettings.Location = new System.Drawing.Point(13, 187);
            this.btn_resetSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_resetSettings.Name = "btn_resetSettings";
            this.btn_resetSettings.OwnerDrawText = "Reset Settings";
            this.btn_resetSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_resetSettings.Size = new System.Drawing.Size(278, 25);
            this.btn_resetSettings.TabIndex = 11;
            this.btn_resetSettings.TabStop = false;
            this.toolTip.SetToolTip(this.btn_resetSettings, "Reset all settings to default");
            this.btn_resetSettings.UseVisualStyleBackColor = false;
            this.btn_resetSettings.Click += new System.EventHandler(this.btn_resetSettings_Click);
            // 
            // btn_exportSettings
            // 
            this.btn_exportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exportSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exportSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exportSettings.BackgroundImage")));
            this.btn_exportSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exportSettings.DisplayFocusCues = false;
            this.btn_exportSettings.DrawBorder = true;
            this.btn_exportSettings.DrawClickBorder = true;
            this.btn_exportSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exportSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_exportSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exportSettings.Location = new System.Drawing.Point(13, 156);
            this.btn_exportSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_exportSettings.Name = "btn_exportSettings";
            this.btn_exportSettings.OwnerDrawText = "Export Settings";
            this.btn_exportSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_exportSettings.Size = new System.Drawing.Size(278, 25);
            this.btn_exportSettings.TabIndex = 10;
            this.btn_exportSettings.TabStop = false;
            this.toolTip.SetToolTip(this.btn_exportSettings, "Export current settings");
            this.btn_exportSettings.UseVisualStyleBackColor = false;
            this.btn_exportSettings.Click += new System.EventHandler(this.btn_exportSettings_Click);
            // 
            // btn_importSettings
            // 
            this.btn_importSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_importSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_importSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_importSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_importSettings.BackgroundImage")));
            this.btn_importSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_importSettings.DisplayFocusCues = false;
            this.btn_importSettings.DrawBorder = true;
            this.btn_importSettings.DrawClickBorder = true;
            this.btn_importSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_importSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_importSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_importSettings.Location = new System.Drawing.Point(13, 125);
            this.btn_importSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_importSettings.Name = "btn_importSettings";
            this.btn_importSettings.OwnerDrawText = "Import Settings";
            this.btn_importSettings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btn_importSettings.Size = new System.Drawing.Size(278, 25);
            this.btn_importSettings.TabIndex = 9;
            this.btn_importSettings.TabStop = false;
            this.toolTip.SetToolTip(this.btn_importSettings, "Import saved settings");
            this.btn_importSettings.UseVisualStyleBackColor = false;
            this.btn_importSettings.Click += new System.EventHandler(this.btn_importSettings_Click);
            // 
            // cb_stickyWindow
            // 
            this.cb_stickyWindow.AutoSize = true;
            this.cb_stickyWindow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_stickyWindow.DisplayFocusCues = false;
            this.cb_stickyWindow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_stickyWindow.Location = new System.Drawing.Point(13, 79);
            this.cb_stickyWindow.Name = "cb_stickyWindow";
            this.cb_stickyWindow.Size = new System.Drawing.Size(106, 18);
            this.cb_stickyWindow.TabIndex = 3;
            this.cb_stickyWindow.Text = "Sticky Window";
            this.cb_stickyWindow.UseVisualStyleBackColor = false;
            this.cb_stickyWindow.CheckedChanged += new System.EventHandler(this.cb_stickyWindow_CheckedChanged);
            // 
            // cb_alwaysOnTop
            // 
            this.cb_alwaysOnTop.AutoSize = true;
            this.cb_alwaysOnTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_alwaysOnTop.DisplayFocusCues = false;
            this.cb_alwaysOnTop.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_alwaysOnTop.Location = new System.Drawing.Point(13, 57);
            this.cb_alwaysOnTop.Name = "cb_alwaysOnTop";
            this.cb_alwaysOnTop.Size = new System.Drawing.Size(107, 18);
            this.cb_alwaysOnTop.TabIndex = 2;
            this.cb_alwaysOnTop.Text = "Always On Top";
            this.cb_alwaysOnTop.UseVisualStyleBackColor = false;
            this.cb_alwaysOnTop.CheckedChanged += new System.EventHandler(this.cb_alwaysOnTop_CheckedChanged);
            // 
            // cb_closeToTray
            // 
            this.cb_closeToTray.AutoSize = true;
            this.cb_closeToTray.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_closeToTray.DisplayFocusCues = false;
            this.cb_closeToTray.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_closeToTray.Location = new System.Drawing.Point(13, 35);
            this.cb_closeToTray.Name = "cb_closeToTray";
            this.cb_closeToTray.Size = new System.Drawing.Size(100, 18);
            this.cb_closeToTray.TabIndex = 1;
            this.cb_closeToTray.Text = "Close To Tray";
            this.cb_closeToTray.UseVisualStyleBackColor = false;
            this.cb_closeToTray.CheckedChanged += new System.EventHandler(this.cb_closeToTray_CheckedChanged);
            // 
            // cb_minimizeToTray
            // 
            this.cb_minimizeToTray.AutoSize = true;
            this.cb_minimizeToTray.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_minimizeToTray.DisplayFocusCues = false;
            this.cb_minimizeToTray.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_minimizeToTray.Location = new System.Drawing.Point(13, 13);
            this.cb_minimizeToTray.Name = "cb_minimizeToTray";
            this.cb_minimizeToTray.Size = new System.Drawing.Size(118, 18);
            this.cb_minimizeToTray.TabIndex = 0;
            this.cb_minimizeToTray.Text = "Minimize To Tray";
            this.cb_minimizeToTray.UseVisualStyleBackColor = false;
            this.cb_minimizeToTray.CheckedChanged += new System.EventHandler(this.cb_minimizeToTray_CheckedChanged);
            // 
            // mainBackground
            // 
            this.mainBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBackground.Location = new System.Drawing.Point(8, 58);
            this.mainBackground.Name = "mainBackground";
            this.mainBackground.Size = new System.Drawing.Size(304, 333);
            this.mainBackground.TabIndex = 33;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.DisplayFocusCues = false;
            this.btn_minimize.DrawBorder = true;
            this.btn_minimize.DrawClickBorder = false;
            this.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(291, 10);
            this.btn_minimize.MaximumSize = new System.Drawing.Size(11, 10);
            this.btn_minimize.MinimumSize = new System.Drawing.Size(11, 10);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OwnerDrawText = null;
            this.btn_minimize.Size = new System.Drawing.Size(11, 10);
            this.btn_minimize.TabIndex = 27;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Text = "customButtonFlat3";
            this.toolTip.SetToolTip(this.btn_minimize, "Minimize");
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.DisplayFocusCues = false;
            this.btn_close.DrawBorder = true;
            this.btn_close.DrawClickBorder = false;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(303, 10);
            this.btn_close.MaximumSize = new System.Drawing.Size(11, 10);
            this.btn_close.MinimumSize = new System.Drawing.Size(11, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.OwnerDrawText = null;
            this.btn_close.Size = new System.Drawing.Size(11, 10);
            this.btn_close.TabIndex = 28;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "customButtonFlat4";
            this.toolTip.SetToolTip(this.btn_close, "Close");
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cms_notify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Modding-Helper";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // cms_notify
            // 
            this.cms_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cms_notify.Name = "cms_notify";
            this.cms_notify.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Modding_Helper.Properties.Resources.show_small_icon;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Modding_Helper.Properties.Resources.close_small_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainBoxHeaderCenter
            // 
            this.mainBoxHeaderCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBoxHeaderCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxHeaderCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxHeaderCenter.BackgroundImage")));
            this.mainBoxHeaderCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxHeaderCenter.Location = new System.Drawing.Point(112, 0);
            this.mainBoxHeaderCenter.MaximumSize = new System.Drawing.Size(96, 30);
            this.mainBoxHeaderCenter.MinimumSize = new System.Drawing.Size(96, 30);
            this.mainBoxHeaderCenter.Name = "mainBoxHeaderCenter";
            this.mainBoxHeaderCenter.Size = new System.Drawing.Size(96, 30);
            this.mainBoxHeaderCenter.TabIndex = 25;
            this.mainBoxHeaderCenter.TabStop = false;
            // 
            // mainBoxHeaderBack
            // 
            this.mainBoxHeaderBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxHeaderBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxHeaderBack.BackgroundImage")));
            this.mainBoxHeaderBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxHeaderBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBoxHeaderBack.Location = new System.Drawing.Point(37, 0);
            this.mainBoxHeaderBack.MaximumSize = new System.Drawing.Size(0, 30);
            this.mainBoxHeaderBack.MinimumSize = new System.Drawing.Size(246, 30);
            this.mainBoxHeaderBack.Name = "mainBoxHeaderBack";
            this.mainBoxHeaderBack.Size = new System.Drawing.Size(246, 30);
            this.mainBoxHeaderBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainBoxHeaderBack.TabIndex = 24;
            this.mainBoxHeaderBack.TabStop = false;
            // 
            // mainBoxHeaderRight
            // 
            this.mainBoxHeaderRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxHeaderRight.BackgroundImage")));
            this.mainBoxHeaderRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainBoxHeaderRight.Location = new System.Drawing.Point(283, 0);
            this.mainBoxHeaderRight.MaximumSize = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderRight.MinimumSize = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderRight.Name = "mainBoxHeaderRight";
            this.mainBoxHeaderRight.Size = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderRight.TabIndex = 26;
            this.mainBoxHeaderRight.TabStop = false;
            // 
            // mainBoxHeaderLeft
            // 
            this.mainBoxHeaderLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxHeaderLeft.BackgroundImage")));
            this.mainBoxHeaderLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainBoxHeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.mainBoxHeaderLeft.MaximumSize = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderLeft.MinimumSize = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderLeft.Name = "mainBoxHeaderLeft";
            this.mainBoxHeaderLeft.Size = new System.Drawing.Size(37, 30);
            this.mainBoxHeaderLeft.TabIndex = 23;
            this.mainBoxHeaderLeft.TabStop = false;
            // 
            // mainBoxBottomRight
            // 
            this.mainBoxBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBoxBottomRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxBottomRight.BackgroundImage")));
            this.mainBoxBottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxBottomRight.Location = new System.Drawing.Point(208, 350);
            this.mainBoxBottomRight.MaximumSize = new System.Drawing.Size(112, 66);
            this.mainBoxBottomRight.MinimumSize = new System.Drawing.Size(112, 66);
            this.mainBoxBottomRight.Name = "mainBoxBottomRight";
            this.mainBoxBottomRight.Size = new System.Drawing.Size(112, 66);
            this.mainBoxBottomRight.TabIndex = 13;
            this.mainBoxBottomRight.TabStop = false;
            // 
            // mainBoxBottomCenter
            // 
            this.mainBoxBottomCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBoxBottomCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxBottomCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxBottomCenter.BackgroundImage")));
            this.mainBoxBottomCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxBottomCenter.Location = new System.Drawing.Point(112, 350);
            this.mainBoxBottomCenter.MaximumSize = new System.Drawing.Size(0, 66);
            this.mainBoxBottomCenter.MinimumSize = new System.Drawing.Size(96, 66);
            this.mainBoxBottomCenter.Name = "mainBoxBottomCenter";
            this.mainBoxBottomCenter.Size = new System.Drawing.Size(96, 66);
            this.mainBoxBottomCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainBoxBottomCenter.TabIndex = 12;
            this.mainBoxBottomCenter.TabStop = false;
            // 
            // mainBoxBottomLeft
            // 
            this.mainBoxBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainBoxBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxBottomLeft.BackgroundImage")));
            this.mainBoxBottomLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxBottomLeft.Location = new System.Drawing.Point(0, 350);
            this.mainBoxBottomLeft.MaximumSize = new System.Drawing.Size(112, 66);
            this.mainBoxBottomLeft.MinimumSize = new System.Drawing.Size(112, 66);
            this.mainBoxBottomLeft.Name = "mainBoxBottomLeft";
            this.mainBoxBottomLeft.Size = new System.Drawing.Size(112, 66);
            this.mainBoxBottomLeft.TabIndex = 11;
            this.mainBoxBottomLeft.TabStop = false;
            // 
            // mainBoxRight
            // 
            this.mainBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBoxRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxRight.BackgroundImage")));
            this.mainBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxRight.Location = new System.Drawing.Point(312, 99);
            this.mainBoxRight.MaximumSize = new System.Drawing.Size(8, 0);
            this.mainBoxRight.MinimumSize = new System.Drawing.Size(8, 251);
            this.mainBoxRight.Name = "mainBoxRight";
            this.mainBoxRight.Size = new System.Drawing.Size(8, 251);
            this.mainBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainBoxRight.TabIndex = 10;
            this.mainBoxRight.TabStop = false;
            // 
            // mainBoxLeft
            // 
            this.mainBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainBoxLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxLeft.BackgroundImage")));
            this.mainBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxLeft.Location = new System.Drawing.Point(0, 99);
            this.mainBoxLeft.MaximumSize = new System.Drawing.Size(8, 0);
            this.mainBoxLeft.MinimumSize = new System.Drawing.Size(8, 251);
            this.mainBoxLeft.Name = "mainBoxLeft";
            this.mainBoxLeft.Size = new System.Drawing.Size(8, 251);
            this.mainBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainBoxLeft.TabIndex = 9;
            this.mainBoxLeft.TabStop = false;
            // 
            // mainBoxTopRight
            // 
            this.mainBoxTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBoxTopRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxTopRight.BackgroundImage")));
            this.mainBoxTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxTopRight.Location = new System.Drawing.Point(208, 50);
            this.mainBoxTopRight.MaximumSize = new System.Drawing.Size(112, 49);
            this.mainBoxTopRight.MinimumSize = new System.Drawing.Size(112, 49);
            this.mainBoxTopRight.Name = "mainBoxTopRight";
            this.mainBoxTopRight.Size = new System.Drawing.Size(112, 49);
            this.mainBoxTopRight.TabIndex = 8;
            this.mainBoxTopRight.TabStop = false;
            // 
            // mainBoxTopCenter
            // 
            this.mainBoxTopCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBoxTopCenter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxTopCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxTopCenter.BackgroundImage")));
            this.mainBoxTopCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxTopCenter.Location = new System.Drawing.Point(112, 50);
            this.mainBoxTopCenter.MaximumSize = new System.Drawing.Size(0, 49);
            this.mainBoxTopCenter.MinimumSize = new System.Drawing.Size(96, 49);
            this.mainBoxTopCenter.Name = "mainBoxTopCenter";
            this.mainBoxTopCenter.Size = new System.Drawing.Size(96, 49);
            this.mainBoxTopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainBoxTopCenter.TabIndex = 7;
            this.mainBoxTopCenter.TabStop = false;
            // 
            // mainBoxTopLeft
            // 
            this.mainBoxTopLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxTopLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBoxTopLeft.BackgroundImage")));
            this.mainBoxTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxTopLeft.Location = new System.Drawing.Point(0, 50);
            this.mainBoxTopLeft.MaximumSize = new System.Drawing.Size(112, 49);
            this.mainBoxTopLeft.MinimumSize = new System.Drawing.Size(112, 49);
            this.mainBoxTopLeft.Name = "mainBoxTopLeft";
            this.mainBoxTopLeft.Size = new System.Drawing.Size(112, 49);
            this.mainBoxTopLeft.TabIndex = 6;
            this.mainBoxTopLeft.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(320, 416);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_modding);
            this.Controls.Add(this.pnl_programs);
            this.Controls.Add(this.pnl_folder);
            this.Controls.Add(this.pnl_websites);
            this.Controls.Add(this.pnl_settings);
            this.Controls.Add(this.mainBackground);
            this.Controls.Add(this.mainBoxHeaderCenter);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.mainBoxHeaderBack);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.mainBoxHeaderRight);
            this.Controls.Add(this.mainBoxHeaderLeft);
            this.Controls.Add(this.buttonBox);
            this.Controls.Add(this.mainBoxBottomRight);
            this.Controls.Add(this.mainBoxBottomCenter);
            this.Controls.Add(this.mainBoxBottomLeft);
            this.Controls.Add(this.mainBoxRight);
            this.Controls.Add(this.mainBoxLeft);
            this.Controls.Add(this.mainBoxTopRight);
            this.Controls.Add(this.mainBoxTopCenter);
            this.Controls.Add(this.mainBoxTopLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 416);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modding-Helper";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.LocationChanged += new System.EventHandler(this.frm_main_LocationChanged);
            this.Resize += new System.EventHandler(this.frm_main_Resize);
            this.buttonBox.ResumeLayout(false);
            this.pnl_modding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgModding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperator1)).EndInit();
            this.pnl_programs.ResumeLayout(false);
            this.pnl_programs.PerformLayout();
            this.pnl_folder.ResumeLayout(false);
            this.pnl_folder.PerformLayout();
            this.pnl_websites.ResumeLayout(false);
            this.pnl_websites.PerformLayout();
            this.pnl_settings.ResumeLayout(false);
            this.pnl_settings.PerformLayout();
            this.cms_notify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxHeaderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel buttonBox;
        private CustomPictureBox mainBoxTopLeft;
        private CustomPictureBox mainBoxTopCenter;
        private CustomPictureBox mainBoxTopRight;
        private CustomPictureBox mainBoxLeft;
        private CustomPictureBox mainBoxRight;
        private CustomPictureBox mainBoxBottomLeft;
        private CustomPictureBox mainBoxBottomCenter;
        private CustomPictureBox mainBoxBottomRight;
        private System.Windows.Forms.Panel pnl_modding;
        private CustomPictureBox mainBoxHeaderCenter;
        private CustomButtonFlat btn_minimize;
        private CustomPictureBox mainBoxHeaderBack;
        private CustomButtonFlat btn_close;
        private CustomPictureBox mainBoxHeaderRight;
        private CustomPictureBox mainBoxHeaderLeft;
        private CustomControls.CustomTabButton btn_modding;
        private CustomControls.CustomTabButton btn_websites;
        private CustomControls.CustomTabButton btn_settings;
        private CustomControls.CustomTabButton btn_folder;
        private CustomControls.CustomTabButton btn_programs;
        private System.Windows.Forms.Panel pnl_programs;
        private System.Windows.Forms.Panel pnl_folder;
        private System.Windows.Forms.Panel pnl_websites;
        private System.Windows.Forms.Panel pnl_settings;
        public CustomButtonFlat btn_addProgram;
        public CustomButtonFlat btn_addFolder;
        public CustomButtonFlat btn_addWebsite;
        private System.Windows.Forms.PictureBox imgModding;
        private System.Windows.Forms.PictureBox seperator1;
        private CustomButtonFlat btn_launchBlackRadiant;
        private CustomButtonFlat btn_launchBlackOpsIII;
        private CustomCheckBox cb_stickyWindow;
        private CustomCheckBox cb_alwaysOnTop;
        private CustomCheckBox cb_closeToTray;
        private CustomCheckBox cb_minimizeToTray;
        private CustomButtonFlat btn_importSettings;
        private CustomButtonFlat btn_resetSettings;
        private CustomButtonFlat btn_exportSettings;
        private System.Windows.Forms.TableLayoutPanel flowPrograms;
        private System.Windows.Forms.TableLayoutPanel flowFolder;
        private System.Windows.Forms.TableLayoutPanel flowWebsite;
        private System.Windows.Forms.FlowLayoutPanel bottomSpacer1;
        private System.Windows.Forms.FlowLayoutPanel bottomSpacer2;
        private System.Windows.Forms.FlowLayoutPanel bottomSpacer3;
        private System.Windows.Forms.Panel mainBackground;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cms_notify;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private CustomButtonFlat btn_checkForUpdate;
        private CustomCheckBox cb_checkForUpdates;
        private CustomButtonFlat btn_about;
    }
}

