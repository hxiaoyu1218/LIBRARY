namespace LIBRARY
{
    partial class SearchResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultForm));
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
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DividerLine = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchWorker = new System.ComponentModel.BackgroundWorker();
            this.LoadGIFBox = new System.Windows.Forms.PictureBox();
            this.NextPageButton = new System.Windows.Forms.LinkLabel();
            this.LastPageButton = new System.Windows.Forms.LinkLabel();
            this.FirstPageButton = new System.Windows.Forms.LinkLabel();
            this.TailPageButton = new System.Windows.Forms.LinkLabel();
            this.PageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.SearchBox.Location = new System.Drawing.Point(126, 20);
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
            this.SearchButton.Location = new System.Drawing.Point(791, 20);
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
            this.SearchAll.Location = new System.Drawing.Point(324, 86);
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
            this.SearchPublisher.Location = new System.Drawing.Point(600, 86);
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
            this.SearchAuthor.Location = new System.Drawing.Point(531, 86);
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
            this.SearchISBN.Location = new System.Drawing.Point(393, 86);
            this.SearchISBN.Name = "SearchISBN";
            this.SearchISBN.Size = new System.Drawing.Size(70, 30);
            this.SearchISBN.TabIndex = 6;
            this.SearchISBN.Text = "ISBN";
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
            this.SearchName.Location = new System.Drawing.Point(462, 86);
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
            this.AllBackground.Location = new System.Drawing.Point(324, 82);
            this.AllBackground.Name = "AllBackground";
            this.AllBackground.Size = new System.Drawing.Size(70, 38);
            this.AllBackground.TabIndex = 8;
            this.AllBackground.TabStop = false;
            // 
            // ISBNBackground
            // 
            this.ISBNBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ISBNBackground.Location = new System.Drawing.Point(393, 82);
            this.ISBNBackground.Name = "ISBNBackground";
            this.ISBNBackground.Size = new System.Drawing.Size(70, 38);
            this.ISBNBackground.TabIndex = 9;
            this.ISBNBackground.TabStop = false;
            // 
            // NameBackground
            // 
            this.NameBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NameBackground.Location = new System.Drawing.Point(462, 82);
            this.NameBackground.Name = "NameBackground";
            this.NameBackground.Size = new System.Drawing.Size(70, 38);
            this.NameBackground.TabIndex = 10;
            this.NameBackground.TabStop = false;
            // 
            // AuthorBackground
            // 
            this.AuthorBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AuthorBackground.Location = new System.Drawing.Point(531, 82);
            this.AuthorBackground.Name = "AuthorBackground";
            this.AuthorBackground.Size = new System.Drawing.Size(70, 38);
            this.AuthorBackground.TabIndex = 11;
            this.AuthorBackground.TabStop = false;
            // 
            // PublisherBackgound
            // 
            this.PublisherBackgound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.PublisherBackgound.Location = new System.Drawing.Point(600, 82);
            this.PublisherBackgound.Name = "PublisherBackgound";
            this.PublisherBackgound.Size = new System.Drawing.Size(70, 38);
            this.PublisherBackgound.TabIndex = 12;
            this.PublisherBackgound.TabStop = false;
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.Author,
            this.Publisher,
            this.Op});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle22;
            this.ResultDataSheet.Location = new System.Drawing.Point(101, 191);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.ResultDataSheet.RowTemplate.Height = 40;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(814, 469);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 1;
            this.ResultDataSheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataSheet_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ID";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 140;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 215;
            // 
            // Author
            // 
            this.Author.HeaderText = "作者";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 150;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "出版社";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 180;
            // 
            // Op
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.Op.DefaultCellStyle = dataGridViewCellStyle21;
            this.Op.HeaderText = "操作";
            this.Op.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            this.Op.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Op.VisitedLinkColor = System.Drawing.Color.Black;
            this.Op.Width = 110;
            // 
            // DividerLine
            // 
            this.DividerLine.BackColor = System.Drawing.Color.Silver;
            this.DividerLine.Location = new System.Drawing.Point(101, 176);
            this.DividerLine.Name = "DividerLine";
            this.DividerLine.Size = new System.Drawing.Size(814, 1);
            this.DividerLine.TabIndex = 13;
            this.DividerLine.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體 Light", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "检索结果";
            // 
            // SearchWorker
            // 
            this.SearchWorker.WorkerSupportsCancellation = true;
            this.SearchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchWorker_DoWork);
            this.SearchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchWorker_RunWorkerCompleted);
            // 
            // LoadGIFBox
            // 
            this.LoadGIFBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadGIFBox.Image")));
            this.LoadGIFBox.Location = new System.Drawing.Point(453, 362);
            this.LoadGIFBox.Name = "LoadGIFBox";
            this.LoadGIFBox.Size = new System.Drawing.Size(102, 96);
            this.LoadGIFBox.TabIndex = 15;
            this.LoadGIFBox.TabStop = false;
            // 
            // NextPageButton
            // 
            this.NextPageButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.NextPageButton.AutoSize = true;
            this.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.NextPageButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.NextPageButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.NextPageButton.Location = new System.Drawing.Point(833, 149);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(58, 21);
            this.NextPageButton.TabIndex = 25;
            this.NextPageButton.TabStop = true;
            this.NextPageButton.Text = "下一页";
            this.NextPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextPageButton_LinkClicked);
            // 
            // LastPageButton
            // 
            this.LastPageButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LastPageButton.AutoSize = true;
            this.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LastPageButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LastPageButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.LastPageButton.Location = new System.Drawing.Point(772, 149);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(58, 21);
            this.LastPageButton.TabIndex = 26;
            this.LastPageButton.TabStop = true;
            this.LastPageButton.Text = "上一页";
            this.LastPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LastPageButton_LinkClicked);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FirstPageButton.AutoSize = true;
            this.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FirstPageButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.FirstPageButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FirstPageButton.Location = new System.Drawing.Point(678, 149);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.Size = new System.Drawing.Size(42, 21);
            this.FirstPageButton.TabIndex = 27;
            this.FirstPageButton.TabStop = true;
            this.FirstPageButton.Text = "首页";
            this.FirstPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FirstPageButton_LinkClicked);
            // 
            // TailPageButton
            // 
            this.TailPageButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TailPageButton.AutoSize = true;
            this.TailPageButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TailPageButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.TailPageButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TailPageButton.Location = new System.Drawing.Point(726, 149);
            this.TailPageButton.Name = "TailPageButton";
            this.TailPageButton.Size = new System.Drawing.Size(42, 21);
            this.TailPageButton.TabIndex = 28;
            this.TailPageButton.TabStop = true;
            this.TailPageButton.Text = "尾页";
            this.TailPageButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TailPageButton_LinkClicked);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PageLabel.Location = new System.Drawing.Point(456, 147);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(83, 21);
            this.PageLabel.TabIndex = 29;
            this.PageLabel.Text = "当前第1页";
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.TailPageButton);
            this.Controls.Add(this.FirstPageButton);
            this.Controls.Add(this.LastPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.LoadGIFBox);
            this.Controls.Add(this.label1);
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
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            this.Load += new System.EventHandler(this.SearchResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISBNBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBackgound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button SearchISBN;
        private System.Windows.Forms.Button SearchAuthor;
        private System.Windows.Forms.Button SearchPublisher;
        private System.Windows.Forms.Button SearchAll;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox AllBackground;
        private System.Windows.Forms.PictureBox ISBNBackground;
        private System.Windows.Forms.PictureBox NameBackground;
        private System.Windows.Forms.PictureBox AuthorBackground;
        private System.Windows.Forms.PictureBox PublisherBackgound;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.PictureBox DividerLine;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker SearchWorker;
        private System.Windows.Forms.PictureBox LoadGIFBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewLinkColumn Op;
        private System.Windows.Forms.LinkLabel NextPageButton;
        private System.Windows.Forms.LinkLabel LastPageButton;
        private System.Windows.Forms.LinkLabel FirstPageButton;
        private System.Windows.Forms.LinkLabel TailPageButton;
        private System.Windows.Forms.Label PageLabel;
    }
}