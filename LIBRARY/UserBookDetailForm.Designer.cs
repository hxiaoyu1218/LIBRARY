namespace LIBRARY
{
    partial class UserBookDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.BookBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookOrderButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoUseButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookInfoTextbox = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.Label3Text = new System.Windows.Forms.Label();
            this.Label1Text = new System.Windows.Forms.Label();
            this.Label2Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comment0 = new WindowsFormsControlLibrary1.UserControl1();
            this.comment1 = new WindowsFormsControlLibrary1.UserControl1();
            this.comment2 = new WindowsFormsControlLibrary1.UserControl1();
            this.comment3 = new WindowsFormsControlLibrary1.UserControl1();
            this.comment4 = new WindowsFormsControlLibrary1.UserControl1();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookImageRequest = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNameLabel.Font = new System.Drawing.Font("微软雅黑", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameLabel.Location = new System.Drawing.Point(66, 37);
            this.BookNameLabel.Margin = new System.Windows.Forms.Padding(64, 35, 64, 0);
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
            this.BookPictureBox.Location = new System.Drawing.Point(64, 11);
            this.BookPictureBox.Margin = new System.Windows.Forms.Padding(64, 11, 3, 3);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 1;
            this.BookPictureBox.TabStop = false;
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
            this.BookBorrowButton.Location = new System.Drawing.Point(196, 3);
            this.BookBorrowButton.Name = "BookBorrowButton";
            this.BookBorrowButton.Size = new System.Drawing.Size(96, 96);
            this.BookBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookBorrowButton.TabIndex = 15;
            this.BookBorrowButton.TabStop = false;
            this.BookBorrowButton.Click += new System.EventHandler(this.BookBorrowButton_Click);
            this.BookBorrowButton.MouseLeave += new System.EventHandler(this.BookBorrowButton_MouseLeave);
            this.BookBorrowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookBorrowButton_MouseMove);
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
            this.BookOrderButton.Location = new System.Drawing.Point(196, 1);
            this.BookOrderButton.Name = "BookOrderButton";
            this.BookOrderButton.Size = new System.Drawing.Size(96, 96);
            this.BookOrderButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookOrderButton.TabIndex = 16;
            this.BookOrderButton.TabStop = false;
            this.BookOrderButton.Click += new System.EventHandler(this.BookOrderButton_Click);
            this.BookOrderButton.MouseLeave += new System.EventHandler(this.BookOrderButton_MouseLeave);
            this.BookOrderButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookOrderButton_MouseMove);
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
            this.ResultDataSheet.Location = new System.Drawing.Point(523, 11);
            this.ResultDataSheet.Margin = new System.Windows.Forms.Padding(37, 11, 0, 0);
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
            this.ResultDataSheet.Size = new System.Drawing.Size(425, 212);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 17;
            this.ResultDataSheet.TabStop = false;
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
            // NoUseButton
            // 
            this.NoUseButton.BackColor = System.Drawing.Color.Transparent;
            this.NoUseButton.BackgroundImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NoUseButton.DM_DownImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("NoUseButton.DM_HoverImage")));
            this.NoUseButton.DM_Mode = false;
            this.NoUseButton.DM_NolImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.Location = new System.Drawing.Point(196, 4);
            this.NoUseButton.Name = "NoUseButton";
            this.NoUseButton.Size = new System.Drawing.Size(96, 96);
            this.NoUseButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.NoUseButton.TabIndex = 23;
            this.NoUseButton.Visible = false;
            this.NoUseButton.Click += new System.EventHandler(this.NoUseButton_Click);
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.BookInfoTextbox, 2);
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookInfoTextbox.Location = new System.Drawing.Point(64, 282);
            this.BookInfoTextbox.Margin = new System.Windows.Forms.Padding(64, 16, 0, 0);
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.Size = new System.Drawing.Size(50, 20);
            this.BookInfoTextbox.TabIndex = 33;
            this.BookInfoTextbox.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.BookNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comment0);
            this.flowLayoutPanel1.Controls.Add(this.comment1);
            this.flowLayoutPanel1.Controls.Add(this.comment2);
            this.flowLayoutPanel1.Controls.Add(this.comment3);
            this.flowLayoutPanel1.Controls.Add(this.comment4);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 697);
            this.flowLayoutPanel1.TabIndex = 35;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BookPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookInfoTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultDataSheet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BookOrderButton);
            this.panel2.Controls.Add(this.BookBorrowButton);
            this.panel2.Controls.Add(this.NoUseButton);
            this.panel2.Location = new System.Drawing.Point(489, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 100);
            this.panel2.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(246, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(211, 260);
            this.flowLayoutPanel2.TabIndex = 34;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.AuthorText);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 60);
            this.panel1.TabIndex = 45;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.authorLabel.Location = new System.Drawing.Point(3, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 20);
            this.authorLabel.TabIndex = 33;
            this.authorLabel.Text = "作　者：";
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.Transparent;
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AuthorText.Location = new System.Drawing.Point(65, 0);
            this.AuthorText.MaximumSize = new System.Drawing.Size(140, 0);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(135, 60);
            this.AuthorText.TabIndex = 36;
            this.AuthorText.Text = "测试作者测试作者测试作者测试作者测试作者测试作者";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.PublisherLabel);
            this.panel3.Controls.Add(this.PublisherText);
            this.panel3.Location = new System.Drawing.Point(8, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 20);
            this.panel3.TabIndex = 46;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.PublisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PublisherLabel.Location = new System.Drawing.Point(3, 0);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(65, 20);
            this.PublisherLabel.TabIndex = 34;
            this.PublisherLabel.Text = "出版社：";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.Transparent;
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PublisherText.Location = new System.Drawing.Point(65, 0);
            this.PublisherText.MaximumSize = new System.Drawing.Size(140, 0);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(79, 20);
            this.PublisherText.TabIndex = 38;
            this.PublisherText.Text = "测试出版社";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.BookIDLabel);
            this.panel4.Controls.Add(this.BookIDText);
            this.panel4.Location = new System.Drawing.Point(8, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 20);
            this.panel4.TabIndex = 47;
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookIDLabel.Location = new System.Drawing.Point(3, 0);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(65, 20);
            this.BookIDLabel.TabIndex = 35;
            this.BookIDLabel.Text = "书　号：";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.Transparent;
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookIDText.Location = new System.Drawing.Point(65, 0);
            this.BookIDText.Margin = new System.Windows.Forms.Padding(0);
            this.BookIDText.MaximumSize = new System.Drawing.Size(140, 0);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(73, 20);
            this.BookIDText.TabIndex = 37;
            this.BookIDText.Text = "12345678";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.AmountLabel);
            this.panel5.Controls.Add(this.AmountText);
            this.panel5.Location = new System.Drawing.Point(8, 132);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel5.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 20);
            this.panel5.TabIndex = 48;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AmountLabel.Location = new System.Drawing.Point(3, 0);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 39;
            this.AmountLabel.Text = "总　数：";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.BackColor = System.Drawing.Color.Transparent;
            this.AmountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AmountText.Location = new System.Drawing.Point(65, 0);
            this.AmountText.MaximumSize = new System.Drawing.Size(140, 0);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(25, 20);
            this.AmountText.TabIndex = 41;
            this.AmountText.Text = "12";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LabelLabel);
            this.panel6.Controls.Add(this.Label3Text);
            this.panel6.Controls.Add(this.Label1Text);
            this.panel6.Controls.Add(this.Label2Text);
            this.panel6.Location = new System.Drawing.Point(8, 160);
            this.panel6.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 49;
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LabelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabelLabel.Location = new System.Drawing.Point(3, 0);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(65, 20);
            this.LabelLabel.TabIndex = 40;
            this.LabelLabel.Text = "标　签：";
            // 
            // Label3Text
            // 
            this.Label3Text.AutoSize = true;
            this.Label3Text.BackColor = System.Drawing.Color.Transparent;
            this.Label3Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label3Text.Location = new System.Drawing.Point(65, 40);
            this.Label3Text.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label3Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label3Text.Name = "Label3Text";
            this.Label3Text.Size = new System.Drawing.Size(93, 20);
            this.Label3Text.TabIndex = 44;
            this.Label3Text.Text = "中国古典文学";
            // 
            // Label1Text
            // 
            this.Label1Text.AutoSize = true;
            this.Label1Text.BackColor = System.Drawing.Color.Transparent;
            this.Label1Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label1Text.Location = new System.Drawing.Point(65, 0);
            this.Label1Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label1Text.Name = "Label1Text";
            this.Label1Text.Size = new System.Drawing.Size(47, 20);
            this.Label1Text.TabIndex = 42;
            this.Label1Text.Text = "文学>";
            // 
            // Label2Text
            // 
            this.Label2Text.AutoSize = true;
            this.Label2Text.BackColor = System.Drawing.Color.Transparent;
            this.Label2Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label2Text.Location = new System.Drawing.Point(65, 20);
            this.Label2Text.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label2Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label2Text.Name = "Label2Text";
            this.Label2Text.Size = new System.Drawing.Size(75, 20);
            this.Label2Text.TabIndex = 43;
            this.Label2Text.Text = "中国文学>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22F);
            this.label2.Location = new System.Drawing.Point(50, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(48, 32, 3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "评论：";
            // 
            // comment0
            // 
            this.comment0.AutoSize = true;
            this.comment0.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comment0.Location = new System.Drawing.Point(66, 601);
            this.comment0.Margin = new System.Windows.Forms.Padding(64, 16, 64, 3);
            this.comment0.Name = "comment0";
            this.comment0.Size = new System.Drawing.Size(844, 86);
            this.comment0.TabIndex = 37;
            // 
            // comment1
            // 
            this.comment1.AutoSize = true;
            this.comment1.Location = new System.Drawing.Point(66, 706);
            this.comment1.Margin = new System.Windows.Forms.Padding(64, 16, 64, 3);
            this.comment1.Name = "comment1";
            this.comment1.Size = new System.Drawing.Size(844, 86);
            this.comment1.TabIndex = 40;
            // 
            // comment2
            // 
            this.comment2.AutoSize = true;
            this.comment2.Location = new System.Drawing.Point(66, 811);
            this.comment2.Margin = new System.Windows.Forms.Padding(64, 16, 64, 3);
            this.comment2.Name = "comment2";
            this.comment2.Size = new System.Drawing.Size(844, 86);
            this.comment2.TabIndex = 41;
            // 
            // comment3
            // 
            this.comment3.AutoSize = true;
            this.comment3.Location = new System.Drawing.Point(66, 916);
            this.comment3.Margin = new System.Windows.Forms.Padding(64, 16, 64, 3);
            this.comment3.Name = "comment3";
            this.comment3.Size = new System.Drawing.Size(844, 86);
            this.comment3.TabIndex = 39;
            // 
            // comment4
            // 
            this.comment4.AutoSize = true;
            this.comment4.Location = new System.Drawing.Point(66, 1021);
            this.comment4.Margin = new System.Windows.Forms.Padding(64, 16, 64, 3);
            this.comment4.Name = "comment4";
            this.comment4.Size = new System.Drawing.Size(844, 86);
            this.comment4.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.NextPageButton);
            this.panel7.Controls.Add(this.LastPageButton);
            this.panel7.Controls.Add(this.commentTextBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(2, 1110);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(969, 306);
            this.panel7.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("黑体", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(812, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 46;
            this.button1.TabStop = false;
            this.button1.Text = "发表评论";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NextPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NextPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.NextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NextPageButton.Location = new System.Drawing.Point(858, 15);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(50, 30);
            this.NextPageButton.TabIndex = 45;
            this.NextPageButton.TabStop = false;
            this.NextPageButton.Text = "下页";
            this.NextPageButton.UseVisualStyleBackColor = false;
            // 
            // LastPageButton
            // 
            this.LastPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LastPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LastPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LastPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastPageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LastPageButton.Location = new System.Drawing.Point(789, 15);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(50, 30);
            this.LastPageButton.TabIndex = 44;
            this.LastPageButton.TabStop = false;
            this.LastPageButton.Text = "上页";
            this.LastPageButton.UseVisualStyleBackColor = false;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.commentTextBox.Location = new System.Drawing.Point(68, 98);
            this.commentTextBox.MaxLength = 200;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(840, 137);
            this.commentTextBox.TabIndex = 39;
            this.commentTextBox.Text = "我是评论输入区域\r\n有啥想说的么\r\n没有\r\n再见\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label3.Location = new System.Drawing.Point(63, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(64, 16, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "添加评论：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // BookImageRequest
            // 
            this.BookImageRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookImageRequest_DoWork);
            this.BookImageRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookImageRequest_RunWorkerCompleted);
            // 
            // UserBookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserBookDetailForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private DMSkin.Controls.DM.DMButtonImage BookBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage BookOrderButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private DMSkin.Controls.DM.DMButtonImage NoUseButton;
        private System.Windows.Forms.Label BookInfoTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label Label3Text;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label Label2Text;
        private System.Windows.Forms.Label Label1Text;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.UserControl1 comment0;
        private WindowsFormsControlLibrary1.UserControl1 comment4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private WindowsFormsControlLibrary1.UserControl1 comment1;
        private WindowsFormsControlLibrary1.UserControl1 comment2;
        private WindowsFormsControlLibrary1.UserControl1 comment3;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.ComponentModel.BackgroundWorker BookImageRequest;
    }
}