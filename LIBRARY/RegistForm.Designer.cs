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
            this.TeacherCheckBox1 = new DMSkin.Controls.DMCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg2)).BeginInit();
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
            this.ShutDownButton.FlatAppearance.BorderSize = 0;
            this.ShutDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ShutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(65)))), ((int)(((byte)(39)))));
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.Location = new System.Drawing.Point(411, 2);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 7;
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
            this.UserCueText.Location = new System.Drawing.Point(118, 154);
            this.UserCueText.Name = "UserCueText";
            this.UserCueText.Size = new System.Drawing.Size(55, 15);
            this.UserCueText.TabIndex = 22;
            this.UserCueText.Text = "用户名";
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.White;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.UserTextBox.Location = new System.Drawing.Point(112, 151);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(259, 22);
            this.UserTextBox.TabIndex = 23;
            this.UserTextBox.Enter += new System.EventHandler(this.UserTextBox_Enter);
            this.UserTextBox.Leave += new System.EventHandler(this.UserTextBox_Leave);
            // 
            // PasswordCueText1
            // 
            this.PasswordCueText1.AutoSize = true;
            this.PasswordCueText1.BackColor = System.Drawing.Color.White;
            this.PasswordCueText1.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordCueText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PasswordCueText1.Location = new System.Drawing.Point(117, 212);
            this.PasswordCueText1.Name = "PasswordCueText1";
            this.PasswordCueText1.Size = new System.Drawing.Size(71, 15);
            this.PasswordCueText1.TabIndex = 26;
            this.PasswordCueText1.Text = "登陆密码";
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox1.Location = new System.Drawing.Point(112, 212);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox1.TabIndex = 25;
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
            this.PasswordCueText2.Location = new System.Drawing.Point(117, 270);
            this.PasswordCueText2.Name = "PasswordCueText2";
            this.PasswordCueText2.Size = new System.Drawing.Size(119, 15);
            this.PasswordCueText2.TabIndex = 29;
            this.PasswordCueText2.Text = "再输入一次密码";
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PasswordTextBox2.Location = new System.Drawing.Point(112, 270);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(259, 22);
            this.PasswordTextBox2.TabIndex = 28;
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
            this.StudentCheckBox.Location = new System.Drawing.Point(70, 446);
            this.StudentCheckBox.Name = "StudentCheckBox";
            this.StudentCheckBox.Size = new System.Drawing.Size(86, 19);
            this.StudentCheckBox.TabIndex = 30;
            this.StudentCheckBox.Text = "我是学生";
            // 
            // TeacherCheckBox1
            // 
            this.TeacherCheckBox1.BackColor = System.Drawing.Color.White;
            this.TeacherCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeacherCheckBox1.Checked = false;
            this.TeacherCheckBox1.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TeacherCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TeacherCheckBox1.Location = new System.Drawing.Point(298, 446);
            this.TeacherCheckBox1.Name = "TeacherCheckBox1";
            this.TeacherCheckBox1.Size = new System.Drawing.Size(86, 19);
            this.TeacherCheckBox1.TabIndex = 31;
            this.TeacherCheckBox1.Text = "我是教师";
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.TeacherCheckBox1);
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
            this.DM_ShadowWidth = 5;
            this.Name = "RegistForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistForm";
            this.Load += new System.EventHandler(this.RegistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WhiteBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBg2)).EndInit();
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
        private DMSkin.Controls.DMCheckBox TeacherCheckBox1;
    }
}