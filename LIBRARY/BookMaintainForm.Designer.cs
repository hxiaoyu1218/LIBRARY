namespace LIBRARY
{
    partial class BookMaintainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMaintainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.CheckBoxPanel = new System.Windows.Forms.Panel();
            this.OKButton = new DMSkin.Controls.DM.DMButtonImage();
            this.DelButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BgImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(7, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(82, 24);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "图书维护";
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutDownButton.BackgroundImage")));
            this.ShutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShutDownButton.FlatAppearance.BorderSize = 0;
            this.ShutDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ShutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(65)))), ((int)(((byte)(39)))));
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.Location = new System.Drawing.Point(415, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 8;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // CheckBoxPanel
            // 
            this.CheckBoxPanel.AutoScroll = true;
            this.CheckBoxPanel.BackColor = System.Drawing.Color.White;
            this.CheckBoxPanel.Location = new System.Drawing.Point(20, 58);
            this.CheckBoxPanel.Name = "CheckBoxPanel";
            this.CheckBoxPanel.Size = new System.Drawing.Size(411, 312);
            this.CheckBoxPanel.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.White;
            this.OKButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKButton.BackgroundImage")));
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OKButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_DownImage")));
            this.OKButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_HoverImage")));
            this.OKButton.DM_Mode = false;
            this.OKButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_NolImage")));
            this.OKButton.Location = new System.Drawing.Point(105, 387);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 96);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 54;
            this.OKButton.TabStop = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.White;
            this.DelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelButton.BackgroundImage")));
            this.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("DelButton.DM_DownImage")));
            this.DelButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("DelButton.DM_HoverImage")));
            this.DelButton.DM_Mode = false;
            this.DelButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("DelButton.DM_NolImage")));
            this.DelButton.Location = new System.Drawing.Point(250, 387);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(96, 96);
            this.DelButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.DelButton.TabIndex = 55;
            this.DelButton.TabStop = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            this.DelButton.MouseLeave += new System.EventHandler(this.DelButton_MouseLeave);
            this.DelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DelButton_MouseMove);
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.White;
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(450, 465);
            this.BgImage.TabIndex = 0;
            this.BgImage.TabStop = false;
            // 
            // BookMaintainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CheckBoxPanel);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookMaintainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.BookMaintainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Panel CheckBoxPanel;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
        private DMSkin.Controls.DM.DMButtonImage DelButton;
        private System.Windows.Forms.PictureBox BgImage;
    }
}