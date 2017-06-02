namespace LIBRARY
{
    partial class AdminBookManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookManageForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchWorker = new System.ComponentModel.BackgroundWorker();
            this.DividerLine = new System.Windows.Forms.PictureBox();
            this.PublisherBackgound = new System.Windows.Forms.PictureBox();
            this.AuthorBackground = new System.Windows.Forms.PictureBox();
            this.NameBackground = new System.Windows.Forms.PictureBox();
            this.ISBNBackground = new System.Windows.Forms.PictureBox();
            this.AllBackground = new System.Windows.Forms.PictureBox();
            this.SearchAll = new System.Windows.Forms.Button();
            this.SearchPublisher = new System.Windows.Forms.Button();
            this.SearchAuthor = new System.Windows.Forms.Button();
            this.SearchISBN = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.DividePicture = new System.Windows.Forms.PictureBox();
            this.JumpPTextBox = new System.Windows.Forms.TextBox();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.LastPButton = new System.Windows.Forms.PictureBox();
            this.NextPbutton = new System.Windows.Forms.PictureBox();
            this.Op = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.NoResultTextBox = new System.Windows.Forms.Label();
            this.LoadGIFBox = new System.Windows.Forms.PictureBox();
            this.AddBookButton = new DMSkin.Controls.DM.DMButtonImage();
            this.LabelButton = new System.Windows.Forms.Button();
            this.LabelBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.SearchBox.Location = new System.Drawing.Point(127, 20);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(665, 47);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("黑体", 16F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(792, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 47);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchWorker
            // 
            this.SearchWorker.WorkerSupportsCancellation = true;
            this.SearchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchWorker_DoWork);
            this.SearchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchWorker_RunWorkerCompleted);
            // 
            // DividerLine
            // 
            this.DividerLine.BackColor = System.Drawing.Color.Silver;
            this.DividerLine.Location = new System.Drawing.Point(93, 147);
            this.DividerLine.Name = "DividerLine";
            this.DividerLine.Size = new System.Drawing.Size(814, 1);
            this.DividerLine.TabIndex = 13;
            this.DividerLine.TabStop = false;
            // 
            // PublisherBackgound
            // 
            this.PublisherBackgound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.PublisherBackgound.Location = new System.Drawing.Point(569, 82);
            this.PublisherBackgound.Name = "PublisherBackgound";
            this.PublisherBackgound.Size = new System.Drawing.Size(70, 38);
            this.PublisherBackgound.TabIndex = 12;
            this.PublisherBackgound.TabStop = false;
            // 
            // AuthorBackground
            // 
            this.AuthorBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AuthorBackground.Location = new System.Drawing.Point(500, 82);
            this.AuthorBackground.Name = "AuthorBackground";
            this.AuthorBackground.Size = new System.Drawing.Size(70, 38);
            this.AuthorBackground.TabIndex = 11;
            this.AuthorBackground.TabStop = false;
            // 
            // NameBackground
            // 
            this.NameBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NameBackground.Location = new System.Drawing.Point(431, 82);
            this.NameBackground.Name = "NameBackground";
            this.NameBackground.Size = new System.Drawing.Size(70, 38);
            this.NameBackground.TabIndex = 10;
            this.NameBackground.TabStop = false;
            // 
            // ISBNBackground
            // 
            this.ISBNBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ISBNBackground.Location = new System.Drawing.Point(362, 82);
            this.ISBNBackground.Name = "ISBNBackground";
            this.ISBNBackground.Size = new System.Drawing.Size(70, 38);
            this.ISBNBackground.TabIndex = 9;
            this.ISBNBackground.TabStop = false;
            // 
            // AllBackground
            // 
            this.AllBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AllBackground.Location = new System.Drawing.Point(293, 82);
            this.AllBackground.Name = "AllBackground";
            this.AllBackground.Size = new System.Drawing.Size(70, 38);
            this.AllBackground.TabIndex = 8;
            this.AllBackground.TabStop = false;
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
            this.SearchAll.Location = new System.Drawing.Point(293, 86);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(70, 30);
            this.SearchAll.TabIndex = 3;
            this.SearchAll.TabStop = false;
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
            this.SearchPublisher.Location = new System.Drawing.Point(569, 86);
            this.SearchPublisher.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPublisher.Name = "SearchPublisher";
            this.SearchPublisher.Size = new System.Drawing.Size(70, 30);
            this.SearchPublisher.TabIndex = 4;
            this.SearchPublisher.TabStop = false;
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
            this.SearchAuthor.Location = new System.Drawing.Point(500, 86);
            this.SearchAuthor.Name = "SearchAuthor";
            this.SearchAuthor.Size = new System.Drawing.Size(70, 30);
            this.SearchAuthor.TabIndex = 5;
            this.SearchAuthor.TabStop = false;
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
            this.SearchISBN.Location = new System.Drawing.Point(362, 86);
            this.SearchISBN.Name = "SearchISBN";
            this.SearchISBN.Size = new System.Drawing.Size(70, 30);
            this.SearchISBN.TabIndex = 6;
            this.SearchISBN.TabStop = false;
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
            this.SearchName.Location = new System.Drawing.Point(431, 86);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(70, 30);
            this.SearchName.TabIndex = 7;
            this.SearchName.TabStop = false;
            this.SearchName.Text = "书名";
            this.SearchName.UseVisualStyleBackColor = false;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            this.SearchName.MouseLeave += new System.EventHandler(this.SearchName_MouseLeave);
            this.SearchName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchName_MouseMove);
            // 
            // DividePicture
            // 
            this.DividePicture.Image = ((System.Drawing.Image)(resources.GetObject("DividePicture.Image")));
            this.DividePicture.Location = new System.Drawing.Point(493, 645);
            this.DividePicture.Name = "DividePicture";
            this.DividePicture.Size = new System.Drawing.Size(18, 26);
            this.DividePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DividePicture.TabIndex = 30;
            this.DividePicture.TabStop = false;
            // 
            // JumpPTextBox
            // 
            this.JumpPTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.JumpPTextBox.Location = new System.Drawing.Point(411, 645);
            this.JumpPTextBox.Name = "JumpPTextBox";
            this.JumpPTextBox.Size = new System.Drawing.Size(68, 27);
            this.JumpPTextBox.TabIndex = 31;
            this.JumpPTextBox.TabStop = false;
            this.JumpPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JumpPTextBox.TextChanged += new System.EventHandler(this.JumpPTextBox_TextChanged);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.PageTextBox.Location = new System.Drawing.Point(522, 645);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.ReadOnly = true;
            this.PageTextBox.Size = new System.Drawing.Size(68, 27);
            this.PageTextBox.TabIndex = 32;
            this.PageTextBox.TabStop = false;
            this.PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastPButton
            // 
            this.LastPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastPButton.Image = ((System.Drawing.Image)(resources.GetObject("LastPButton.Image")));
            this.LastPButton.Location = new System.Drawing.Point(376, 640);
            this.LastPButton.Name = "LastPButton";
            this.LastPButton.Size = new System.Drawing.Size(20, 36);
            this.LastPButton.TabIndex = 33;
            this.LastPButton.TabStop = false;
            this.LastPButton.Click += new System.EventHandler(this.LastPButton_Click);
            // 
            // NextPbutton
            // 
            this.NextPbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPbutton.Image = ((System.Drawing.Image)(resources.GetObject("NextPbutton.Image")));
            this.NextPbutton.Location = new System.Drawing.Point(605, 640);
            this.NextPbutton.Name = "NextPbutton";
            this.NextPbutton.Size = new System.Drawing.Size(20, 36);
            this.NextPbutton.TabIndex = 35;
            this.NextPbutton.TabStop = false;
            this.NextPbutton.Click += new System.EventHandler(this.NextPButton_Click);
            // 
            // Op
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Op.DefaultCellStyle = dataGridViewCellStyle7;
            this.Op.HeaderText = "操作";
            this.Op.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            this.Op.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Op.VisitedLinkColor = System.Drawing.Color.Black;
            this.Op.Width = 114;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "出版社";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 184;
            // 
            // Author
            // 
            this.Author.HeaderText = "作者";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 150;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 225;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ID";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 140;
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.Author,
            this.Publisher,
            this.Op});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle10;
            this.ResultDataSheet.Location = new System.Drawing.Point(93, 161);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ResultDataSheet.RowTemplate.Height = 45;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(814, 469);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 1;
            this.ResultDataSheet.TabStop = false;
            this.ResultDataSheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataSheet_CellContentClick);
            // 
            // NoResultTextBox
            // 
            this.NoResultTextBox.AutoSize = true;
            this.NoResultTextBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.NoResultTextBox.Location = new System.Drawing.Point(345, 298);
            this.NoResultTextBox.Name = "NoResultTextBox";
            this.NoResultTextBox.Size = new System.Drawing.Size(311, 25);
            this.NoResultTextBox.TabIndex = 36;
            this.NoResultTextBox.Text = "什么都没有找到哦~添加一本图书？";
            // 
            // LoadGIFBox
            // 
            this.LoadGIFBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadGIFBox.Image")));
            this.LoadGIFBox.Location = new System.Drawing.Point(449, 326);
            this.LoadGIFBox.Name = "LoadGIFBox";
            this.LoadGIFBox.Size = new System.Drawing.Size(102, 96);
            this.LoadGIFBox.TabIndex = 15;
            this.LoadGIFBox.TabStop = false;
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBookButton.BackgroundImage")));
            this.AddBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBookButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("AddBookButton.DM_DownImage")));
            this.AddBookButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("AddBookButton.DM_HoverImage")));
            this.AddBookButton.DM_Mode = false;
            this.AddBookButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("AddBookButton.DM_NolImage")));
            this.AddBookButton.Location = new System.Drawing.Point(418, 365);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(172, 172);
            this.AddBookButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.AddBookButton.TabIndex = 37;
            this.AddBookButton.TabStop = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            this.AddBookButton.MouseLeave += new System.EventHandler(this.AddBookButton_MouseLeave);
            this.AddBookButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddBookButton_MouseMove);
            // 
            // LabelButton
            // 
            this.LabelButton.BackColor = System.Drawing.Color.Transparent;
            this.LabelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LabelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LabelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelButton.Font = new System.Drawing.Font("黑体", 12F);
            this.LabelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LabelButton.Location = new System.Drawing.Point(638, 86);
            this.LabelButton.Margin = new System.Windows.Forms.Padding(0);
            this.LabelButton.Name = "LabelButton";
            this.LabelButton.Size = new System.Drawing.Size(70, 30);
            this.LabelButton.TabIndex = 40;
            this.LabelButton.TabStop = false;
            this.LabelButton.Text = "标签";
            this.LabelButton.UseVisualStyleBackColor = false;
            this.LabelButton.Click += new System.EventHandler(this.LabelButton_Click);
            this.LabelButton.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            this.LabelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelButton_MouseMove);
            // 
            // LabelBackground
            // 
            this.LabelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LabelBackground.Location = new System.Drawing.Point(638, 82);
            this.LabelBackground.Name = "LabelBackground";
            this.LabelBackground.Size = new System.Drawing.Size(70, 38);
            this.LabelBackground.TabIndex = 41;
            this.LabelBackground.TabStop = false;
            // 
            // AdminBookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.LabelButton);
            this.Controls.Add(this.LabelBackground);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.NoResultTextBox);
            this.Controls.Add(this.NextPbutton);
            this.Controls.Add(this.LastPButton);
            this.Controls.Add(this.PageTextBox);
            this.Controls.Add(this.JumpPTextBox);
            this.Controls.Add(this.DividePicture);
            this.Controls.Add(this.LoadGIFBox);
            this.Controls.Add(this.DividerLine);
            this.Controls.Add(this.ResultDataSheet);
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
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBookManageForm";
            this.Text = "SearchResultForm";
            this.Load += new System.EventHandler(this.BookManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox DividerLine;
        private System.ComponentModel.BackgroundWorker SearchWorker;
        private System.Windows.Forms.PictureBox PublisherBackgound;
        private System.Windows.Forms.PictureBox AuthorBackground;
        private System.Windows.Forms.PictureBox NameBackground;
        private System.Windows.Forms.PictureBox ISBNBackground;
        private System.Windows.Forms.PictureBox AllBackground;
        private System.Windows.Forms.Button SearchAll;
        private System.Windows.Forms.Button SearchPublisher;
        private System.Windows.Forms.Button SearchAuthor;
        private System.Windows.Forms.Button SearchISBN;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.PictureBox DividePicture;
        private System.Windows.Forms.TextBox JumpPTextBox;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.PictureBox LastPButton;
        private System.Windows.Forms.PictureBox NextPbutton;
        private System.Windows.Forms.DataGridViewLinkColumn Op;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.Label NoResultTextBox;
        private System.Windows.Forms.PictureBox LoadGIFBox;
        private DMSkin.Controls.DM.DMButtonImage AddBookButton;
        private System.Windows.Forms.Button LabelButton;
        private System.Windows.Forms.PictureBox LabelBackground;
    }
}