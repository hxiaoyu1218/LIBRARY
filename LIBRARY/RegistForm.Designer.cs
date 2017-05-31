namespace LIBRARY
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            this.WhiteBg = new System.Windows.Forms.PictureBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UserBg = new System.Windows.Forms.PictureBox();
            this.UserCueText = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordCueText1 = new System.Windows.Forms.Label();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordBg1 = new System.Windows.Forms.PictureBox();
            this.PasswordCueText2 = new System.Windows.Forms.Label();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordBg2 = new System.Windows.Forms.PictureBox();
            this.StudentCheckBox = new DMSkin.Controls.DMCheckBox();
            this.TeacherCheckBox = new DMSkin.Controls.DMCheckBox();
            this.IDCueText = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDBg = new System.Windows.Forms.PictureBox();
            this.AcademicCueText = new System.Windows.Forms.Label();
            this.AcademicTextBox = new System.Windows.Forms.TextBox();
            this.AcademicBg = new System.Windows.Forms.PictureBox();
            this.ReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            this.RegistButton = new DMSkin.Controls.DM.DMButtonImage();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademicBg)).BeginInit();
            this.SuspendLayout();
            // 
            // WhiteBg
            // 
            this.WhiteBg.BackColor = System.Drawing.Color.White;
            this.WhiteBg.Location = new System.Drawing.Point(0, 37);
            this.WhiteBg.Name = "WhiteBg";
            this.WhiteBg.Size = new System.Drawing.Size(450, 563);
            this.WhiteBg.TabIndex = 1;
            this.WhiteBg.TabStop = false;
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutDownButton.BackgroundImage")));
            this.ShutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShutDownButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ShutDownButton.FlatAppearance.BorderSize = 0;
            this.ShutDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ShutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(65)))), ((int)(((byte)(39)))));
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.Location = new System.Drawing.Point(415, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 7;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 16F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(8, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(54, 22);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "注册";
            // 
            // UserBg
            // 
            this.UserBg.BackColor = System.Drawing.Color.White;
            this.UserBg.Image = ((System.Drawing.Image)(resources.GetObject("UserBg.Image")));
            this.UserBg.Location = new System.Drawing.Point(70, 142);
            this.UserBg.Name = "UserBg";
            this.UserBg.Size = new System.Drawing.Size(314, 42);
            this.UserBg.TabIndex = 9;
            this.UserBg.TabStop = false;
            // 
            // UserCueText
            // 
            this.UserCueText.AutoSize = true;
            this.UserCueText.BackColor = System.Drawing.Color.White;
            this.UserCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UserCueText.Location = new System.Drawing.Point(111, 154);
            this.UserCueText.Name = "UserCueText";
            this.UserCueText.Size = new System.Drawing.Size(55, 15);
            this.UserCueText.TabIndex = 22;
            this.UserCueText.Text = "用户名";
            this.UserCueText.Click += new System.EventHandler(this.UserCueText_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.White;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UserTextBox.Location = new System.Drawing.Point(116, 151);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(259, 22);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.Enter += new System.EventHandler(this.UserTextBox_Enter);
            this.UserTextBox.Leave += new System.EventHandler(this.UserTextBox_Leave);
            // 
            // PasswordCueText1
            // 
            this.PasswordCueText1.AutoSize = true;
            this.PasswordCueText1.BackColor = System.Drawing.Color.White;
            this.PasswordCueText1.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText1.Location = new System.Drawing.Point(111, 212);
            this.PasswordCueText1.Name = "PasswordCueText1";
            this.PasswordCueText1.Size = new System.Drawing.Size(71, 15);
            this.PasswordCueText1.TabIndex = 26;
            this.PasswordCueText1.Text = "登录密码";
            this.PasswordCueText1.Click += new System.EventHandler(this.PasswordCueText1_Click);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox1.Location = new System.Drawing.Point(116, 209);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox1.TabIndex = 3;
            this.PasswordTextBox1.Enter += new System.EventHandler(this.PasswordTextBox1_Enter);
            this.PasswordTextBox1.Leave += new System.EventHandler(this.PasswordTextBox1_Leave);
            // 
            // PasswordBg1
            // 
            this.PasswordBg1.BackColor = System.Drawing.Color.White;
            this.PasswordBg1.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBg1.Image")));
            this.PasswordBg1.Location = new System.Drawing.Point(70, 200);
            this.PasswordBg1.Name = "PasswordBg1";
            this.PasswordBg1.Size = new System.Drawing.Size(314, 42);
            this.PasswordBg1.TabIndex = 24;
            this.PasswordBg1.TabStop = false;
            // 
            // PasswordCueText2
            // 
            this.PasswordCueText2.AutoSize = true;
            this.PasswordCueText2.BackColor = System.Drawing.Color.White;
            this.PasswordCueText2.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText2.Location = new System.Drawing.Point(111, 270);
            this.PasswordCueText2.Name = "PasswordCueText2";
            this.PasswordCueText2.Size = new System.Drawing.Size(119, 15);
            this.PasswordCueText2.TabIndex = 29;
            this.PasswordCueText2.Text = "再输入一次密码";
            this.PasswordCueText2.Click += new System.EventHandler(this.PasswordCueText2_Click);
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox2.Location = new System.Drawing.Point(116, 267);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox2.TabIndex = 4;
            this.PasswordTextBox2.Enter += new System.EventHandler(this.PasswordTextBox2_Enter);
            this.PasswordTextBox2.Leave += new System.EventHandler(this.PasswordTextBox2_Leave);
            // 
            // PasswordBg2
            // 
            this.PasswordBg2.BackColor = System.Drawing.Color.White;
            this.PasswordBg2.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBg2.Image")));
            this.PasswordBg2.Location = new System.Drawing.Point(70, 258);
            this.PasswordBg2.Name = "PasswordBg2";
            this.PasswordBg2.Size = new System.Drawing.Size(314, 42);
            this.PasswordBg2.TabIndex = 27;
            this.PasswordBg2.TabStop = false;
            // 
            // StudentCheckBox
            // 
            this.StudentCheckBox.BackColor = System.Drawing.Color.White;
            this.StudentCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentCheckBox.Checked = false;
            this.StudentCheckBox.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StudentCheckBox.Location = new System.Drawing.Point(70, 390);
            this.StudentCheckBox.Name = "StudentCheckBox";
            this.StudentCheckBox.Size = new System.Drawing.Size(86, 19);
            this.StudentCheckBox.TabIndex = 6;
            this.StudentCheckBox.TabStop = true;
            this.StudentCheckBox.Text = "我是学生";
            this.StudentCheckBox.Click += new System.EventHandler(this.StudentCheckBox_Click);
            // 
            // TeacherCheckBox
            // 
            this.TeacherCheckBox.BackColor = System.Drawing.Color.White;
            this.TeacherCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeacherCheckBox.Checked = false;
            this.TeacherCheckBox.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TeacherCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TeacherCheckBox.Location = new System.Drawing.Point(298, 390);
            this.TeacherCheckBox.Name = "TeacherCheckBox";
            this.TeacherCheckBox.Size = new System.Drawing.Size(86, 19);
            this.TeacherCheckBox.TabIndex = 7;
            this.TeacherCheckBox.TabStop = true;
            this.TeacherCheckBox.Text = "我是教师";
            this.TeacherCheckBox.Click += new System.EventHandler(this.TeacherCheckBox_Click);
            // 
            // IDCueText
            // 
            this.IDCueText.AutoSize = true;
            this.IDCueText.BackColor = System.Drawing.Color.White;
            this.IDCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IDCueText.Location = new System.Drawing.Point(111, 96);
            this.IDCueText.Name = "IDCueText";
            this.IDCueText.Size = new System.Drawing.Size(39, 15);
            this.IDCueText.TabIndex = 33;
            this.IDCueText.Text = "学号";
            this.IDCueText.Click += new System.EventHandler(this.IDCueText_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.IDTextBox.Location = new System.Drawing.Point(116, 93);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(259, 22);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.Enter += new System.EventHandler(this.IDTextBox_Enter);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // IDBg
            // 
            this.IDBg.BackColor = System.Drawing.Color.White;
            this.IDBg.Image = ((System.Drawing.Image)(resources.GetObject("IDBg.Image")));
            this.IDBg.Location = new System.Drawing.Point(70, 84);
            this.IDBg.Name = "IDBg";
            this.IDBg.Size = new System.Drawing.Size(314, 42);
            this.IDBg.TabIndex = 32;
            this.IDBg.TabStop = false;
            // 
            // AcademicCueText
            // 
            this.AcademicCueText.AutoSize = true;
            this.AcademicCueText.BackColor = System.Drawing.Color.White;
            this.AcademicCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AcademicCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AcademicCueText.Location = new System.Drawing.Point(111, 328);
            this.AcademicCueText.Name = "AcademicCueText";
            this.AcademicCueText.Size = new System.Drawing.Size(39, 15);
            this.AcademicCueText.TabIndex = 36;
            this.AcademicCueText.Text = "学院";
            this.AcademicCueText.Click += new System.EventHandler(this.AcademicCueText_Click);
            // 
            // AcademicTextBox
            // 
            this.AcademicTextBox.BackColor = System.Drawing.Color.White;
            this.AcademicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AcademicTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AcademicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AcademicTextBox.Location = new System.Drawing.Point(116, 325);
            this.AcademicTextBox.Name = "AcademicTextBox";
            this.AcademicTextBox.Size = new System.Drawing.Size(259, 22);
            this.AcademicTextBox.TabIndex = 5;
            this.AcademicTextBox.Enter += new System.EventHandler(this.AcademicTextBox_Enter);
            this.AcademicTextBox.Leave += new System.EventHandler(this.AcademicTextBox_Leave);
            // 
            // AcademicBg
            // 
            this.AcademicBg.BackColor = System.Drawing.Color.White;
            this.AcademicBg.Image = ((System.Drawing.Image)(resources.GetObject("AcademicBg.Image")));
            this.AcademicBg.Location = new System.Drawing.Point(70, 316);
            this.AcademicBg.Name = "AcademicBg";
            this.AcademicBg.Size = new System.Drawing.Size(314, 42);
            this.AcademicBg.TabIndex = 35;
            this.AcademicBg.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReturnButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_DownImage")));
            this.ReturnButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_HoverImage")));
            this.ReturnButton.DM_Mode = false;
            this.ReturnButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_NolImage")));
            this.ReturnButton.Location = new System.Drawing.Point(83, 451);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(96, 96);
            this.ReturnButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReturnButton.TabIndex = 38;
            this.ReturnButton.TabStop = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.ReturnButton.MouseLeave += new System.EventHandler(this.ReturnButton_MouseLeave);
            this.ReturnButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReturnButton_MouseMove);
            // 
            // RegistButton
            // 
            this.RegistButton.BackColor = System.Drawing.Color.White;
            this.RegistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistButton.BackgroundImage")));
            this.RegistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegistButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("RegistButton.DM_DownImage")));
            this.RegistButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("RegistButton.DM_HoverImage")));
            this.RegistButton.DM_Mode = false;
            this.RegistButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("RegistButton.DM_NolImage")));
            this.RegistButton.Location = new System.Drawing.Point(273, 451);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(96, 96);
            this.RegistButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.RegistButton.TabIndex = 8;
            this.RegistButton.TabStop = false;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            this.RegistButton.MouseLeave += new System.EventHandler(this.RegistButton_MouseLeave);
            this.RegistButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistButton_MouseMove);
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.CancelButton = this.ShutDownButton;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.IDCueText);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.AcademicCueText);
            this.Controls.Add(this.AcademicTextBox);
            this.Controls.Add(this.AcademicBg);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDBg);
            this.Controls.Add(this.TeacherCheckBox);
            this.Controls.Add(this.StudentCheckBox);
            this.Controls.Add(this.PasswordCueText2);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.PasswordBg2);
            this.Controls.Add(this.PasswordCueText1);
            this.Controls.Add(this.PasswordTextBox1);
            this.Controls.Add(this.PasswordBg1);
            this.Controls.Add(this.UserCueText);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserBg);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.WhiteBg);
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Name = "RegistForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistForm";
            this.Load += new System.EventHandler(this.RegistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademicBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WhiteBg;
        private System.Windows.Forms.Button ShutDownButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox UserBg;
        private System.Windows.Forms.Label UserCueText;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PasswordCueText1;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.PictureBox PasswordBg1;
        private System.Windows.Forms.Label PasswordCueText2;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.PictureBox PasswordBg2;
        private DMSkin.Controls.DMCheckBox StudentCheckBox;
        private DMSkin.Controls.DMCheckBox TeacherCheckBox;
        private System.Windows.Forms.Label IDCueText;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.PictureBox IDBg;
        private System.Windows.Forms.Label AcademicCueText;
        private System.Windows.Forms.TextBox AcademicTextBox;
        private System.Windows.Forms.PictureBox AcademicBg;
        private DMSkin.Controls.DM.DMButtonImage ReturnButton;
        private DMSkin.Controls.DM.DMButtonImage RegistButton;
    }
}