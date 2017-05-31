namespace LIBRARY
{
    partial class AdminBookImageChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookImageChangeForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.NewImageBox = new System.Windows.Forms.PictureBox();
            this.OKButton = new DMSkin.Controls.DM.DMButtonImage();
            this.AddImageButton = new DMSkin.Controls.DM.DMButtonImage();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.OldImageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(7, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(88, 25);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "添加图书";
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
            this.ShutDownButton.Location = new System.Drawing.Point(465, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 8;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.White;
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(500, 465);
            this.BgImage.TabIndex = 0;
            this.BgImage.TabStop = false;
            // 
            // NewImageBox
            // 
            this.NewImageBox.BackColor = System.Drawing.Color.White;
            this.NewImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewImageBox.BackgroundImage")));
            this.NewImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewImageBox.Location = new System.Drawing.Point(288, 100);
            this.NewImageBox.Name = "NewImageBox";
            this.NewImageBox.Size = new System.Drawing.Size(171, 242);
            this.NewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewImageBox.TabIndex = 52;
            this.NewImageBox.TabStop = false;
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
            this.OKButton.Location = new System.Drawing.Point(126, 380);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 96);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 53;
            this.OKButton.TabStop = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // AddImageButton
            // 
            this.AddImageButton.BackColor = System.Drawing.Color.White;
            this.AddImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.BackgroundImage")));
            this.AddImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddImageButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_DownImage")));
            this.AddImageButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_HoverImage")));
            this.AddImageButton.DM_Mode = false;
            this.AddImageButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_NolImage")));
            this.AddImageButton.Location = new System.Drawing.Point(279, 380);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(96, 96);
            this.AddImageButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.AddImageButton.TabIndex = 54;
            this.AddImageButton.TabStop = false;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            this.AddImageButton.MouseLeave += new System.EventHandler(this.AddImageButton_MouseLeave);
            this.AddImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddImageButton_MouseMove);
            // 
            // OpenImage
            // 
            this.OpenImage.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            // 
            // OldImageBox
            // 
            this.OldImageBox.BackColor = System.Drawing.Color.White;
            this.OldImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OldImageBox.BackgroundImage")));
            this.OldImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OldImageBox.Location = new System.Drawing.Point(42, 100);
            this.OldImageBox.Name = "OldImageBox";
            this.OldImageBox.Size = new System.Drawing.Size(171, 242);
            this.OldImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OldImageBox.TabIndex = 55;
            this.OldImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "原封面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(284, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "新封面";
            // 
            // AdminBookImageChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldImageBox);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NewImageBox);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminBookImageChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ChangeBookImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.PictureBox NewImageBox;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
        private DMSkin.Controls.DM.DMButtonImage AddImageButton;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.PictureBox OldImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}