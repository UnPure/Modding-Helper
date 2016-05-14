namespace Modding_Helper
{
    partial class WebsiteButtons
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
            this.websiteImageList = new System.Windows.Forms.ImageList(this.components);
            this.removeButton = new Modding_Helper.CustomFolderButton();
            this.openWebsite = new Modding_Helper.CustomFolderButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // websiteImageList
            // 
            this.websiteImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.websiteImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.websiteImageList.TransparentColor = System.Drawing.Color.Transparent;
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
            this.toolTip1.SetToolTip(this.removeButton, "Delete");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            this.removeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.removeButton_Paint);
            this.removeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.removeButton_MouseDown);
            this.removeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.removeButton_MouseUp);
            // 
            // openWebsite
            // 
            this.openWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openWebsite.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.openWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openWebsite.DisplayFocusCues = false;
            this.openWebsite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openWebsite.FlatAppearance.BorderSize = 0;
            this.openWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openWebsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.openWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openWebsite.ImageList = this.websiteImageList;
            this.openWebsite.Location = new System.Drawing.Point(0, 0);
            this.openWebsite.Margin = new System.Windows.Forms.Padding(0);
            this.openWebsite.MinimumSize = new System.Drawing.Size(259, 25);
            this.openWebsite.Name = "openWebsite";
            this.openWebsite.OwnerDrawText = null;
            this.openWebsite.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.openWebsite.Size = new System.Drawing.Size(259, 25);
            this.openWebsite.TabIndex = 0;
            this.openWebsite.TabStop = false;
            this.toolTip1.SetToolTip(this.openWebsite, "Open Website");
            this.openWebsite.UseVisualStyleBackColor = true;
            this.openWebsite.Click += new System.EventHandler(this.openWebsite_Click);
            this.openWebsite.Paint += new System.Windows.Forms.PaintEventHandler(this.openWebsite_Paint);
            this.openWebsite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openWebsite_MouseDown);
            this.openWebsite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openWebsite_MouseUp);
            // 
            // WebsiteButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.openWebsite);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "WebsiteButtons";
            this.Size = new System.Drawing.Size(283, 25);
            this.Load += new System.EventHandler(this.WebsiteButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFolderButton openWebsite;
        private CustomFolderButton removeButton;
        private System.Windows.Forms.ImageList websiteImageList;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
