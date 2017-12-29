namespace LIBRARY
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.RemindLabel = new System.Windows.Forms.Label();
            this.BookNameText = new System.Windows.Forms.Label();
            this.ReturnDateText = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.BorrowDateText = new System.Windows.Forms.Label();
            this.BorrowDateLabel = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ReBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.BgImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RemindLabel
            // 
            this.RemindLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.RemindLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RemindLabel.Location = new System.Drawing.Point(211, 354);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(360, 93);
            this.RemindLabel.TabIndex = 56;
            this.RemindLabel.Text = "还书逾期1天扣1点信用\r\n距应还日期5日以内可以续借\r\n1次延长15天，1本书只能续借1次";
            this.RemindLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookNameText
            // 
            this.BookNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookNameText.Font = new System.Drawing.Font("微软雅黑", 33F);
            this.BookNameText.Location = new System.Drawing.Point(105, 20);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(596, 58);
            this.BookNameText.TabIndex = 55;
            this.BookNameText.Text = "I\'m B00K Name";
            this.BookNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnDateText
            // 
            this.ReturnDateText.AutoSize = true;
            this.ReturnDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnDateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnDateText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnDateText.Location = new System.Drawing.Point(528, 253);
            this.ReturnDateText.Name = "ReturnDateText";
            this.ReturnDateText.Size = new System.Drawing.Size(60, 27);
            this.ReturnDateText.TabIndex = 51;
            this.ReturnDateText.Text = "2017";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnDateLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnDateLabel.Location = new System.Drawing.Point(415, 253);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(112, 27);
            this.ReturnDateLabel.TabIndex = 50;
            this.ReturnDateLabel.Text = "应还日期：";
            // 
            // BorrowDateText
            // 
            this.BorrowDateText.AutoSize = true;
            this.BorrowDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateText.Location = new System.Drawing.Point(528, 220);
            this.BorrowDateText.Name = "BorrowDateText";
            this.BorrowDateText.Size = new System.Drawing.Size(60, 27);
            this.BorrowDateText.TabIndex = 49;
            this.BorrowDateText.Text = "2015";
            // 
            // BorrowDateLabel
            // 
            this.BorrowDateLabel.AutoSize = true;
            this.BorrowDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateLabel.Location = new System.Drawing.Point(415, 220);
            this.BorrowDateLabel.Name = "BorrowDateLabel";
            this.BorrowDateLabel.Size = new System.Drawing.Size(112, 27);
            this.BorrowDateLabel.TabIndex = 48;
            this.BorrowDateLabel.Text = "借阅日期：";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherText.Location = new System.Drawing.Point(528, 187);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(112, 27);
            this.PublisherText.TabIndex = 47;
            this.PublisherText.Text = "测试出版社";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDText.Location = new System.Drawing.Point(528, 154);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(108, 27);
            this.BookIDText.TabIndex = 46;
            this.BookIDText.Text = "12345678";
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorText.Location = new System.Drawing.Point(528, 121);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(92, 27);
            this.AuthorText.TabIndex = 45;
            this.AuthorText.Text = "测试作者";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDLabel.Location = new System.Drawing.Point(415, 154);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(112, 27);
            this.BookIDLabel.TabIndex = 44;
            this.BookIDLabel.Text = "书　　号：";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(415, 121);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(112, 27);
            this.authorLabel.TabIndex = 43;
            this.authorLabel.Text = "作　　者：";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(98, -43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(107, 25);
            this.TitleLabel.TabIndex = 40;
            this.TitleLabel.Text = "还书通知单";
            // 
            // ReBorrowButton
            // 
            this.ReBorrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReBorrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.BackgroundImage")));
            this.ReBorrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReBorrowButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_DownImage")));
            this.ReBorrowButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_HoverImage")));
            this.ReBorrowButton.DM_Mode = false;
            this.ReBorrowButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_NolImage")));
            this.ReBorrowButton.Location = new System.Drawing.Point(456, 471);
            this.ReBorrowButton.Name = "ReBorrowButton";
            this.ReBorrowButton.Size = new System.Drawing.Size(102, 102);
            this.ReBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReBorrowButton.TabIndex = 54;
            this.ReBorrowButton.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReturnButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_DownImage")));
            this.ReturnButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_HoverImage")));
            this.ReturnButton.DM_Mode = false;
            this.ReturnButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_NolImage")));
            this.ReturnButton.Location = new System.Drawing.Point(226, 471);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(102, 102);
            this.ReturnButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReturnButton.TabIndex = 53;
            this.ReturnButton.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(421, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 34);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.Location = new System.Drawing.Point(176, 95);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 42;
            this.BookPictureBox.TabStop = false;
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
            this.ShutDownButton.Location = new System.Drawing.Point(656, -47);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 41;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BgImage.Location = new System.Drawing.Point(115, 59);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(600, 615);
            this.BgImage.TabIndex = 39;
            this.BgImage.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 614);
            this.Controls.Add(this.RemindLabel);
            this.Controls.Add(this.BookNameText);
            this.Controls.Add(this.ReBorrowButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReturnDateText);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.BorrowDateText);
            this.Controls.Add(this.BorrowDateLabel);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookIDText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookPictureBox);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemindLabel;
        private System.Windows.Forms.Label BookNameText;
        private DMSkin.Controls.DM.DMButtonImage ReBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage ReturnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ReturnDateText;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label BorrowDateText;
        private System.Windows.Forms.Label BorrowDateLabel;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Button ShutDownButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox BgImage;
    }
}