namespace Modding_Helper
{
    partial class frm_website
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
            this.labelURL = new System.Windows.Forms.Label();
            this.txt_websiteURL = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btn_cancel = new Modding_Helper.CustomButton();
            this.btn_save = new Modding_Helper.CustomButton();
            this.txt_websiteName = new System.Windows.Forms.TextBox();
            this.mainBoxTop = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottom = new Modding_Helper.CustomPictureBox();
            this.mainBoxLeft = new Modding_Helper.CustomPictureBox();
            this.mainBoxRight = new Modding_Helper.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelURL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.labelURL.Location = new System.Drawing.Point(15, 62);
            this.labelURL.Margin = new System.Windows.Forms.Padding(10);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(111, 14);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "Enter Website URL:";
            // 
            // txt_websiteURL
            // 
            this.txt_websiteURL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_websiteURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_websiteURL.Location = new System.Drawing.Point(18, 79);
            this.txt_websiteURL.Margin = new System.Windows.Forms.Padding(10);
            this.txt_websiteURL.Name = "txt_websiteURL";
            this.txt_websiteURL.Size = new System.Drawing.Size(284, 20);
            this.txt_websiteURL.TabIndex = 2;
            this.txt_websiteURL.Text = "http://";
            this.txt_websiteURL.Enter += new System.EventHandler(this.txt_websiteURL_Enter);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(15, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 14);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter Website Name:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg_small;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.DisplayFocusCues = true;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(165, 105);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OwnerDrawText = null;
            this.btn_cancel.Size = new System.Drawing.Size(137, 25);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg_small;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.DisplayFocusCues = true;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_save.Location = new System.Drawing.Point(18, 105);
            this.btn_save.Name = "btn_save";
            this.btn_save.OwnerDrawText = null;
            this.btn_save.Size = new System.Drawing.Size(137, 25);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_websiteName
            // 
            this.txt_websiteName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_websiteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_websiteName.Location = new System.Drawing.Point(18, 32);
            this.txt_websiteName.Margin = new System.Windows.Forms.Padding(10);
            this.txt_websiteName.MaxLength = 20;
            this.txt_websiteName.Name = "txt_websiteName";
            this.txt_websiteName.Size = new System.Drawing.Size(284, 20);
            this.txt_websiteName.TabIndex = 1;
            // 
            // mainBoxTop
            // 
            this.mainBoxTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxTop.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop;
            this.mainBoxTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBoxTop.Location = new System.Drawing.Point(0, 0);
            this.mainBoxTop.Name = "mainBoxTop";
            this.mainBoxTop.Size = new System.Drawing.Size(320, 49);
            this.mainBoxTop.TabIndex = 17;
            this.mainBoxTop.TabStop = false;
            // 
            // mainBoxBottom
            // 
            this.mainBoxBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxBottom.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom;
            this.mainBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBoxBottom.Location = new System.Drawing.Point(0, 95);
            this.mainBoxBottom.Name = "mainBoxBottom";
            this.mainBoxBottom.Size = new System.Drawing.Size(320, 49);
            this.mainBoxBottom.TabIndex = 18;
            this.mainBoxBottom.TabStop = false;
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
            // frm_website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.ControlBox = false;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txt_websiteName);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.txt_websiteURL);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.mainBoxRight);
            this.Controls.Add(this.mainBoxLeft);
            this.Controls.Add(this.mainBoxBottom);
            this.Controls.Add(this.mainBoxTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 144);
            this.Name = "frm_website";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox txt_websiteURL;
        private System.Windows.Forms.Label labelName;
        private CustomButton btn_cancel;
        private CustomButton btn_save;
        private System.Windows.Forms.TextBox txt_websiteName;
        private CustomPictureBox mainBoxTop;
        private CustomPictureBox mainBoxBottom;
        private CustomPictureBox mainBoxLeft;
        private CustomPictureBox mainBoxRight;
    }
}