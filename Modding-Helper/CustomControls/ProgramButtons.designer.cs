namespace Modding_Helper
{
    partial class ProgramButtons
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
            this.programImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeButton = new Modding_Helper.CustomFolderButton();
            this.openProgram = new Modding_Helper.CustomFolderButton();
            this.SuspendLayout();
            // 
            // programImageList
            // 
            this.programImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.programImageList.ImageSize = new System.Drawing.Size(21, 21);
            this.programImageList.TransparentColor = System.Drawing.Color.Transparent;
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
            // openProgram
            // 
            this.openProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openProgram.BackgroundImage = global::Modding_Helper.Properties.Resources.btnbg;
            this.openProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openProgram.DisplayFocusCues = false;
            this.openProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openProgram.FlatAppearance.BorderSize = 0;
            this.openProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProgram.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.openProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openProgram.ImageList = this.programImageList;
            this.openProgram.Location = new System.Drawing.Point(0, 0);
            this.openProgram.Margin = new System.Windows.Forms.Padding(0);
            this.openProgram.MinimumSize = new System.Drawing.Size(259, 25);
            this.openProgram.Name = "openProgram";
            this.openProgram.OwnerDrawText = null;
            this.openProgram.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.openProgram.Size = new System.Drawing.Size(259, 25);
            this.openProgram.TabIndex = 0;
            this.openProgram.TabStop = false;
            this.toolTip.SetToolTip(this.openProgram, "Open Program");
            this.openProgram.UseVisualStyleBackColor = true;
            this.openProgram.Click += new System.EventHandler(this.openProgram_Click);
            this.openProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.openProgram_Paint);
            this.openProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openProgram_MouseDown);
            this.openProgram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openProgram_MouseUp);
            // 
            // ProgramButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.openProgram);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "ProgramButtons";
            this.Size = new System.Drawing.Size(283, 25);
            this.Load += new System.EventHandler(this.ProgramButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFolderButton openProgram;
        private CustomFolderButton removeButton;
        private System.Windows.Forms.ImageList programImageList;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
