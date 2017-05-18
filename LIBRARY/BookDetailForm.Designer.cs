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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.PubCountLabel = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.BookInfoTextbox = new System.Windows.Forms.TextBox();
            this.BookBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookOrderButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.PubCountText = new System.Windows.Forms.Label();
            this.PageNumText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
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
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImage = global::LIBRARY.Properties.Resources.BookNullImage;
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookPictureBox.Location = new System.Drawing.Point(70, 141);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 1;
            this.BookPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(268, 141);
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
            this.PublisherLabel.Location = new System.Drawing.Point(268, 203);
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
            this.BookIDLabel.Location = new System.Drawing.Point(268, 172);
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
            this.PubCountLabel.Location = new System.Drawing.Point(268, 234);
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
            this.PageNumLabel.Location = new System.Drawing.Point(268, 265);
            this.PageNumLabel.Name = "PageNumLabel";
            this.PageNumLabel.Size = new System.Drawing.Size(92, 27);
            this.PageNumLabel.TabIndex = 6;
            this.PageNumLabel.Text = "页　数：";
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookInfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInfoTextbox.CausesValidation = false;
            this.BookInfoTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfoTextbox.HideSelection = false;
            this.BookInfoTextbox.Location = new System.Drawing.Point(76, 423);
            this.BookInfoTextbox.Multiline = true;
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.ReadOnly = true;
            this.BookInfoTextbox.ShortcutsEnabled = false;
            this.BookInfoTextbox.Size = new System.Drawing.Size(397, 201);
            this.BookInfoTextbox.TabIndex = 3;
            this.BookInfoTextbox.TabStop = false;
            this.BookInfoTextbox.Text = "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤" +
    "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫汤……";
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
            this.BookOrderButton.Click += new System.EventHandler(this.BookOrderButton_Click);
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookState});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle23;
            this.ResultDataSheet.Location = new System.Drawing.Point(525, 141);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ResultDataSheet.RowTemplate.Height = 40;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(425, 204);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 17;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 285;
            // 
            // BookState
            // 
            this.BookState.HeaderText = "BookState";
            this.BookState.Name = "BookState";
            this.BookState.ReadOnly = true;
            this.BookState.Width = 120;
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.Transparent;
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorText.Location = new System.Drawing.Point(351, 141);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(92, 27);
            this.AuthorText.TabIndex = 18;
            this.AuthorText.Text = "测试作者";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.Transparent;
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDText.Location = new System.Drawing.Point(351, 172);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(108, 27);
            this.BookIDText.TabIndex = 19;
            this.BookIDText.Text = "12345678";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.Transparent;
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherText.Location = new System.Drawing.Point(351, 203);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(112, 27);
            this.PublisherText.TabIndex = 20;
            this.PublisherText.Text = "测试出版社";
            // 
            // PubCountText
            // 
            this.PubCountText.AutoSize = true;
            this.PubCountText.BackColor = System.Drawing.Color.Transparent;
            this.PubCountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PubCountText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PubCountText.Location = new System.Drawing.Point(351, 234);
            this.PubCountText.Name = "PubCountText";
            this.PubCountText.Size = new System.Drawing.Size(72, 27);
            this.PubCountText.TabIndex = 21;
            this.PubCountText.Text = "第一版";
            // 
            // PageNumText
            // 
            this.PageNumText.AutoSize = true;
            this.PageNumText.BackColor = System.Drawing.Color.Transparent;
            this.PageNumText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageNumText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageNumText.Location = new System.Drawing.Point(351, 265);
            this.PageNumText.Name = "PageNumText";
            this.PageNumText.Size = new System.Drawing.Size(36, 27);
            this.PageNumText.TabIndex = 22;
            this.PageNumText.Text = "25";
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.PageNumText);
            this.Controls.Add(this.PubCountText);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookIDText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.ResultDataSheet);
            this.Controls.Add(this.BookOrderButton);
            this.Controls.Add(this.BookBorrowButton);
            this.Controls.Add(this.BookInfoTextbox);
            this.Controls.Add(this.PageNumLabel);
            this.Controls.Add(this.PubCountLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookPictureBox);
            this.Controls.Add(this.BookNameLabel);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetailForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
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
        private DMSkin.Controls.DM.DMButtonImage BookBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage BookOrderButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label PubCountText;
        private System.Windows.Forms.Label PageNumText;
    }
}