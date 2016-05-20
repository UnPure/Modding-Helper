namespace Modding_Helper
{
    partial class frm_about
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_curVersion = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_creationDate = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_contactMail = new System.Windows.Forms.Label();
            this.btn_ok = new Modding_Helper.CustomButtonFlat();
            this.mainBoxLogo = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottomLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopCenter = new Modding_Helper.CustomPictureBox();
            this.mainBoxTopLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxRight = new Modding_Helper.CustomPictureBox();
            this.mainBoxLeft = new Modding_Helper.CustomPictureBox();
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12.7F);
            this.lbl_title.Location = new System.Drawing.Point(134, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(136, 23);
            this.lbl_title.TabIndex = 35;
            this.lbl_title.Text = "Modding-Helper";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(135, 36);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(90, 13);
            this.lbl_version.TabIndex = 36;
            this.lbl_version.Text = "Current Version:";
            // 
            // lbl_curVersion
            // 
            this.lbl_curVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curVersion.Location = new System.Drawing.Point(247, 36);
            this.lbl_curVersion.Name = "lbl_curVersion";
            this.lbl_curVersion.Size = new System.Drawing.Size(64, 13);
            this.lbl_curVersion.TabIndex = 37;
            this.lbl_curVersion.Text = "1.0.0.0";
            this.lbl_curVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(135, 53);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(81, 13);
            this.lbl_date.TabIndex = 38;
            this.lbl_date.Text = "Creation Date:";
            // 
            // lbl_creationDate
            // 
            this.lbl_creationDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creationDate.Location = new System.Drawing.Point(248, 53);
            this.lbl_creationDate.Name = "lbl_creationDate";
            this.lbl_creationDate.Size = new System.Drawing.Size(64, 13);
            this.lbl_creationDate.TabIndex = 39;
            this.lbl_creationDate.Text = "20.05.2016";
            this.lbl_creationDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(135, 70);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(50, 13);
            this.lbl_contact.TabIndex = 40;
            this.lbl_contact.Text = "Contact:";
            // 
            // lbl_contactMail
            // 
            this.lbl_contactMail.AutoSize = true;
            this.lbl_contactMail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactMail.Location = new System.Drawing.Point(181, 70);
            this.lbl_contactMail.Name = "lbl_contactMail";
            this.lbl_contactMail.Size = new System.Drawing.Size(131, 13);
            this.lbl_contactMail.TabIndex = 41;
            this.lbl_contactMail.Text = "mh@unpure-gaming.de";
            this.lbl_contactMail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.DisplayFocusCues = false;
            this.btn_ok.DrawBorder = true;
            this.btn_ok.DrawClickBorder = true;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ok.Location = new System.Drawing.Point(138, 106);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OwnerDrawText = null;
            this.btn_ok.Size = new System.Drawing.Size(168, 25);
            this.btn_ok.TabIndex = 34;
            this.btn_ok.TabStop = false;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
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
            this.mainBoxBottomCenter.Location = new System.Drawing.Point(112, 95);
            this.mainBoxBottomCenter.Name = "mainBoxBottomCenter";
            this.mainBoxBottomCenter.Size = new System.Drawing.Size(96, 49);
            this.mainBoxBottomCenter.TabIndex = 26;
            this.mainBoxBottomCenter.TabStop = false;
            // 
            // mainBoxBottomRight
            // 
            this.mainBoxBottomRight.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom3;
            this.mainBoxBottomRight.Location = new System.Drawing.Point(208, 95);
            this.mainBoxBottomRight.Name = "mainBoxBottomRight";
            this.mainBoxBottomRight.Size = new System.Drawing.Size(112, 49);
            this.mainBoxBottomRight.TabIndex = 25;
            this.mainBoxBottomRight.TabStop = false;
            // 
            // mainBoxBottomLeft
            // 
            this.mainBoxBottomLeft.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom1;
            this.mainBoxBottomLeft.Location = new System.Drawing.Point(0, 95);
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
            this.mainBoxRight.Size = new System.Drawing.Size(8, 46);
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
            this.mainBoxLeft.Size = new System.Drawing.Size(8, 46);
            this.mainBoxLeft.TabIndex = 19;
            this.mainBoxLeft.TabStop = false;
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_contactMail);
            this.Controls.Add(this.lbl_creationDate);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_curVersion);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_ok);
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
            this.MaximumSize = new System.Drawing.Size(320, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 144);
            this.Name = "frm_about";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_about_Load);
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
        private CustomButtonFlat btn_ok;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_curVersion;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_creationDate;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_contactMail;
    }
}