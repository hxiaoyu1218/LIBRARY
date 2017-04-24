namespace LIBRARY
{
    partial class BookDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailForm));
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.PubCountLabel = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.BookInfoTextbox = new System.Windows.Forms.TextBox();
            this.BookListSheet = new System.Windows.Forms.DataGridView();
            this.BookBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookOrderButton = new DMSkin.Controls.DM.DMButtonImage();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookListSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNameLabel.Font = new System.Drawing.Font("微软雅黑", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameLabel.Location = new System.Drawing.Point(64, 35);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(245, 57);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "人民的名义";
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.BookPictureBox.Location = new System.Drawing.Point(70, 141);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.TabIndex = 1;
            this.BookPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(282, 141);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(92, 27);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "作　者：";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.PublisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherLabel.Location = new System.Drawing.Point(282, 203);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(92, 27);
            this.PublisherLabel.TabIndex = 3;
            this.PublisherLabel.Text = "出版社：";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDLabel.Location = new System.Drawing.Point(282, 172);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(92, 27);
            this.BookIDLabel.TabIndex = 4;
            this.BookIDLabel.Text = "书　号：";
            // 
            // PubCountLabel
            // 
            this.PubCountLabel.AutoSize = true;
            this.PubCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.PubCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PubCountLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PubCountLabel.Location = new System.Drawing.Point(282, 234);
            this.PubCountLabel.Name = "PubCountLabel";
            this.PubCountLabel.Size = new System.Drawing.Size(92, 27);
            this.PubCountLabel.TabIndex = 5;
            this.PubCountLabel.Text = "版　次：";
            // 
            // PageNumLabel
            // 
            this.PageNumLabel.AutoSize = true;
            this.PageNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageNumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageNumLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageNumLabel.Location = new System.Drawing.Point(282, 265);
            this.PageNumLabel.Name = "PageNumLabel";
            this.PageNumLabel.Size = new System.Drawing.Size(92, 27);
            this.PageNumLabel.TabIndex = 6;
            this.PageNumLabel.Text = "页　数：";
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookInfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInfoTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfoTextbox.Location = new System.Drawing.Point(76, 423);
            this.BookInfoTextbox.Multiline = true;
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.ReadOnly = true;
            this.BookInfoTextbox.Size = new System.Drawing.Size(397, 201);
            this.BookInfoTextbox.TabIndex = 3;
            this.BookInfoTextbox.TabStop = false;
            this.BookInfoTextbox.Text = "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤" +
    "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫汤……";
            // 
            // BookListSheet
            // 
            this.BookListSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookListSheet.Location = new System.Drawing.Point(521, 127);
            this.BookListSheet.Name = "BookListSheet";
            this.BookListSheet.RowTemplate.Height = 23;
            this.BookListSheet.Size = new System.Drawing.Size(403, 225);
            this.BookListSheet.TabIndex = 8;
            // 
            // BookBorrowButton
            // 
            this.BookBorrowButton.BackColor = System.Drawing.Color.Transparent;
            this.BookBorrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.BackgroundImage")));
            this.BookBorrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookBorrowButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_DownImage")));
            this.BookBorrowButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_HoverImage")));
            this.BookBorrowButton.DM_Mode = false;
            this.BookBorrowButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_NolImage")));
            this.BookBorrowButton.Location = new System.Drawing.Point(689, 454);
            this.BookBorrowButton.Name = "BookBorrowButton";
            this.BookBorrowButton.Size = new System.Drawing.Size(96, 96);
            this.BookBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookBorrowButton.TabIndex = 15;
            this.BookBorrowButton.Click += new System.EventHandler(this.BookBorrowButton_Click);
            // 
            // BookOrderButton
            // 
            this.BookOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.BookOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.BackgroundImage")));
            this.BookOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookOrderButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_DownImage")));
            this.BookOrderButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_HoverImage")));
            this.BookOrderButton.DM_Mode = false;
            this.BookOrderButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_NolImage")));
            this.BookOrderButton.Location = new System.Drawing.Point(689, 454);
            this.BookOrderButton.Name = "BookOrderButton";
            this.BookOrderButton.Size = new System.Drawing.Size(96, 96);
            this.BookOrderButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookOrderButton.TabIndex = 16;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.BookOrderButton);
            this.Controls.Add(this.BookBorrowButton);
            this.Controls.Add(this.BookListSheet);
            this.Controls.Add(this.BookInfoTextbox);
            this.Controls.Add(this.PageNumLabel);
            this.Controls.Add(this.PubCountLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookPictureBox);
            this.Controls.Add(this.BookNameLabel);
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "BookDetailForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookListSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label PubCountLabel;
        private System.Windows.Forms.Label PageNumLabel;
        private System.Windows.Forms.TextBox BookInfoTextbox;
        private System.Windows.Forms.DataGridView BookListSheet;
        private DMSkin.Controls.DM.DMButtonImage BookBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage BookOrderButton;
    }
}