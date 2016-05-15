namespace Modding_Helper
{
    partial class frm_folder
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
            this.mainBoxTop = new Modding_Helper.CustomPictureBox();
            this.mainBoxBottom = new Modding_Helper.CustomPictureBox();
            this.btn_cancel = new Modding_Helper.CustomButton();
            this.labelName = new System.Windows.Forms.Label();
            this.txt_folderName = new System.Windows.Forms.TextBox();
            this.btn_save = new Modding_Helper.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBoxTop
            // 
            this.mainBoxTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxTop.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxTop;
            this.mainBoxTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainBoxTop.Location = new System.Drawing.Point(0, 0);
            this.mainBoxTop.Name = "mainBoxTop";
            this.mainBoxTop.Size = new System.Drawing.Size(320, 50);
            this.mainBoxTop.TabIndex = 0;
            this.mainBoxTop.TabStop = false;
            // 
            // mainBoxBottom
            // 
            this.mainBoxBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainBoxBottom.BackgroundImage = global::Modding_Helper.Properties.Resources.mainBoxBottom;
            this.mainBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBoxBottom.Location = new System.Drawing.Point(0, 47);
            this.mainBoxBottom.Name = "mainBoxBottom";
            this.mainBoxBottom.Size = new System.Drawing.Size(320, 50);
            this.mainBoxBottom.TabIndex = 5;
            this.mainBoxBottom.TabStop = false;
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
            this.btn_cancel.Location = new System.Drawing.Point(165, 58);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OwnerDrawText = "Cancel";
            this.btn_cancel.Size = new System.Drawing.Size(137, 25);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.labelName.Size = new System.Drawing.Size(109, 14);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter folder name:";
            // 
            // txt_folderName
            // 
            this.txt_folderName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_folderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_folderName.Location = new System.Drawing.Point(18, 32);
            this.txt_folderName.Margin = new System.Windows.Forms.Padding(10);
            this.txt_folderName.MaxLength = 20;
            this.txt_folderName.Name = "txt_folderName";
            this.txt_folderName.Size = new System.Drawing.Size(284, 20);
            this.txt_folderName.TabIndex = 1;
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
            this.btn_save.Location = new System.Drawing.Point(18, 58);
            this.btn_save.Name = "btn_save";
            this.btn_save.OwnerDrawText = "Save";
            this.btn_save.Size = new System.Drawing.Size(137, 25);
            this.btn_save.TabIndex = 2;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 97);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txt_folderName);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.mainBoxTop);
            this.Controls.Add(this.mainBoxBottom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 97);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 97);
            this.Name = "frm_folder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomPictureBox mainBoxTop;
        private CustomPictureBox mainBoxBottom;
        private CustomButton btn_cancel;
        private System.Windows.Forms.Label labelName;
        private CustomButton btn_save;
        public System.Windows.Forms.TextBox txt_folderName;
    }
}