namespace LIBRARY
{
    partial class AdminSystemLogForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSystemLogForm));
			this.UserComingRateButton = new DMSkin.Controls.DM.DMButtonImage();
			this.BookLendingRateButton = new DMSkin.Controls.DM.DMButtonImage();
			this.SystemLogTextButton = new DMSkin.Controls.DM.DMButtonImage();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// UserComingRateButton
			// 
			this.UserComingRateButton.BackColor = System.Drawing.Color.Transparent;
			this.UserComingRateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserComingRateButton.BackgroundImage")));
			this.UserComingRateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.UserComingRateButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("UserComingRateButton.DM_DownImage")));
			this.UserComingRateButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("UserComingRateButton.DM_HoverImage")));
			this.UserComingRateButton.DM_Mode = false;
			this.UserComingRateButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("UserComingRateButton.DM_NolImage")));
			this.UserComingRateButton.Location = new System.Drawing.Point(69, 20);
			this.UserComingRateButton.Name = "UserComingRateButton";
			this.UserComingRateButton.Size = new System.Drawing.Size(75, 75);
			this.UserComingRateButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
			this.UserComingRateButton.TabIndex = 0;
			this.UserComingRateButton.TabStop = false;
			this.ToolTip.SetToolTip(this.UserComingRateButton, "用户到馆率");
			this.UserComingRateButton.MouseLeave += new System.EventHandler(this.UserComingRateButton_MouseLeave);
			this.UserComingRateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserComingRateButton_MouseMove);
			// 
			// BookLendingRateButton
			// 
			this.BookLendingRateButton.BackColor = System.Drawing.Color.Transparent;
			this.BookLendingRateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookLendingRateButton.BackgroundImage")));
			this.BookLendingRateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BookLendingRateButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookLendingRateButton.DM_DownImage")));
			this.BookLendingRateButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookLendingRateButton.DM_HoverImage")));
			this.BookLendingRateButton.DM_Mode = false;
			this.BookLendingRateButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookLendingRateButton.DM_NolImage")));
			this.BookLendingRateButton.Location = new System.Drawing.Point(187, 20);
			this.BookLendingRateButton.Name = "BookLendingRateButton";
			this.BookLendingRateButton.Size = new System.Drawing.Size(75, 75);
			this.BookLendingRateButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
			this.BookLendingRateButton.TabIndex = 0;
			this.BookLendingRateButton.TabStop = false;
			this.ToolTip.SetToolTip(this.BookLendingRateButton, "书籍借阅率");
			this.BookLendingRateButton.MouseLeave += new System.EventHandler(this.BookLendingRateButton_MouseLeave);
			this.BookLendingRateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookLendingRateButton_MouseMove);
			// 
			// SystemLogTextButton
			// 
			this.SystemLogTextButton.BackColor = System.Drawing.Color.Transparent;
			this.SystemLogTextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemLogTextButton.BackgroundImage")));
			this.SystemLogTextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.SystemLogTextButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("SystemLogTextButton.DM_DownImage")));
			this.SystemLogTextButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("SystemLogTextButton.DM_HoverImage")));
			this.SystemLogTextButton.DM_Mode = false;
			this.SystemLogTextButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("SystemLogTextButton.DM_NolImage")));
			this.SystemLogTextButton.Location = new System.Drawing.Point(304, 20);
			this.SystemLogTextButton.Name = "SystemLogTextButton";
			this.SystemLogTextButton.Size = new System.Drawing.Size(75, 75);
			this.SystemLogTextButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
			this.SystemLogTextButton.TabIndex = 2;
			this.SystemLogTextButton.TabStop = false;
			this.ToolTip.SetToolTip(this.SystemLogTextButton, "系统日志");
			this.SystemLogTextButton.MouseLeave += new System.EventHandler(this.SystemLogTextButton_MouseLeave);
			this.SystemLogTextButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SystemLogTextButton_MouseMove);
			// 
			// AdminSystemLogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.ClientSize = new System.Drawing.Size(1000, 705);
			this.Controls.Add(this.SystemLogTextButton);
			this.Controls.Add(this.BookLendingRateButton);
			this.Controls.Add(this.UserComingRateButton);
			this.DM_CanMove = false;
			this.DM_CanResize = false;
			this.DM_howBorder = false;
			this.DM_Mobile = DMSkin.MobileStyle.None;
			this.DM_Shadow = false;
			this.Name = "AdminSystemLogForm";
			this.Text = "SearchResultForm";
			this.Load += new System.EventHandler(this.AdminSystemLogForm_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private DMSkin.Controls.DM.DMButtonImage UserComingRateButton;
		private DMSkin.Controls.DM.DMButtonImage BookLendingRateButton;
		private DMSkin.Controls.DM.DMButtonImage SystemLogTextButton;
		private System.Windows.Forms.ToolTip ToolTip;
	}
}