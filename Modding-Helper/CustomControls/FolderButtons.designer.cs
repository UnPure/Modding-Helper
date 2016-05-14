namespace Modding_Helper
{
    partial class FolderButtons
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeButton = new Modding_Helper.CustomFolderButton();
            this.openFolder = new Modding_Helper.CustomFolderButton();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackgroundImage = global::Modding_Helper.Properties.Resources.delete;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeButton.DisplayFocusCues = false;
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.removeButton.Location = new System.Drawing.Point(259, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.removeButton.MaximumSize = new System.Drawing.Size(24, 25);
            this.removeButton.MinimumSize = new System.Drawing.Size(24, 25);
            this.removeButton.Name = "removeButton";
            this.removeButton.OwnerDrawText = null;
            this.removeButton.Size = new System.Drawing.Size(24, 25);
            this.removeButton.TabIndex = 1;
            this.removeButton.TabStop = false;
            this.toolTip.SetToolTip(this.removeButton, "Delete");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            this.removeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.removeButton_Paint);
            this.removeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.removeButton_MouseDown);
            this.removeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.removeButton_MouseUp);
            // 
            // openFolder
            // 
            this.openFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFolder.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.openFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFolder.DisplayFocusCues = false;
            this.openFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openFolder.FlatAppearance.BorderSize = 0;
            this.openFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.openFolder.Location = new System.Drawing.Point(0, 0);
            this.openFolder.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.openFolder.MinimumSize = new System.Drawing.Size(259, 25);
            this.openFolder.Name = "openFolder";
            this.openFolder.OwnerDrawText = null;
            this.openFolder.Size = new System.Drawing.Size(259, 25);
            this.openFolder.TabIndex = 0;
            this.openFolder.TabStop = false;
            this.toolTip.SetToolTip(this.openFolder, "Open Folder");
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            this.openFolder.Paint += new System.Windows.Forms.PaintEventHandler(this.openFolder_Paint);
            this.openFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openFolder_MouseDown);
            this.openFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openFolder_MouseUp);
            // 
            // FolderButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.openFolder);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "FolderButtons";
            this.Size = new System.Drawing.Size(283, 25);
            this.Load += new System.EventHandler(this.FolderButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFolderButton openFolder;
        private CustomFolderButton removeButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
