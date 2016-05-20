namespace Modding_Helper
{
    partial class frm_update
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
            this.rtb_changelog = new System.Windows.Forms.RichTextBox();
            this.lbl_updateAvailable = new System.Windows.Forms.Label();
            this.lbl_infoText = new System.Windows.Forms.Label();
            this.lbl_curVersion = new System.Windows.Forms.Label();
            this.lbl_newVersion = new System.Windows.Forms.Label();
            this.btn_cancel = new Modding_Helper.CustomButtonFlat();
            this.btn_download = new Modding_Helper.CustomButtonFlat();
            this.mainBoxLogo = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxLeft = new Modding_Helper.CustomPictureBox();
            this.curVersion = new System.Windows.Forms.Label();
            this.newVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_changelog
            // 
            this.rtb_changelog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtb_changelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_changelog.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_changelog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_changelog.Location = new System.Drawing.Point(18, 136);
            this.rtb_changelog.Name = "rtb_changelog";
            this.rtb_changelog.ReadOnly = true;
            this.rtb_changelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_changelog.Size = new System.Drawing.Size(284, 135);
            this.rtb_changelog.TabIndex = 28;
            this.rtb_changelog.TabStop = false;
            this.rtb_changelog.Text = "";
            // 
            // lbl_updateAvailable
            // 
            this.lbl_updateAvailable.AutoSize = true;
            this.lbl_updateAvailable.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_updateAvailable.Location = new System.Drawing.Point(147, 8);
            this.lbl_updateAvailable.Name = "lbl_updateAvailable";
            this.lbl_updateAvailable.Size = new System.Drawing.Size(158, 25);
            this.lbl_updateAvailable.TabIndex = 29;
            this.lbl_updateAvailable.Text = "Update available!";
            // 
            // lbl_infoText
            // 
            this.lbl_infoText.AutoSize = true;
            this.lbl_infoText.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_infoText.Location = new System.Drawing.Point(145, 93);
            this.lbl_infoText.Name = "lbl_infoText";
            this.lbl_infoText.Size = new System.Drawing.Size(155, 36);
            this.lbl_infoText.TabIndex = 30;
            this.lbl_infoText.Text = "An updated version of the\r\nModding-Helper Application is\r\navailable and can be do" +
    "wnloaded.";
            this.lbl_infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_curVersion
            // 
            this.lbl_curVersion.AutoSize = true;
            this.lbl_curVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_curVersion.Location = new System.Drawing.Point(136, 45);
            this.lbl_curVersion.Name = "lbl_curVersion";
            this.lbl_curVersion.Size = new System.Drawing.Size(108, 19);
            this.lbl_curVersion.TabIndex = 31;
            this.lbl_curVersion.Text = "Current Version:";
            // 
            // lbl_newVersion
            // 
            this.lbl_newVersion.AutoSize = true;
            this.lbl_newVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_newVersion.Location = new System.Drawing.Point(136, 64);
            this.lbl_newVersion.Name = "lbl_newVersion";
            this.lbl_newVersion.Size = new System.Drawing.Size(114, 19);
            this.lbl_newVersion.TabIndex = 32;
            this.lbl_newVersion.Text = "Updated Version:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.DisplayFocusCues = false;
            this.btn_cancel.DrawBorder = true;
            this.btn_cancel.DrawClickBorder = true;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.Location = new System.Drawing.Point(165, 283);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OwnerDrawText = null;
            this.btn_cancel.Size = new System.Drawing.Size(137, 25);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_download
            // 
            this.btn_download.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_download.DisplayFocusCues = false;
            this.btn_download.DrawBorder = true;
            this.btn_download.DrawClickBorder = true;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_download.Location = new System.Drawing.Point(18, 283);
            this.btn_download.Name = "btn_download";
            this.btn_download.OwnerDrawText = null;
            this.btn_download.Size = new System.Drawing.Size(137, 25);
            this.btn_download.TabIndex = 33;
            this.btn_download.TabStop = false;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // mainBoxLogo
            // 
            this.mainBoxLogo.BackgroundImage = global::Modding_Helper.Properties.Resources.icon_128x128;
            this.mainBoxLogo.Location = new System.Drawing.Point(8, 8);
            this.mainBoxLogo.Name = "mainBoxLogo";
            this.mainBoxLogo.Size = new System.Drawing.Size(128, 128);
            this.mainBoxLogo.TabIndex = 27;
            this.mainBoxLogo.TabStop = false;
            // 
            // mainBoxBottomCenter
            // 
            this.mainBoxBottomCenter.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom2;
            this.mainBoxBottomCenter.Location = new System.Drawing.Point(112, 271);
            this.mainBoxBottomCenter.Name = "mainBoxBottomCenter";
            this.mainBoxBottomCenter.Size = new System.Drawing.Size(96, 49);
            this.mainBoxBottomCenter.TabIndex = 26;
            this.mainBoxBottomCenter.TabStop = false;
            // 
            // mainBoxBottomRight
            // 
            this.mainBoxBottomRight.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom3;
            this.mainBoxBottomRight.Location = new System.Drawing.Point(208, 271);
            this.mainBoxBottomRight.Name = "mainBoxBottomRight";
            this.mainBoxBottomRight.Size = new System.Drawing.Size(112, 49);
            this.mainBoxBottomRight.TabIndex = 25;
            this.mainBoxBottomRight.TabStop = false;
            // 
            // mainBoxBottomLeft
            // 
            this.mainBoxBottomLeft.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom1;
            this.mainBoxBottomLeft.Location = new System.Drawing.Point(0, 271);
            this.mainBoxBottomLeft.Name = "mainBoxBottomLeft";
            this.mainBoxBottomLeft.Size = new System.Drawing.Size(112, 49);
            this.mainBoxBottomLeft.TabIndex = 24;
            this.mainBoxBottomLeft.TabStop = false;
            // 
            // mainBoxTopRight
            // 
            this.mainBoxTopRight.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop3;
            this.mainBoxTopRight.Location = new System.Drawing.Point(208, 0);
            this.mainBoxTopRight.Name = "mainBoxTopRight";
            this.mainBoxTopRight.Size = new System.Drawing.Size(112, 49);
            this.mainBoxTopRight.TabIndex = 23;
            this.mainBoxTopRight.TabStop = false;
            // 
            // mainBoxTopCenter
            // 
            this.mainBoxTopCenter.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop2;
            this.mainBoxTopCenter.Location = new System.Drawing.Point(112, 0);
            this.mainBoxTopCenter.Name = "mainBoxTopCenter";
            this.mainBoxTopCenter.Size = new System.Drawing.Size(96, 49);
            this.mainBoxTopCenter.TabIndex = 22;
            this.mainBoxTopCenter.TabStop = false;
            // 
            // mainBoxTopLeft
            // 
            this.mainBoxTopLeft.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop1;
            this.mainBoxTopLeft.Location = new System.Drawing.Point(0, 0);
            this.mainBoxTopLeft.Name = "mainBoxTopLeft";
            this.mainBoxTopLeft.Size = new System.Drawing.Size(112, 49);
            this.mainBoxTopLeft.TabIndex = 21;
            this.mainBoxTopLeft.TabStop = false;
            // 
            // mainBoxRight
            // 
            this.mainBoxRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxRight.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxRight;
            this.mainBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxRight.Location = new System.Drawing.Point(312, 49);
            this.mainBoxRight.Name = "mainBoxRight";
            this.mainBoxRight.Size = new System.Drawing.Size(8, 222);
            this.mainBoxRight.TabIndex = 20;
            this.mainBoxRight.TabStop = false;
            // 
            // mainBoxLeft
            // 
            this.mainBoxLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxLeft.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxLeft;
            this.mainBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxLeft.Location = new System.Drawing.Point(0, 49);
            this.mainBoxLeft.Name = "mainBoxLeft";
            this.mainBoxLeft.Size = new System.Drawing.Size(8, 222);
            this.mainBoxLeft.TabIndex = 19;
            this.mainBoxLeft.TabStop = false;
            // 
            // curVersion
            // 
            this.curVersion.AutoSize = true;
            this.curVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.curVersion.Location = new System.Drawing.Point(252, 45);
            this.curVersion.Name = "curVersion";
            this.curVersion.Size = new System.Drawing.Size(50, 19);
            this.curVersion.TabIndex = 35;
            this.curVersion.Text = "1.0.0.0";
            this.curVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newVersion
            // 
            this.newVersion.AutoSize = true;
            this.newVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newVersion.Location = new System.Drawing.Point(252, 64);
            this.newVersion.Name = "newVersion";
            this.newVersion.Size = new System.Drawing.Size(50, 19);
            this.newVersion.TabIndex = 36;
            this.newVersion.Text = "2.0.0.0";
            this.newVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.ControlBox = false;
            this.Controls.Add(this.newVersion);
            this.Controls.Add(this.curVersion);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lbl_newVersion);
            this.Controls.Add(this.lbl_curVersion);
            this.Controls.Add(this.lbl_infoText);
            this.Controls.Add(this.lbl_updateAvailable);
            this.Controls.Add(this.rtb_changelog);
            this.Controls.Add(this.mainBoxLogo);
            this.Controls.Add(this.mainBoxBottomCenter);
            this.Controls.Add(this.mainBoxBottomRight);
            this.Controls.Add(this.mainBoxBottomLeft);
            this.Controls.Add(this.mainBoxTopRight);
            this.Controls.Add(this.mainBoxTopCenter);
            this.Controls.Add(this.mainBoxTopLeft);
            this.Controls.Add(this.mainBoxRight);
            this.Controls.Add(this.mainBoxLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "frm_update";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomPictureBox mainBoxLeft;
        private CustomPictureBox mainBoxRight;
        private CustomPictureBox mainBoxTopLeft;
        private CustomPictureBox mainBoxTopCenter;
        private CustomPictureBox mainBoxTopRight;
        private CustomPictureBox mainBoxBottomLeft;
        private CustomPictureBox mainBoxBottomRight;
        private CustomPictureBox mainBoxBottomCenter;
        private CustomPictureBox mainBoxLogo;
        private System.Windows.Forms.Label lbl_updateAvailable;
        private System.Windows.Forms.Label lbl_infoText;
        private System.Windows.Forms.Label lbl_curVersion;
        private System.Windows.Forms.Label lbl_newVersion;
        private CustomButtonFlat btn_download;
        private CustomButtonFlat btn_cancel;
        public System.Windows.Forms.Label curVersion;
        public System.Windows.Forms.Label newVersion;
        public System.Windows.Forms.RichTextBox rtb_changelog;
    }
}