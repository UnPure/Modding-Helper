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
            this.txt_websiteName = new System.Windows.Forms.TextBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.labelURL = new System.Windows.Forms.Label();
            this.txt_websiteURL = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btn_cancel = new Modding_Helper.CustomButton();
            this.btn_save = new Modding_Helper.CustomButton();
            this.moveBox = new System.Windows.Forms.PictureBox();
            this.mainBoxRight = new System.Windows.Forms.PictureBox();
            this.mainBoxLeft = new System.Windows.Forms.PictureBox();
            this.mainBoxTop = new System.Windows.Forms.PictureBox();
            this.mainBoxBottom = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_websiteName
            // 
            this.txt_websiteName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_websiteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_websiteName.Location = new System.Drawing.Point(10, 24);
            this.txt_websiteName.Margin = new System.Windows.Forms.Padding(10);
            this.txt_websiteName.MaxLength = 20;
            this.txt_websiteName.Name = "txt_websiteName";
            this.txt_websiteName.Size = new System.Drawing.Size(284, 20);
            this.txt_websiteName.TabIndex = 0;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_main.Controls.Add(this.labelURL);
            this.pnl_main.Controls.Add(this.txt_websiteURL);
            this.pnl_main.Controls.Add(this.labelName);
            this.pnl_main.Controls.Add(this.btn_cancel);
            this.pnl_main.Controls.Add(this.btn_save);
            this.pnl_main.Controls.Add(this.txt_websiteName);
            this.pnl_main.Controls.Add(this.moveBox);
            this.pnl_main.Location = new System.Drawing.Point(8, 8);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(304, 128);
            this.pnl_main.TabIndex = 7;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.labelURL.Location = new System.Drawing.Point(7, 54);
            this.labelURL.Margin = new System.Windows.Forms.Padding(10);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(111, 14);
            this.labelURL.TabIndex = 5;
            this.labelURL.Text = "Enter Website URL:";
            // 
            // txt_websiteURL
            // 
            this.txt_websiteURL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_websiteURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_websiteURL.Location = new System.Drawing.Point(10, 71);
            this.txt_websiteURL.Margin = new System.Windows.Forms.Padding(10);
            this.txt_websiteURL.Name = "txt_websiteURL";
            this.txt_websiteURL.Size = new System.Drawing.Size(284, 20);
            this.txt_websiteURL.TabIndex = 1;
            this.txt_websiteURL.Text = "http://";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(7, 7);
            this.labelName.Margin = new System.Windows.Forms.Padding(10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 14);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Enter Website Name:";
            this.labelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelName_MouseDown);
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelName_MouseMove);
            this.labelName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelName_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg_small;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.DisplayFocusCues = false;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(157, 97);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OwnerDrawText = null;
            this.btn_cancel.Size = new System.Drawing.Size(137, 25);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg_small;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.DisplayFocusCues = false;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btn_save.Location = new System.Drawing.Point(10, 97);
            this.btn_save.Name = "btn_save";
            this.btn_save.OwnerDrawText = null;
            this.btn_save.Size = new System.Drawing.Size(137, 25);
            this.btn_save.TabIndex = 2;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseDown);
            this.btn_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseUp);
            // 
            // moveBox
            // 
            this.moveBox.Location = new System.Drawing.Point(0, 0);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(304, 128);
            this.moveBox.TabIndex = 3;
            this.moveBox.TabStop = false;
            this.moveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseDown);
            this.moveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseMove);
            this.moveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseUp);
            // 
            // mainBoxRight
            // 
            this.mainBoxRight.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxLeft;
            this.mainBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxRight.Location = new System.Drawing.Point(312, 49);
            this.mainBoxRight.Name = "mainBoxRight";
            this.mainBoxRight.Size = new System.Drawing.Size(8, 46);
            this.mainBoxRight.TabIndex = 8;
            this.mainBoxRight.TabStop = false;
            // 
            // mainBoxLeft
            // 
            this.mainBoxLeft.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxLeft;
            this.mainBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxLeft.Location = new System.Drawing.Point(0, 49);
            this.mainBoxLeft.Name = "mainBoxLeft";
            this.mainBoxLeft.Size = new System.Drawing.Size(8, 46);
            this.mainBoxLeft.TabIndex = 5;
            this.mainBoxLeft.TabStop = false;
            // 
            // mainBoxTop
            // 
            this.mainBoxTop.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop;
            this.mainBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBoxTop.Location = new System.Drawing.Point(0, 0);
            this.mainBoxTop.Name = "mainBoxTop";
            this.mainBoxTop.Size = new System.Drawing.Size(320, 49);
            this.mainBoxTop.TabIndex = 5;
            this.mainBoxTop.TabStop = false;
            this.mainBoxTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainBoxTop_MouseDown);
            this.mainBoxTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainBoxTop_MouseMove);
            this.mainBoxTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainBoxTop_MouseUp);
            // 
            // mainBoxBottom
            // 
            this.mainBoxBottom.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom;
            this.mainBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBoxBottom.Location = new System.Drawing.Point(0, 95);
            this.mainBoxBottom.Name = "mainBoxBottom";
            this.mainBoxBottom.Size = new System.Drawing.Size(320, 49);
            this.mainBoxBottom.TabIndex = 6;
            this.mainBoxBottom.TabStop = false;
            this.mainBoxBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseDown);
            this.mainBoxBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseMove);
            this.mainBoxBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseUp);
            // 
            // frm_website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.ControlBox = false;
            this.Controls.Add(this.mainBoxRight);
            this.Controls.Add(this.mainBoxLeft);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.mainBoxTop);
            this.Controls.Add(this.mainBoxBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 144);
            this.Name = "frm_website";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_websiteName";
            this.Load += new System.EventHandler(this.frm_website_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btn_save;
        private CustomButton btn_cancel;
        private System.Windows.Forms.PictureBox mainBoxTop;
        private System.Windows.Forms.PictureBox mainBoxBottom;
        private System.Windows.Forms.TextBox txt_websiteName;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox moveBox;
        private System.Windows.Forms.PictureBox mainBoxLeft;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox txt_websiteURL;
        private System.Windows.Forms.PictureBox mainBoxRight;
    }
}