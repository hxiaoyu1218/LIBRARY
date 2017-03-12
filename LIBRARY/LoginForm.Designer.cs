namespace LIBRARY
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.WhiteBg = new System.Windows.Forms.PictureBox();
            this.TitlePicture = new System.Windows.Forms.PictureBox();
            this.UserBg = new System.Windows.Forms.PictureBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.PasswordBg = new System.Windows.Forms.PictureBox();
            this.RegisterButton = new DMSkin.Controls.DM.DMButtonImage();
            this.LoginButton = new DMSkin.Controls.DM.DMButtonImage();
            this.GuestLink = new System.Windows.Forms.LinkLabel();
            this.PasswordForgetLink = new System.Windows.Forms.LinkLabel();
            this.dmCheckBox1 = new DMSkin.Controls.DMCheckBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserCueText = new System.Windows.Forms.Label();
            this.PasswordCueText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg)).BeginInit();
            this.SuspendLayout();
            // 
            // WhiteBg
            // 
            this.WhiteBg.BackColor = System.Drawing.Color.White;
            this.WhiteBg.Location = new System.Drawing.Point(0, 197);
            this.WhiteBg.Name = "WhiteBg";
            this.WhiteBg.Size = new System.Drawing.Size(450, 403);
            this.WhiteBg.TabIndex = 0;
            this.WhiteBg.TabStop = false;
            // 
            // TitlePicture
            // 
            this.TitlePicture.Image = ((System.Drawing.Image)(resources.GetObject("TitlePicture.Image")));
            this.TitlePicture.Location = new System.Drawing.Point(68, 78);
            this.TitlePicture.Name = "TitlePicture";
            this.TitlePicture.Size = new System.Drawing.Size(325, 109);
            this.TitlePicture.TabIndex = 1;
            this.TitlePicture.TabStop = false;
            // 
            // UserBg
            // 
            this.UserBg.BackColor = System.Drawing.Color.White;
            this.UserBg.Image = ((System.Drawing.Image)(resources.GetObject("UserBg.Image")));
            this.UserBg.Location = new System.Drawing.Point(70, 254);
            this.UserBg.Name = "UserBg";
            this.UserBg.Size = new System.Drawing.Size(314, 42);
            this.UserBg.TabIndex = 2;
            this.UserBg.TabStop = false;
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
            this.ShutDownButton.Location = new System.Drawing.Point(410, 5);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 6;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // PasswordBg
            // 
            this.PasswordBg.BackColor = System.Drawing.Color.White;
            this.PasswordBg.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBg.Image")));
            this.PasswordBg.Location = new System.Drawing.Point(70, 333);
            this.PasswordBg.Name = "PasswordBg";
            this.PasswordBg.Size = new System.Drawing.Size(314, 42);
            this.PasswordBg.TabIndex = 7;
            this.PasswordBg.TabStop = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.White;
            this.RegisterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.BackgroundImage")));
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegisterButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.DM_DownImage")));
            this.RegisterButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.DM_HoverImage")));
            this.RegisterButton.DM_Mode = false;
            this.RegisterButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("RegisterButton.DM_NolImage")));
            this.RegisterButton.Location = new System.Drawing.Point(83, 451);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(96, 96);
            this.RegisterButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.MouseLeave += new System.EventHandler(this.RegisterButton_MouseLeave);
            this.RegisterButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterButton_MouseMove);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.DM_DownImage")));
            this.LoginButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.DM_HoverImage")));
            this.LoginButton.DM_Mode = true;
            this.LoginButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.DM_NolImage")));
            this.LoginButton.Location = new System.Drawing.Point(275, 451);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 96);
            this.LoginButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            this.LoginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseMove);
            // 
            // GuestLink
            // 
            this.GuestLink.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.GuestLink.AutoSize = true;
            this.GuestLink.BackColor = System.Drawing.Color.White;
            this.GuestLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GuestLink.Font = new System.Drawing.Font("黑体", 10F);
            this.GuestLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GuestLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GuestLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GuestLink.Location = new System.Drawing.Point(320, 303);
            this.GuestLink.Name = "GuestLink";
            this.GuestLink.Size = new System.Drawing.Size(63, 14);
            this.GuestLink.TabIndex = 16;
            this.GuestLink.TabStop = true;
            this.GuestLink.Text = "访客进入";
            // 
            // PasswordForgetLink
            // 
            this.PasswordForgetLink.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.PasswordForgetLink.AutoSize = true;
            this.PasswordForgetLink.BackColor = System.Drawing.Color.White;
            this.PasswordForgetLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordForgetLink.Font = new System.Drawing.Font("黑体", 10F);
            this.PasswordForgetLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordForgetLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PasswordForgetLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordForgetLink.Location = new System.Drawing.Point(297, 382);
            this.PasswordForgetLink.Name = "PasswordForgetLink";
            this.PasswordForgetLink.Size = new System.Drawing.Size(91, 14);
            this.PasswordForgetLink.TabIndex = 17;
            this.PasswordForgetLink.TabStop = true;
            this.PasswordForgetLink.Text = "忘记密码了？";
            // 
            // dmCheckBox1
            // 
            this.dmCheckBox1.BackColor = System.Drawing.Color.White;
            this.dmCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dmCheckBox1.Checked = false;
            this.dmCheckBox1.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dmCheckBox1.Location = new System.Drawing.Point(72, 382);
            this.dmCheckBox1.Name = "dmCheckBox1";
            this.dmCheckBox1.Size = new System.Drawing.Size(86, 19);
            this.dmCheckBox1.TabIndex = 18;
            this.dmCheckBox1.Text = "记住我";
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.White;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UserTextBox.Location = new System.Drawing.Point(112, 263);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(259, 22);
            this.UserTextBox.TabIndex = 19;
            this.UserTextBox.Enter += new System.EventHandler(this.UserTextBox_Enter);
            this.UserTextBox.Leave += new System.EventHandler(this.UserTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 345);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox.TabIndex = 20;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UserCueText
            // 
            this.UserCueText.AutoSize = true;
            this.UserCueText.BackColor = System.Drawing.Color.White;
            this.UserCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UserCueText.Location = new System.Drawing.Point(117, 266);
            this.UserCueText.Name = "UserCueText";
            this.UserCueText.Size = new System.Drawing.Size(55, 15);
            this.UserCueText.TabIndex = 21;
            this.UserCueText.Text = "用户名";
            // 
            // PasswordCueText
            // 
            this.PasswordCueText.AutoSize = true;
            this.PasswordCueText.BackColor = System.Drawing.Color.White;
            this.PasswordCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText.Location = new System.Drawing.Point(117, 345);
            this.PasswordCueText.Name = "PasswordCueText";
            this.PasswordCueText.Size = new System.Drawing.Size(39, 15);
            this.PasswordCueText.TabIndex = 22;
            this.PasswordCueText.Text = "密码";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.PasswordCueText);
            this.Controls.Add(this.UserCueText);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.dmCheckBox1);
            this.Controls.Add(this.PasswordForgetLink);
            this.Controls.Add(this.GuestLink);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordBg);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.UserBg);
            this.Controls.Add(this.TitlePicture);
            this.Controls.Add(this.WhiteBg);
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 5;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WhiteBg;
        private System.Windows.Forms.PictureBox TitlePicture;
        private System.Windows.Forms.PictureBox UserBg;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.PictureBox PasswordBg;
        private DMSkin.Controls.DM.DMButtonImage RegisterButton;
        private DMSkin.Controls.DM.DMButtonImage LoginButton;
        private System.Windows.Forms.LinkLabel GuestLink;
        private System.Windows.Forms.LinkLabel PasswordForgetLink;
        private DMSkin.Controls.DMCheckBox dmCheckBox1;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserCueText;
        private System.Windows.Forms.Label PasswordCueText;
    }
}