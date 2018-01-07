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
            this.BookNameText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BorrowDateLabel = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BorrowDateText = new System.Windows.Forms.Label();
            this.ReturnDateText = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            this.authorLabel = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.BookImageRequest = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
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
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.BookNameText);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 615);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // BookNameText
            // 
            this.BookNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookNameText.AutoSize = true;
            this.BookNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookNameText.Font = new System.Drawing.Font("微软雅黑", 33F);
            this.BookNameText.Location = new System.Drawing.Point(25, 16);
            this.BookNameText.Margin = new System.Windows.Forms.Padding(25, 16, 3, 0);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(350, 57);
            this.BookNameText.TabIndex = 57;
            this.BookNameText.Text = "I\'m B00K Name";
            this.BookNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.91793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.08207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.ReBorrowButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BorrowDateLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PublisherText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BookIDText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookIDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BorrowDateText, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDateText, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReturnDateLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.RemindLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ReturnButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.authorLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuthorText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 91);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 18, 3, 3);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(555, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 642);
            this.tableLayoutPanel1.TabIndex = 58;
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
            this.ReBorrowButton.Location = new System.Drawing.Point(50, 508);
            this.ReBorrowButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 32);
            this.ReBorrowButton.Name = "ReBorrowButton";
            this.ReBorrowButton.Size = new System.Drawing.Size(102, 102);
            this.ReBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReBorrowButton.TabIndex = 70;
            this.ReBorrowButton.TabStop = false;
            this.ReBorrowButton.Click += new System.EventHandler(this.ReBorrowButton_Click);
            this.ReBorrowButton.MouseLeave += new System.EventHandler(this.ReBorrowButton_MouseLeave);
            this.ReBorrowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReBorrowButton_MouseMove);
            // 
            // BorrowDateLabel
            // 
            this.BorrowDateLabel.AutoSize = true;
            this.BorrowDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateLabel.Location = new System.Drawing.Point(211, 302);
            this.BorrowDateLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.BorrowDateLabel.Name = "BorrowDateLabel";
            this.BorrowDateLabel.Size = new System.Drawing.Size(112, 27);
            this.BorrowDateLabel.TabIndex = 64;
            this.BorrowDateLabel.Text = "借阅日期：";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherText.Location = new System.Drawing.Point(331, 105);
            this.PublisherText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(192, 189);
            this.PublisherText.TabIndex = 63;
            this.PublisherText.Text = "测试测试出测试出版社测试出版社版社出版社测试出版社测试出版社测试测试出测试出版社测试出版社版社出版社测试出版社测试出版社";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDText.Location = new System.Drawing.Point(331, 70);
            this.BookIDText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(108, 27);
            this.BookIDText.TabIndex = 61;
            this.BookIDText.Text = "12345678";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDLabel.Location = new System.Drawing.Point(211, 70);
            this.BookIDLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(112, 27);
            this.BookIDLabel.TabIndex = 60;
            this.BookIDLabel.Text = "书　　号：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(217, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(14, 8, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 22);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // BorrowDateText
            // 
            this.BorrowDateText.AutoSize = true;
            this.BorrowDateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BorrowDateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowDateText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowDateText.Location = new System.Drawing.Point(331, 302);
            this.BorrowDateText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
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
            this.ReturnDateText.Location = new System.Drawing.Point(331, 337);
            this.ReturnDateText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
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
            this.ReturnDateLabel.Location = new System.Drawing.Point(211, 337);
            this.ReturnDateLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
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
            this.RemindLabel.Location = new System.Drawing.Point(87, 396);
            this.RemindLabel.Margin = new System.Windows.Forms.Padding(3, 32, 3, 16);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(360, 93);
            this.RemindLabel.TabIndex = 68;
            this.RemindLabel.Text = "还书逾期1天扣1点信用\r\n距应还日期5日以内可以续借\r\n1次延长15天，1本书只能续借1次";
            this.RemindLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.ReturnButton.Location = new System.Drawing.Point(380, 508);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(128, 3, 3, 32);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(102, 102);
            this.ReturnButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.ReturnButton.TabIndex = 69;
            this.ReturnButton.TabStop = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            this.ReturnButton.MouseLeave += new System.EventHandler(this.ReturnButton_MouseLeave);
            this.ReturnButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReturnButton_MouseMove);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(211, 8);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(112, 27);
            this.authorLabel.TabIndex = 58;
            this.authorLabel.Text = "作　　者：";
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorText.Location = new System.Drawing.Point(331, 8);
            this.AuthorText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(192, 54);
            this.AuthorText.TabIndex = 59;
            this.AuthorText.Text = "测试作者测试作者测试作者测试作者";
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.Image = global::LIBRARY.Properties.Resources.BookNullImage;
            this.BookPictureBox.Location = new System.Drawing.Point(16, 66);
            this.BookPictureBox.Name = "BookPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.BookPictureBox, 5);
            this.BookPictureBox.Size = new System.Drawing.Size(170, 231);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 57;
            this.BookPictureBox.TabStop = false;
            // 
            // BookImageRequest
            // 
            this.BookImageRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookImageRequest_DoWork);
            this.BookImageRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookImageRequest_RunWorkerCompleted);
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
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label BookNameText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DMSkin.Controls.DM.DMButtonImage ReBorrowButton;
        private System.Windows.Forms.Label BorrowDateLabel;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BorrowDateText;
        private System.Windows.Forms.Label ReturnDateText;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Label RemindLabel;
        private DMSkin.Controls.DM.DMButtonImage ReturnButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label AuthorText;
        private System.ComponentModel.BackgroundWorker BookImageRequest;
    }
}