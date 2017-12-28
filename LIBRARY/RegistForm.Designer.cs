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
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WhiteBg = new System.Windows.Forms.PictureBox();
            this.UserBg = new System.Windows.Forms.PictureBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.UserCueText = new System.Windows.Forms.Label();
            this.PasswordBg1 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordCueText1 = new System.Windows.Forms.Label();
            this.PasswordBg2 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordCueText2 = new System.Windows.Forms.Label();
            this.StudentCheckBox = new DMSkin.Controls.DMCheckBox();
            this.TeacherCheckBox = new DMSkin.Controls.DMCheckBox();
            this.IDBg = new System.Windows.Forms.PictureBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AcademicBg = new System.Windows.Forms.PictureBox();
            this.AcademicTextBox = new System.Windows.Forms.TextBox();
            this.AcademicCueText = new System.Windows.Forms.Label();
            this.ReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            this.RegistButton = new DMSkin.Controls.DM.DMButtonImage();
            this.IDCueText = new System.Windows.Forms.Label();
            this.IDAlertLabel = new System.Windows.Forms.Label();
            this.UserAlertLabel = new System.Windows.Forms.Label();
            this.PWD1AlertLabel = new System.Windows.Forms.Label();
            this.PWD2AlertLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademicBg)).BeginInit();
            this.SuspendLayout();
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
            // WhiteBg
            // 
            this.WhiteBg.BackColor = System.Drawing.Color.White;
            this.WhiteBg.Location = new System.Drawing.Point(0, 35);
            this.WhiteBg.Name = "WhiteBg";
            this.WhiteBg.Size = new System.Drawing.Size(450, 565);
            this.WhiteBg.TabIndex = 1;
            this.WhiteBg.TabStop = false;
            // 
            // UserBg
            // 
            this.UserBg.BackColor = System.Drawing.Color.White;
            this.UserBg.Image = ((System.Drawing.Image)(resources.GetObject("UserBg.Image")));
            this.UserBg.Location = new System.Drawing.Point(70, 147);
            this.UserBg.Name = "UserBg";
            this.UserBg.Size = new System.Drawing.Size(314, 42);
            this.UserBg.TabIndex = 9;
            this.UserBg.TabStop = false;
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.White;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UserTextBox.Location = new System.Drawing.Point(116, 156);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(259, 22);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.Enter += new System.EventHandler(this.UserTextBox_Enter);
            this.UserTextBox.Leave += new System.EventHandler(this.UserTextBox_Leave);
            // 
            // UserCueText
            // 
            this.UserCueText.AutoSize = true;
            this.UserCueText.BackColor = System.Drawing.Color.White;
            this.UserCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UserCueText.Location = new System.Drawing.Point(111, 159);
            this.UserCueText.Name = "UserCueText";
            this.UserCueText.Size = new System.Drawing.Size(55, 15);
            this.UserCueText.TabIndex = 22;
            this.UserCueText.Text = "用户名";
            this.UserCueText.Click += new System.EventHandler(this.UserCueText_Click);
            // 
            // PasswordBg1
            // 
            this.PasswordBg1.BackColor = System.Drawing.Color.White;
            this.PasswordBg1.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBg1.Image")));
            this.PasswordBg1.Location = new System.Drawing.Point(70, 214);
            this.PasswordBg1.Name = "PasswordBg1";
            this.PasswordBg1.Size = new System.Drawing.Size(314, 42);
            this.PasswordBg1.TabIndex = 24;
            this.PasswordBg1.TabStop = false;
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox1.Location = new System.Drawing.Point(116, 223);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox1.TabIndex = 3;
            this.PasswordTextBox1.Enter += new System.EventHandler(this.PasswordTextBox1_Enter);
            this.PasswordTextBox1.Leave += new System.EventHandler(this.PasswordTextBox1_Leave);
            // 
            // PasswordCueText1
            // 
            this.PasswordCueText1.AutoSize = true;
            this.PasswordCueText1.BackColor = System.Drawing.Color.White;
            this.PasswordCueText1.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText1.Location = new System.Drawing.Point(111, 226);
            this.PasswordCueText1.Name = "PasswordCueText1";
            this.PasswordCueText1.Size = new System.Drawing.Size(71, 15);
            this.PasswordCueText1.TabIndex = 26;
            this.PasswordCueText1.Text = "登录密码";
            this.PasswordCueText1.Click += new System.EventHandler(this.PasswordCueText1_Click);
            // 
            // PasswordBg2
            // 
            this.PasswordBg2.BackColor = System.Drawing.Color.White;
            this.PasswordBg2.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBg2.Image")));
            this.PasswordBg2.Location = new System.Drawing.Point(70, 281);
            this.PasswordBg2.Name = "PasswordBg2";
            this.PasswordBg2.Size = new System.Drawing.Size(314, 42);
            this.PasswordBg2.TabIndex = 27;
            this.PasswordBg2.TabStop = false;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox2.Location = new System.Drawing.Point(116, 290);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox2.TabIndex = 4;
            this.PasswordTextBox2.Enter += new System.EventHandler(this.PasswordTextBox2_Enter);
            this.PasswordTextBox2.Leave += new System.EventHandler(this.PasswordTextBox2_Leave);
            // 
            // PasswordCueText2
            // 
            this.PasswordCueText2.AutoSize = true;
            this.PasswordCueText2.BackColor = System.Drawing.Color.White;
            this.PasswordCueText2.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText2.Location = new System.Drawing.Point(111, 293);
            this.PasswordCueText2.Name = "PasswordCueText2";
            this.PasswordCueText2.Size = new System.Drawing.Size(119, 15);
            this.PasswordCueText2.TabIndex = 29;
            this.PasswordCueText2.Text = "再输入一次密码";
            this.PasswordCueText2.Click += new System.EventHandler(this.PasswordCueText2_Click);
            // 
            // StudentCheckBox
            // 
            this.StudentCheckBox.BackColor = System.Drawing.Color.White;
            this.StudentCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentCheckBox.Checked = false;
            this.StudentCheckBox.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.StudentCheckBox.Location = new System.Drawing.Point(70, 410);
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
            this.TeacherCheckBox.Location = new System.Drawing.Point(298, 410);
            this.TeacherCheckBox.Name = "TeacherCheckBox";
            this.TeacherCheckBox.Size = new System.Drawing.Size(86, 19);
            this.TeacherCheckBox.TabIndex = 7;
            this.TeacherCheckBox.TabStop = true;
            this.TeacherCheckBox.Text = "我是教师";
            this.TeacherCheckBox.Click += new System.EventHandler(this.TeacherCheckBox_Click);
            // 
            // IDBg
            // 
            this.IDBg.BackColor = System.Drawing.Color.White;
            this.IDBg.Image = ((System.Drawing.Image)(resources.GetObject("IDBg.Image")));
            this.IDBg.Location = new System.Drawing.Point(70, 80);
            this.IDBg.Name = "IDBg";
            this.IDBg.Size = new System.Drawing.Size(314, 42);
            this.IDBg.TabIndex = 32;
            this.IDBg.TabStop = false;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.IDTextBox.Location = new System.Drawing.Point(116, 89);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(259, 22);
            this.IDTextBox.TabIndex = 1;
            this.IDTextBox.Enter += new System.EventHandler(this.IDTextBox_Enter);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // AcademicBg
            // 
            this.AcademicBg.BackColor = System.Drawing.Color.White;
            this.AcademicBg.Image = ((System.Drawing.Image)(resources.GetObject("AcademicBg.Image")));
            this.AcademicBg.Location = new System.Drawing.Point(70, 348);
            this.AcademicBg.Name = "AcademicBg";
            this.AcademicBg.Size = new System.Drawing.Size(314, 42);
            this.AcademicBg.TabIndex = 35;
            this.AcademicBg.TabStop = false;
            // 
            // AcademicTextBox
            // 
            this.AcademicTextBox.BackColor = System.Drawing.Color.White;
            this.AcademicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AcademicTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AcademicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AcademicTextBox.Location = new System.Drawing.Point(116, 357);
            this.AcademicTextBox.Name = "AcademicTextBox";
            this.AcademicTextBox.Size = new System.Drawing.Size(259, 22);
            this.AcademicTextBox.TabIndex = 5;
            this.AcademicTextBox.Enter += new System.EventHandler(this.AcademicTextBox_Enter);
            this.AcademicTextBox.Leave += new System.EventHandler(this.AcademicTextBox_Leave);
            // 
            // AcademicCueText
            // 
            this.AcademicCueText.AutoSize = true;
            this.AcademicCueText.BackColor = System.Drawing.Color.White;
            this.AcademicCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AcademicCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AcademicCueText.Location = new System.Drawing.Point(111, 360);
            this.AcademicCueText.Name = "AcademicCueText";
            this.AcademicCueText.Size = new System.Drawing.Size(39, 15);
            this.AcademicCueText.TabIndex = 36;
            this.AcademicCueText.Text = "学院";
            this.AcademicCueText.Click += new System.EventHandler(this.AcademicCueText_Click);
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
            this.ReturnButton.Location = new System.Drawing.Point(83, 458);
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
            this.RegistButton.Location = new System.Drawing.Point(273, 458);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(96, 96);
            this.RegistButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.RegistButton.TabIndex = 8;
            this.RegistButton.TabStop = false;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            this.RegistButton.MouseLeave += new System.EventHandler(this.RegistButton_MouseLeave);
            this.RegistButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistButton_MouseMove);
            // 
            // IDCueText
            // 
            this.IDCueText.AutoSize = true;
            this.IDCueText.BackColor = System.Drawing.Color.White;
            this.IDCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IDCueText.Location = new System.Drawing.Point(111, 92);
            this.IDCueText.Name = "IDCueText";
            this.IDCueText.Size = new System.Drawing.Size(39, 15);
            this.IDCueText.TabIndex = 33;
            this.IDCueText.Text = "学号";
            this.IDCueText.Click += new System.EventHandler(this.IDCueText_Click);
            // 
            // IDAlertLabel
            // 
            this.IDAlertLabel.AutoSize = true;
            this.IDAlertLabel.BackColor = System.Drawing.Color.White;
            this.IDAlertLabel.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.IDAlertLabel.Location = new System.Drawing.Point(67, 59);
            this.IDAlertLabel.Name = "IDAlertLabel";
            this.IDAlertLabel.Size = new System.Drawing.Size(167, 15);
            this.IDAlertLabel.TabIndex = 39;
            this.IDAlertLabel.Text = "请输入正确的10位学号";
            this.IDAlertLabel.Visible = false;
            // 
            // UserAlertLabel
            // 
            this.UserAlertLabel.AutoSize = true;
            this.UserAlertLabel.BackColor = System.Drawing.Color.White;
            this.UserAlertLabel.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.UserAlertLabel.Location = new System.Drawing.Point(67, 126);
            this.UserAlertLabel.Name = "UserAlertLabel";
            this.UserAlertLabel.Size = new System.Drawing.Size(71, 15);
            this.UserAlertLabel.TabIndex = 40;
            this.UserAlertLabel.Text = "格式错误";
            this.UserAlertLabel.Visible = false;
            // 
            // PWD1AlertLabel
            // 
            this.PWD1AlertLabel.AutoSize = true;
            this.PWD1AlertLabel.BackColor = System.Drawing.Color.White;
            this.PWD1AlertLabel.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWD1AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.PWD1AlertLabel.Location = new System.Drawing.Point(67, 193);
            this.PWD1AlertLabel.Name = "PWD1AlertLabel";
            this.PWD1AlertLabel.Size = new System.Drawing.Size(295, 15);
            this.PWD1AlertLabel.TabIndex = 41;
            this.PWD1AlertLabel.Text = "格式错误，格式为6-12位英文和数字组合";
            this.PWD1AlertLabel.Visible = false;
            // 
            // PWD2AlertLabel
            // 
            this.PWD2AlertLabel.AutoSize = true;
            this.PWD2AlertLabel.BackColor = System.Drawing.Color.White;
            this.PWD2AlertLabel.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWD2AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.PWD2AlertLabel.Location = new System.Drawing.Point(67, 260);
            this.PWD2AlertLabel.Name = "PWD2AlertLabel";
            this.PWD2AlertLabel.Size = new System.Drawing.Size(151, 15);
            this.PWD2AlertLabel.TabIndex = 42;
            this.PWD2AlertLabel.Text = "两次输入密码不一致";
            this.PWD2AlertLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(67, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "格式错误";
            this.label4.Visible = false;
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.CancelButton = this.ShutDownButton;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PWD2AlertLabel);
            this.Controls.Add(this.PWD1AlertLabel);
            this.Controls.Add(this.UserAlertLabel);
            this.Controls.Add(this.IDAlertLabel);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
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
        private System.Windows.Forms.Button ShutDownButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox WhiteBg;
        private System.Windows.Forms.PictureBox UserBg;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label UserCueText;
        private System.Windows.Forms.PictureBox PasswordBg1;
        private System.Windows.Forms.TextBox PasswordTextBox1;
        private System.Windows.Forms.Label PasswordCueText1;
        private System.Windows.Forms.PictureBox PasswordBg2;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.Label PasswordCueText2;
        private DMSkin.Controls.DMCheckBox StudentCheckBox;
        private DMSkin.Controls.DMCheckBox TeacherCheckBox;
        private System.Windows.Forms.PictureBox IDBg;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.PictureBox AcademicBg;
        private System.Windows.Forms.TextBox AcademicTextBox;
        private System.Windows.Forms.Label AcademicCueText;
        private DMSkin.Controls.DM.DMButtonImage ReturnButton;
        private DMSkin.Controls.DM.DMButtonImage RegistButton;
        private System.Windows.Forms.Label IDCueText;
        private System.Windows.Forms.Label IDAlertLabel;
        private System.Windows.Forms.Label UserAlertLabel;
        private System.Windows.Forms.Label PWD1AlertLabel;
        private System.Windows.Forms.Label PWD2AlertLabel;
        private System.Windows.Forms.Label label4;
    }
}