namespace LIBRARY
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchAll = new System.Windows.Forms.Button();
            this.SearchPublisher = new System.Windows.Forms.Button();
            this.SearchAuthor = new System.Windows.Forms.Button();
            this.SearchISBN = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.AllBackground = new System.Windows.Forms.PictureBox();
            this.ISBNBackground = new System.Windows.Forms.PictureBox();
            this.NameBackground = new System.Windows.Forms.PictureBox();
            this.AuthorBackground = new System.Windows.Forms.PictureBox();
            this.PublisherBackgound = new System.Windows.Forms.PictureBox();
            this.UserInfoButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookReturnButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BigTitlePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigTitlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.Location = new System.Drawing.Point(127, 282);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(665, 47);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("黑体", 16F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(792, 282);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 47);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchAll
            // 
            this.SearchAll.BackColor = System.Drawing.Color.Transparent;
            this.SearchAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAll.Font = new System.Drawing.Font("黑体", 12F);
            this.SearchAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAll.Location = new System.Drawing.Point(327, 359);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(70, 30);
            this.SearchAll.TabIndex = 3;
            this.SearchAll.Text = "全部";
            this.SearchAll.UseVisualStyleBackColor = false;
            this.SearchAll.Click += new System.EventHandler(this.SearchAll_Click);
            this.SearchAll.MouseLeave += new System.EventHandler(this.SearchAll_MouseLeave);
            this.SearchAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchAll_MouseMove);
            // 
            // SearchPublisher
            // 
            this.SearchPublisher.BackColor = System.Drawing.Color.Transparent;
            this.SearchPublisher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchPublisher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchPublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPublisher.Font = new System.Drawing.Font("黑体", 12F);
            this.SearchPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchPublisher.Location = new System.Drawing.Point(603, 359);
            this.SearchPublisher.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPublisher.Name = "SearchPublisher";
            this.SearchPublisher.Size = new System.Drawing.Size(70, 30);
            this.SearchPublisher.TabIndex = 4;
            this.SearchPublisher.Text = "出版社";
            this.SearchPublisher.UseVisualStyleBackColor = false;
            this.SearchPublisher.Click += new System.EventHandler(this.SearchPublisher_Click);
            this.SearchPublisher.MouseLeave += new System.EventHandler(this.SearchPublisher_MouseLeave);
            this.SearchPublisher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchPublisher_MouseMove);
            // 
            // SearchAuthor
            // 
            this.SearchAuthor.BackColor = System.Drawing.Color.Transparent;
            this.SearchAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAuthor.Font = new System.Drawing.Font("黑体", 12F);
            this.SearchAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchAuthor.Location = new System.Drawing.Point(534, 359);
            this.SearchAuthor.Name = "SearchAuthor";
            this.SearchAuthor.Size = new System.Drawing.Size(70, 30);
            this.SearchAuthor.TabIndex = 5;
            this.SearchAuthor.Text = "作家";
            this.SearchAuthor.UseVisualStyleBackColor = false;
            this.SearchAuthor.Click += new System.EventHandler(this.SearchAuthor_Click);
            this.SearchAuthor.MouseLeave += new System.EventHandler(this.SearchAuthor_MouseLeave);
            this.SearchAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchAuthor_MouseMove);
            // 
            // SearchISBN
            // 
            this.SearchISBN.BackColor = System.Drawing.Color.Transparent;
            this.SearchISBN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchISBN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchISBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchISBN.Font = new System.Drawing.Font("黑体", 12F);
            this.SearchISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchISBN.Location = new System.Drawing.Point(396, 359);
            this.SearchISBN.Name = "SearchISBN";
            this.SearchISBN.Size = new System.Drawing.Size(70, 30);
            this.SearchISBN.TabIndex = 6;
            this.SearchISBN.Text = "编号";
            this.SearchISBN.UseVisualStyleBackColor = false;
            this.SearchISBN.Click += new System.EventHandler(this.SearchISBN_Click);
            this.SearchISBN.MouseLeave += new System.EventHandler(this.SearchISBN_MouseLeave);
            this.SearchISBN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchISBN_MouseMove);
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.Transparent;
            this.SearchName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchName.Font = new System.Drawing.Font("黑体", 12F);
            this.SearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.SearchName.Location = new System.Drawing.Point(465, 359);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(70, 30);
            this.SearchName.TabIndex = 7;
            this.SearchName.Text = "书名";
            this.SearchName.UseVisualStyleBackColor = false;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            this.SearchName.MouseLeave += new System.EventHandler(this.SearchName_MouseLeave);
            this.SearchName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchName_MouseMove);
            // 
            // AllBackground
            // 
            this.AllBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AllBackground.Location = new System.Drawing.Point(327, 355);
            this.AllBackground.Name = "AllBackground";
            this.AllBackground.Size = new System.Drawing.Size(70, 38);
            this.AllBackground.TabIndex = 8;
            this.AllBackground.TabStop = false;
            // 
            // ISBNBackground
            // 
            this.ISBNBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ISBNBackground.Location = new System.Drawing.Point(396, 355);
            this.ISBNBackground.Name = "ISBNBackground";
            this.ISBNBackground.Size = new System.Drawing.Size(70, 38);
            this.ISBNBackground.TabIndex = 9;
            this.ISBNBackground.TabStop = false;
            // 
            // NameBackground
            // 
            this.NameBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NameBackground.Location = new System.Drawing.Point(465, 355);
            this.NameBackground.Name = "NameBackground";
            this.NameBackground.Size = new System.Drawing.Size(70, 38);
            this.NameBackground.TabIndex = 10;
            this.NameBackground.TabStop = false;
            // 
            // AuthorBackground
            // 
            this.AuthorBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AuthorBackground.Location = new System.Drawing.Point(534, 355);
            this.AuthorBackground.Name = "AuthorBackground";
            this.AuthorBackground.Size = new System.Drawing.Size(70, 38);
            this.AuthorBackground.TabIndex = 11;
            this.AuthorBackground.TabStop = false;
            // 
            // PublisherBackgound
            // 
            this.PublisherBackgound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.PublisherBackgound.Location = new System.Drawing.Point(603, 355);
            this.PublisherBackgound.Name = "PublisherBackgound";
            this.PublisherBackgound.Size = new System.Drawing.Size(70, 38);
            this.PublisherBackgound.TabIndex = 12;
            this.PublisherBackgound.TabStop = false;
            // 
            // UserInfoButton
            // 
            this.UserInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserInfoButton.BackgroundImage")));
            this.UserInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserInfoButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("UserInfoButton.DM_DownImage")));
            this.UserInfoButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("UserInfoButton.DM_HoverImage")));
            this.UserInfoButton.DM_Mode = false;
            this.UserInfoButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("UserInfoButton.DM_NolImage")));
            this.UserInfoButton.Location = new System.Drawing.Point(192, 445);
            this.UserInfoButton.Name = "UserInfoButton";
            this.UserInfoButton.Size = new System.Drawing.Size(172, 172);
            this.UserInfoButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.UserInfoButton.TabIndex = 13;
            this.UserInfoButton.Click += new System.EventHandler(this.UserInfoButton_Click);
            this.UserInfoButton.MouseLeave += new System.EventHandler(this.UserInfoButton_MouseLeave);
            this.UserInfoButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserInfoButton_MouseMove);
            // 
            // BookReturnButton
            // 
            this.BookReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.BookReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookReturnButton.BackgroundImage")));
            this.BookReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookReturnButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookReturnButton.DM_DownImage")));
            this.BookReturnButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookReturnButton.DM_HoverImage")));
            this.BookReturnButton.DM_Mode = false;
            this.BookReturnButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookReturnButton.DM_NolImage")));
            this.BookReturnButton.Location = new System.Drawing.Point(639, 445);
            this.BookReturnButton.Name = "BookReturnButton";
            this.BookReturnButton.Size = new System.Drawing.Size(172, 172);
            this.BookReturnButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookReturnButton.TabIndex = 14;
            this.BookReturnButton.Click += new System.EventHandler(this.BookReturnButton_Click);
            this.BookReturnButton.MouseLeave += new System.EventHandler(this.BookReturnButton_MouseLeave);
            this.BookReturnButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookReturnButton_MouseMove);
            // 
            // BigTitlePictureBox
            // 
            this.BigTitlePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigTitlePictureBox.BackgroundImage")));
            this.BigTitlePictureBox.Location = new System.Drawing.Point(286, 75);
            this.BigTitlePictureBox.Name = "BigTitlePictureBox";
            this.BigTitlePictureBox.Size = new System.Drawing.Size(428, 148);
            this.BigTitlePictureBox.TabIndex = 15;
            this.BigTitlePictureBox.TabStop = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.ControlBox = false;
            this.Controls.Add(this.BigTitlePictureBox);
            this.Controls.Add(this.BookReturnButton);
            this.Controls.Add(this.UserInfoButton);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.SearchISBN);
            this.Controls.Add(this.SearchAuthor);
            this.Controls.Add(this.SearchPublisher);
            this.Controls.Add(this.SearchAll);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AllBackground);
            this.Controls.Add(this.ISBNBackground);
            this.Controls.Add(this.NameBackground);
            this.Controls.Add(this.AuthorBackground);
            this.Controls.Add(this.PublisherBackgound);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigTitlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SearchAll;
        private System.Windows.Forms.Button SearchPublisher;
        private System.Windows.Forms.Button SearchAuthor;
        private System.Windows.Forms.Button SearchISBN;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.PictureBox AllBackground;
        private System.Windows.Forms.PictureBox ISBNBackground;
        private System.Windows.Forms.PictureBox NameBackground;
        private System.Windows.Forms.PictureBox AuthorBackground;
        private System.Windows.Forms.PictureBox PublisherBackgound;
        private DMSkin.Controls.DM.DMButtonImage UserInfoButton;
        private DMSkin.Controls.DM.DMButtonImage BookReturnButton;
        private System.Windows.Forms.PictureBox BigTitlePictureBox;
    }
}