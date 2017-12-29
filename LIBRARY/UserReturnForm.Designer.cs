namespace LIBRARY
{
    partial class UserReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReturnForm));
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BookNameText = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PublisherText = new System.Windows.Forms.Label();
            this.BorrowDateLabel = new System.Windows.Forms.Label();
            this.BorrowDateText = new System.Windows.Forms.Label();
            this.ReturnDateText = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.ReBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(600, 615);
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
            this.TitleLabel.Size = new System.Drawing.Size(107, 25);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "还书通知单";
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
            this.ShutDownButton.Location = new System.Drawing.Point(565, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 8;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(571, 602);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.6747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.3253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.ReBorrowButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.BorrowDateLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PublisherText, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BookIDText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BookIDLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AuthorText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.authorLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookNameText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BorrowDateText, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDateText, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDateLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RemindLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ReturnButton, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BookNameText
            // 
            this.BookNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel1.SetColumnSpan(this.BookNameText, 3);
            this.BookNameText.Font = new System.Drawing.Font("微软雅黑", 33F);
            this.BookNameText.Location = new System.Drawing.Point(3, 6);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(562, 58);
            this.BookNameText.TabIndex = 56;
            this.BookNameText.Text = "I\'m B00K Name";
            this.BookNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.Location = new System.Drawing.Point(57, 92);
            this.BookPictureBox.Name = "BookPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.BookPictureBox, 5);
            this.BookPictureBox.Size = new System.Drawing.Size(170, 231);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 57;
            this.BookPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(288, 144);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(112, 27);
            this.authorLabel.TabIndex = 58;
            this.authorLabel.Text = "作　　者：";
            // 
            // AuthorText
            // 
            this.AuthorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorText.Location = new System.Drawing.Point(418, 144);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(92, 27);
            this.AuthorText.TabIndex = 59;
            this.AuthorText.Text = "测试作者";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDLabel.Location = new System.Drawing.Point(288, 174);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(112, 27);
            this.BookIDLabel.TabIndex = 60;
            this.BookIDLabel.Text = "书　　号：";
            // 
            // BookIDText
            // 
            this.BookIDText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDText.Location = new System.Drawing.Point(418, 174);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(108, 27);
            this.BookIDText.TabIndex = 61;
            this.BookIDText.Text = "12345678";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(296, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 22);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // PublisherText
            // 
            this.PublisherText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherText.Location = new System.Drawing.Point(418, 204);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(112, 27);
            this.PublisherText.TabIndex = 63;
            this.PublisherText.Text = "测试出版社";
            // 
            // BorrowDateLabel
            // 
            this.BorrowDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BorrowDateLabel.AutoSize = true;
            this.BorrowDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateLabel.Location = new System.Drawing.Point(288, 236);
            this.BorrowDateLabel.Name = "BorrowDateLabel";
            this.BorrowDateLabel.Size = new System.Drawing.Size(112, 27);
            this.BorrowDateLabel.TabIndex = 64;
            this.BorrowDateLabel.Text = "借阅日期：";
            // 
            // BorrowDateText
            // 
            this.BorrowDateText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BorrowDateText.AutoSize = true;
            this.BorrowDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateText.Location = new System.Drawing.Point(418, 236);
            this.BorrowDateText.Name = "BorrowDateText";
            this.BorrowDateText.Size = new System.Drawing.Size(60, 27);
            this.BorrowDateText.TabIndex = 65;
            this.BorrowDateText.Text = "2015";
            // 
            // ReturnDateText
            // 
            this.ReturnDateText.AutoSize = true;
            this.ReturnDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnDateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnDateText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnDateText.Location = new System.Drawing.Point(418, 268);
            this.ReturnDateText.Name = "ReturnDateText";
            this.ReturnDateText.Size = new System.Drawing.Size(60, 27);
            this.ReturnDateText.TabIndex = 67;
            this.ReturnDateText.Text = "2017";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnDateLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnDateLabel.Location = new System.Drawing.Point(288, 268);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(112, 27);
            this.ReturnDateLabel.TabIndex = 66;
            this.ReturnDateLabel.Text = "应还日期：";
            // 
            // RemindLabel
            // 
            this.RemindLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemindLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel1.SetColumnSpan(this.RemindLabel, 3);
            this.RemindLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RemindLabel.Location = new System.Drawing.Point(104, 359);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(360, 93);
            this.RemindLabel.TabIndex = 68;
            this.RemindLabel.Text = "还书逾期1天扣1点信用\r\n距应还日期5日以内可以续借\r\n1次延长15天，1本书只能续借1次";
            this.RemindLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReBorrowButton
            // 
            this.ReBorrowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReBorrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReBorrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.BackgroundImage")));
            this.ReBorrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReBorrowButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_DownImage")));
            this.ReBorrowButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_HoverImage")));
            this.ReBorrowButton.DM_Mode = false;
            this.ReBorrowButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("ReBorrowButton.DM_NolImage")));
            this.ReBorrowButton.Location = new System.Drawing.Point(91, 475);
            this.ReBorrowButton.Name = "ReBorrowButton";
            this.ReBorrowButton.Size = new System.Drawing.Size(102, 102);
            this.ReBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReBorrowButton.TabIndex = 70;
            this.ReBorrowButton.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.ReturnButton, 2);
            this.ReturnButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_DownImage")));
            this.ReturnButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_HoverImage")));
            this.ReturnButton.DM_Mode = false;
            this.ReturnButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.DM_NolImage")));
            this.ReturnButton.Location = new System.Drawing.Point(375, 475);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(102, 102);
            this.ReturnButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReturnButton.TabIndex = 69;
            this.ReturnButton.TabStop = false;
            // 
            // UserReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserReturnForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BookNameText;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label BorrowDateLabel;
        private System.Windows.Forms.Label BorrowDateText;
        private System.Windows.Forms.Label ReturnDateText;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label RemindLabel;
        private DMSkin.Controls.DM.DMButtonImage ReBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage ReturnButton;
    }
}