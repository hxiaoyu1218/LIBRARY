namespace LIBRARY
{
    partial class PasswordChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeForm));
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.OPasswordCueText = new System.Windows.Forms.Label();
            this.OPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OPasswordBg = new System.Windows.Forms.PictureBox();
            this.NPasswordCueText1 = new System.Windows.Forms.Label();
            this.NPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.NPasswordBg1 = new System.Windows.Forms.PictureBox();
            this.NPasswordCueText2 = new System.Windows.Forms.Label();
            this.NPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.NPasswordBg2 = new System.Windows.Forms.PictureBox();
            this.OKButton = new DMSkin.Controls.DM.DMButtonImage();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPasswordBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPasswordBg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPasswordBg2)).BeginInit();
            this.SuspendLayout();
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.White;
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(410, 345);
            this.BgImage.TabIndex = 0;
            this.BgImage.TabStop = false;
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
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "修改密码";
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
            this.ShutDownButton.Location = new System.Drawing.Point(375, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 7;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // OPasswordCueText
            // 
            this.OPasswordCueText.AutoSize = true;
            this.OPasswordCueText.BackColor = System.Drawing.Color.White;
            this.OPasswordCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OPasswordCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.OPasswordCueText.Location = new System.Drawing.Point(89, 80);
            this.OPasswordCueText.Name = "OPasswordCueText";
            this.OPasswordCueText.Size = new System.Drawing.Size(55, 15);
            this.OPasswordCueText.TabIndex = 25;
            this.OPasswordCueText.Text = "原密码";
            this.OPasswordCueText.Click += new System.EventHandler(this.OPasswordCueText_Click);
            // 
            // OPasswordTextBox
            // 
            this.OPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OPasswordTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.OPasswordTextBox.Location = new System.Drawing.Point(94, 80);
            this.OPasswordTextBox.Name = "OPasswordTextBox";
            this.OPasswordTextBox.PasswordChar = '*';
            this.OPasswordTextBox.Size = new System.Drawing.Size(259, 22);
            this.OPasswordTextBox.TabIndex = 23;
            this.OPasswordTextBox.Enter += new System.EventHandler(this.OPasswordTextBox_Enter);
            this.OPasswordTextBox.Leave += new System.EventHandler(this.OPasswordTextBox_Leave);
            // 
            // OPasswordBg
            // 
            this.OPasswordBg.BackColor = System.Drawing.Color.White;
            this.OPasswordBg.Image = ((System.Drawing.Image)(resources.GetObject("OPasswordBg.Image")));
            this.OPasswordBg.Location = new System.Drawing.Point(48, 68);
            this.OPasswordBg.Name = "OPasswordBg";
            this.OPasswordBg.Size = new System.Drawing.Size(314, 42);
            this.OPasswordBg.TabIndex = 24;
            this.OPasswordBg.TabStop = false;
            // 
            // NPasswordCueText1
            // 
            this.NPasswordCueText1.AutoSize = true;
            this.NPasswordCueText1.BackColor = System.Drawing.Color.White;
            this.NPasswordCueText1.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NPasswordCueText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NPasswordCueText1.Location = new System.Drawing.Point(89, 148);
            this.NPasswordCueText1.Name = "NPasswordCueText1";
            this.NPasswordCueText1.Size = new System.Drawing.Size(55, 15);
            this.NPasswordCueText1.TabIndex = 29;
            this.NPasswordCueText1.Text = "新密码";
            this.NPasswordCueText1.Click += new System.EventHandler(this.NPasswordCueText1_Click);
            // 
            // NPasswordTextBox1
            // 
            this.NPasswordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPasswordTextBox1.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NPasswordTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NPasswordTextBox1.Location = new System.Drawing.Point(94, 147);
            this.NPasswordTextBox1.Name = "NPasswordTextBox1";
            this.NPasswordTextBox1.PasswordChar = '*';
            this.NPasswordTextBox1.Size = new System.Drawing.Size(259, 22);
            this.NPasswordTextBox1.TabIndex = 27;
            this.NPasswordTextBox1.Enter += new System.EventHandler(this.NPasswordTextBox1_Enter);
            this.NPasswordTextBox1.Leave += new System.EventHandler(this.NPasswordTextBox1_Leave);
            // 
            // NPasswordBg1
            // 
            this.NPasswordBg1.BackColor = System.Drawing.Color.White;
            this.NPasswordBg1.Image = ((System.Drawing.Image)(resources.GetObject("NPasswordBg1.Image")));
            this.NPasswordBg1.Location = new System.Drawing.Point(48, 136);
            this.NPasswordBg1.Name = "NPasswordBg1";
            this.NPasswordBg1.Size = new System.Drawing.Size(314, 42);
            this.NPasswordBg1.TabIndex = 28;
            this.NPasswordBg1.TabStop = false;
            // 
            // NPasswordCueText2
            // 
            this.NPasswordCueText2.AutoSize = true;
            this.NPasswordCueText2.BackColor = System.Drawing.Color.White;
            this.NPasswordCueText2.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NPasswordCueText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NPasswordCueText2.Location = new System.Drawing.Point(89, 216);
            this.NPasswordCueText2.Name = "NPasswordCueText2";
            this.NPasswordCueText2.Size = new System.Drawing.Size(119, 15);
            this.NPasswordCueText2.TabIndex = 32;
            this.NPasswordCueText2.Text = "再输入一次密码";
            this.NPasswordCueText2.Click += new System.EventHandler(this.NPasswordCueText2_Click);
            // 
            // NPasswordTextBox2
            // 
            this.NPasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPasswordTextBox2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NPasswordTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.NPasswordTextBox2.Location = new System.Drawing.Point(94, 214);
            this.NPasswordTextBox2.Name = "NPasswordTextBox2";
            this.NPasswordTextBox2.PasswordChar = '*';
            this.NPasswordTextBox2.Size = new System.Drawing.Size(259, 22);
            this.NPasswordTextBox2.TabIndex = 30;
            this.NPasswordTextBox2.Enter += new System.EventHandler(this.NPasswordTextBox2_Enter);
            this.NPasswordTextBox2.Leave += new System.EventHandler(this.NPasswordTextBox2_Leave);
            // 
            // NPasswordBg2
            // 
            this.NPasswordBg2.BackColor = System.Drawing.Color.White;
            this.NPasswordBg2.Image = ((System.Drawing.Image)(resources.GetObject("NPasswordBg2.Image")));
            this.NPasswordBg2.Location = new System.Drawing.Point(48, 204);
            this.NPasswordBg2.Name = "NPasswordBg2";
            this.NPasswordBg2.Size = new System.Drawing.Size(314, 42);
            this.NPasswordBg2.TabIndex = 31;
            this.NPasswordBg2.TabStop = false;
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
            this.OKButton.Location = new System.Drawing.Point(165, 285);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 80);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 33;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(410, 380);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.NPasswordCueText2);
            this.Controls.Add(this.NPasswordTextBox2);
            this.Controls.Add(this.NPasswordBg2);
            this.Controls.Add(this.NPasswordCueText1);
            this.Controls.Add(this.NPasswordTextBox1);
            this.Controls.Add(this.NPasswordBg1);
            this.Controls.Add(this.OPasswordCueText);
            this.Controls.Add(this.OPasswordTextBox);
            this.Controls.Add(this.OPasswordBg);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordChangeForm";
            this.Load += new System.EventHandler(this.PasswordChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OPasswordBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPasswordBg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPasswordBg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Label OPasswordCueText;
        private System.Windows.Forms.TextBox OPasswordTextBox;
        private System.Windows.Forms.PictureBox OPasswordBg;
        private System.Windows.Forms.Label NPasswordCueText1;
        private System.Windows.Forms.TextBox NPasswordTextBox1;
        private System.Windows.Forms.PictureBox NPasswordBg1;
        private System.Windows.Forms.Label NPasswordCueText2;
        private System.Windows.Forms.TextBox NPasswordTextBox2;
        private System.Windows.Forms.PictureBox NPasswordBg2;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
    }
}