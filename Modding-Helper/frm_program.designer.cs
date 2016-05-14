namespace Modding_Helper
{
    partial class frm_program
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
            this.txt_programName = new System.Windows.Forms.TextBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.btn_cancel = new Modding_Helper.CustomButton();
            this.btn_save = new Modding_Helper.CustomButton();
            this.moveBox = new System.Windows.Forms.PictureBox();
            this.mainBoxTop = new System.Windows.Forms.PictureBox();
            this.mainBoxBottom = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_programName
            // 
            this.txt_programName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_programName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.txt_programName.Location = new System.Drawing.Point(10, 24);
            this.txt_programName.Margin = new System.Windows.Forms.Padding(10);
            this.txt_programName.MaxLength = 20;
            this.txt_programName.Name = "txt_programName";
            this.txt_programName.Size = new System.Drawing.Size(284, 20);
            this.txt_programName.TabIndex = 0;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_main.Controls.Add(this.labelName);
            this.pnl_main.Controls.Add(this.btn_cancel);
            this.pnl_main.Controls.Add(this.btn_save);
            this.pnl_main.Controls.Add(this.txt_programName);
            this.pnl_main.Controls.Add(this.moveBox);
            this.pnl_main.Location = new System.Drawing.Point(8, 8);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(304, 81);
            this.pnl_main.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(7, 7);
            this.labelName.Margin = new System.Windows.Forms.Padding(10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 14);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Enter program name:";
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
            this.btn_cancel.Location = new System.Drawing.Point(157, 50);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OwnerDrawText = null;
            this.btn_cancel.Size = new System.Drawing.Size(137, 25);
            this.btn_cancel.TabIndex = 2;
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
            this.btn_save.Location = new System.Drawing.Point(10, 50);
            this.btn_save.Name = "btn_save";
            this.btn_save.OwnerDrawText = null;
            this.btn_save.Size = new System.Drawing.Size(137, 25);
            this.btn_save.TabIndex = 1;
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
            this.moveBox.Size = new System.Drawing.Size(304, 81);
            this.moveBox.TabIndex = 3;
            this.moveBox.TabStop = false;
            this.moveBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseDown);
            this.moveBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseMove);
            this.moveBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBox_MouseUp);
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
            this.mainBoxBottom.Location = new System.Drawing.Point(0, 48);
            this.mainBoxBottom.Name = "mainBoxBottom";
            this.mainBoxBottom.Size = new System.Drawing.Size(320, 49);
            this.mainBoxBottom.TabIndex = 6;
            this.mainBoxBottom.TabStop = false;
            this.mainBoxBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseDown);
            this.mainBoxBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseMove);
            this.mainBoxBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainBoxBottom_MouseUp);
            // 
            // frm_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 97);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.mainBoxTop);
            this.Controls.Add(this.mainBoxBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 97);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 97);
            this.Name = "frm_program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_programName";
            this.Load += new System.EventHandler(this.frm_program_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoxBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btn_save;
        private CustomButton btn_cancel;
        private System.Windows.Forms.PictureBox mainBoxTop;
        private System.Windows.Forms.PictureBox mainBoxBottom;
        private System.Windows.Forms.TextBox txt_programName;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox moveBox;
    }
}