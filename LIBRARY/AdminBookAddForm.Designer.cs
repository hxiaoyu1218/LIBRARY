namespace LIBRARY
{
    partial class AdminBookAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookAddForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDBg = new System.Windows.Forms.PictureBox();
            this.BookNameCueText = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookNameBg = new System.Windows.Forms.PictureBox();
            this.AuthorCueText = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorBg = new System.Windows.Forms.PictureBox();
            this.PublisherCueText = new System.Windows.Forms.Label();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.PublisherBg = new System.Windows.Forms.PictureBox();
            this.BookAmountCueText = new System.Windows.Forms.Label();
            this.BookAmountTextBox = new System.Windows.Forms.TextBox();
            this.BookAmountBg = new System.Windows.Forms.PictureBox();
            this.BookInfoCueText = new System.Windows.Forms.Label();
            this.BookInfoTextBox = new System.Windows.Forms.TextBox();
            this.BookInfoBg = new System.Windows.Forms.PictureBox();
            this.BookImagePictureBox = new System.Windows.Forms.PictureBox();
            this.OKButton = new DMSkin.Controls.DM.DMButtonImage();
            this.AddImageButton = new DMSkin.Controls.DM.DMButtonImage();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.Label1CueText = new System.Windows.Forms.Label();
            this.Label1TextBox = new System.Windows.Forms.TextBox();
            this.Label1BG = new System.Windows.Forms.PictureBox();
            this.Label2CueText = new System.Windows.Forms.Label();
            this.Label2TextBox = new System.Windows.Forms.TextBox();
            this.Label2BG = new System.Windows.Forms.PictureBox();
            this.Label3CueText = new System.Windows.Forms.Label();
            this.Label3TextBox = new System.Windows.Forms.TextBox();
            this.Label3BG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNameBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAmountBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookInfoBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label3BG)).BeginInit();
            this.SuspendLayout();
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
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "添加图书";
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
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.White;
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(600, 565);
            this.BgImage.TabIndex = 0;
            this.BgImage.TabStop = false;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.IDTextBox.Location = new System.Drawing.Point(91, 79);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(254, 22);
            this.IDTextBox.TabIndex = 34;
            this.IDTextBox.TabStop = false;
            // 
            // IDBg
            // 
            this.IDBg.BackColor = System.Drawing.Color.White;
            this.IDBg.Image = ((System.Drawing.Image)(resources.GetObject("IDBg.Image")));
            this.IDBg.Location = new System.Drawing.Point(45, 70);
            this.IDBg.Name = "IDBg";
            this.IDBg.Size = new System.Drawing.Size(311, 42);
            this.IDBg.TabIndex = 35;
            this.IDBg.TabStop = false;
            // 
            // BookNameCueText
            // 
            this.BookNameCueText.AutoSize = true;
            this.BookNameCueText.BackColor = System.Drawing.Color.White;
            this.BookNameCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BookNameCueText.Location = new System.Drawing.Point(86, 133);
            this.BookNameCueText.Name = "BookNameCueText";
            this.BookNameCueText.Size = new System.Drawing.Size(39, 15);
            this.BookNameCueText.TabIndex = 39;
            this.BookNameCueText.Text = "书名";
            this.BookNameCueText.Click += new System.EventHandler(this.BookNameCueText_Click);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.BackColor = System.Drawing.Color.White;
            this.BookNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookNameTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BookNameTextBox.Location = new System.Drawing.Point(91, 130);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(254, 22);
            this.BookNameTextBox.TabIndex = 1;
            this.BookNameTextBox.Enter += new System.EventHandler(this.BookNameTextBox_Enter);
            this.BookNameTextBox.Leave += new System.EventHandler(this.BookNameTextBox_Leave);
            // 
            // BookNameBg
            // 
            this.BookNameBg.BackColor = System.Drawing.Color.White;
            this.BookNameBg.Image = ((System.Drawing.Image)(resources.GetObject("BookNameBg.Image")));
            this.BookNameBg.Location = new System.Drawing.Point(45, 121);
            this.BookNameBg.Name = "BookNameBg";
            this.BookNameBg.Size = new System.Drawing.Size(311, 42);
            this.BookNameBg.TabIndex = 38;
            this.BookNameBg.TabStop = false;
            // 
            // AuthorCueText
            // 
            this.AuthorCueText.AutoSize = true;
            this.AuthorCueText.BackColor = System.Drawing.Color.White;
            this.AuthorCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AuthorCueText.Location = new System.Drawing.Point(86, 185);
            this.AuthorCueText.Name = "AuthorCueText";
            this.AuthorCueText.Size = new System.Drawing.Size(39, 15);
            this.AuthorCueText.TabIndex = 42;
            this.AuthorCueText.Text = "作者";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.BackColor = System.Drawing.Color.White;
            this.AuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AuthorTextBox.Location = new System.Drawing.Point(91, 181);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(254, 22);
            this.AuthorTextBox.TabIndex = 2;
            this.AuthorTextBox.Enter += new System.EventHandler(this.AuthorTextBox_Enter);
            this.AuthorTextBox.Leave += new System.EventHandler(this.AuthorTextBox_Leave);
            // 
            // AuthorBg
            // 
            this.AuthorBg.BackColor = System.Drawing.Color.White;
            this.AuthorBg.Image = ((System.Drawing.Image)(resources.GetObject("AuthorBg.Image")));
            this.AuthorBg.Location = new System.Drawing.Point(45, 172);
            this.AuthorBg.Name = "AuthorBg";
            this.AuthorBg.Size = new System.Drawing.Size(311, 42);
            this.AuthorBg.TabIndex = 41;
            this.AuthorBg.TabStop = false;
            // 
            // PublisherCueText
            // 
            this.PublisherCueText.AutoSize = true;
            this.PublisherCueText.BackColor = System.Drawing.Color.White;
            this.PublisherCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PublisherCueText.Location = new System.Drawing.Point(86, 237);
            this.PublisherCueText.Name = "PublisherCueText";
            this.PublisherCueText.Size = new System.Drawing.Size(55, 15);
            this.PublisherCueText.TabIndex = 45;
            this.PublisherCueText.Text = "出版社";
            this.PublisherCueText.Click += new System.EventHandler(this.PublisherCueText_Click);
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.BackColor = System.Drawing.Color.White;
            this.PublisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublisherTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PublisherTextBox.Location = new System.Drawing.Point(91, 232);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(254, 22);
            this.PublisherTextBox.TabIndex = 3;
            this.PublisherTextBox.Enter += new System.EventHandler(this.PublisherTextBox_Enter);
            this.PublisherTextBox.Leave += new System.EventHandler(this.PublisherTextBox_Leave);
            // 
            // PublisherBg
            // 
            this.PublisherBg.BackColor = System.Drawing.Color.White;
            this.PublisherBg.Image = ((System.Drawing.Image)(resources.GetObject("PublisherBg.Image")));
            this.PublisherBg.Location = new System.Drawing.Point(45, 223);
            this.PublisherBg.Name = "PublisherBg";
            this.PublisherBg.Size = new System.Drawing.Size(311, 42);
            this.PublisherBg.TabIndex = 44;
            this.PublisherBg.TabStop = false;
            // 
            // BookAmountCueText
            // 
            this.BookAmountCueText.AutoSize = true;
            this.BookAmountCueText.BackColor = System.Drawing.Color.White;
            this.BookAmountCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookAmountCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BookAmountCueText.Location = new System.Drawing.Point(86, 286);
            this.BookAmountCueText.Name = "BookAmountCueText";
            this.BookAmountCueText.Size = new System.Drawing.Size(39, 15);
            this.BookAmountCueText.TabIndex = 48;
            this.BookAmountCueText.Text = "数量";
            this.BookAmountCueText.Click += new System.EventHandler(this.BookAmountCueText_Click);
            // 
            // BookAmountTextBox
            // 
            this.BookAmountTextBox.BackColor = System.Drawing.Color.White;
            this.BookAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookAmountTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookAmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BookAmountTextBox.Location = new System.Drawing.Point(91, 283);
            this.BookAmountTextBox.Name = "BookAmountTextBox";
            this.BookAmountTextBox.Size = new System.Drawing.Size(254, 22);
            this.BookAmountTextBox.TabIndex = 4;
            this.BookAmountTextBox.Enter += new System.EventHandler(this.BookAmountTextBox_Enter);
            this.BookAmountTextBox.Leave += new System.EventHandler(this.BookAmountTextBox_Leave);
            // 
            // BookAmountBg
            // 
            this.BookAmountBg.BackColor = System.Drawing.Color.White;
            this.BookAmountBg.Image = ((System.Drawing.Image)(resources.GetObject("BookAmountBg.Image")));
            this.BookAmountBg.Location = new System.Drawing.Point(45, 274);
            this.BookAmountBg.Name = "BookAmountBg";
            this.BookAmountBg.Size = new System.Drawing.Size(311, 42);
            this.BookAmountBg.TabIndex = 47;
            this.BookAmountBg.TabStop = false;
            // 
            // BookInfoCueText
            // 
            this.BookInfoCueText.AutoSize = true;
            this.BookInfoCueText.BackColor = System.Drawing.Color.White;
            this.BookInfoCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfoCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BookInfoCueText.Location = new System.Drawing.Point(86, 441);
            this.BookInfoCueText.Name = "BookInfoCueText";
            this.BookInfoCueText.Size = new System.Drawing.Size(39, 15);
            this.BookInfoCueText.TabIndex = 8;
            this.BookInfoCueText.Text = "简介";
            this.BookInfoCueText.Click += new System.EventHandler(this.BookInfoCueText_Click);
            // 
            // BookInfoTextBox
            // 
            this.BookInfoTextBox.BackColor = System.Drawing.Color.White;
            this.BookInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInfoTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BookInfoTextBox.Location = new System.Drawing.Point(91, 438);
            this.BookInfoTextBox.Multiline = true;
            this.BookInfoTextBox.Name = "BookInfoTextBox";
            this.BookInfoTextBox.Size = new System.Drawing.Size(254, 121);
            this.BookInfoTextBox.TabIndex = 8;
            this.BookInfoTextBox.Enter += new System.EventHandler(this.BookInfoTextBox_Enter);
            this.BookInfoTextBox.Leave += new System.EventHandler(this.BookInfoTextBox_Leave);
            // 
            // BookInfoBg
            // 
            this.BookInfoBg.BackColor = System.Drawing.Color.White;
            this.BookInfoBg.Image = ((System.Drawing.Image)(resources.GetObject("BookInfoBg.Image")));
            this.BookInfoBg.Location = new System.Drawing.Point(45, 429);
            this.BookInfoBg.Name = "BookInfoBg";
            this.BookInfoBg.Size = new System.Drawing.Size(311, 140);
            this.BookInfoBg.TabIndex = 50;
            this.BookInfoBg.TabStop = false;
            // 
            // BookImagePictureBox
            // 
            this.BookImagePictureBox.BackColor = System.Drawing.Color.White;
            this.BookImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookImagePictureBox.BackgroundImage")));
            this.BookImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookImagePictureBox.Location = new System.Drawing.Point(388, 70);
            this.BookImagePictureBox.Name = "BookImagePictureBox";
            this.BookImagePictureBox.Size = new System.Drawing.Size(171, 242);
            this.BookImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImagePictureBox.TabIndex = 52;
            this.BookImagePictureBox.TabStop = false;
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
            this.OKButton.Location = new System.Drawing.Point(425, 392);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 96);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 53;
            this.OKButton.TabStop = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // AddImageButton
            // 
            this.AddImageButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.BackgroundImage")));
            this.AddImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddImageButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_DownImage")));
            this.AddImageButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_HoverImage")));
            this.AddImageButton.DM_Mode = false;
            this.AddImageButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("AddImageButton.DM_NolImage")));
            this.AddImageButton.Location = new System.Drawing.Point(428, 137);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(96, 96);
            this.AddImageButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.AddImageButton.TabIndex = 54;
            this.AddImageButton.TabStop = false;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            this.AddImageButton.MouseLeave += new System.EventHandler(this.AddImageButton_MouseLeave);
            this.AddImageButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddImageButton_MouseMove);
            // 
            // OpenImage
            // 
            this.OpenImage.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            // 
            // Label1CueText
            // 
            this.Label1CueText.AutoSize = true;
            this.Label1CueText.BackColor = System.Drawing.Color.White;
            this.Label1CueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1CueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Label1CueText.Location = new System.Drawing.Point(86, 337);
            this.Label1CueText.Name = "Label1CueText";
            this.Label1CueText.Size = new System.Drawing.Size(47, 15);
            this.Label1CueText.TabIndex = 5;
            this.Label1CueText.Text = "标签1";
            this.Label1CueText.Click += new System.EventHandler(this.Label1CueText_Click);
            // 
            // Label1TextBox
            // 
            this.Label1TextBox.BackColor = System.Drawing.Color.White;
            this.Label1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label1TextBox.Font = new System.Drawing.Font("黑体", 14F);
            this.Label1TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Label1TextBox.Location = new System.Drawing.Point(91, 335);
            this.Label1TextBox.Name = "Label1TextBox";
            this.Label1TextBox.Size = new System.Drawing.Size(99, 22);
            this.Label1TextBox.TabIndex = 5;
            this.Label1TextBox.Enter += new System.EventHandler(this.Label1TextBox_Enter);
            this.Label1TextBox.Leave += new System.EventHandler(this.Label1TextBox_Leave);
            // 
            // Label1BG
            // 
            this.Label1BG.BackColor = System.Drawing.Color.White;
            this.Label1BG.Image = ((System.Drawing.Image)(resources.GetObject("Label1BG.Image")));
            this.Label1BG.Location = new System.Drawing.Point(45, 325);
            this.Label1BG.Name = "Label1BG";
            this.Label1BG.Size = new System.Drawing.Size(156, 42);
            this.Label1BG.TabIndex = 56;
            this.Label1BG.TabStop = false;
            // 
            // Label2CueText
            // 
            this.Label2CueText.AutoSize = true;
            this.Label2CueText.BackColor = System.Drawing.Color.White;
            this.Label2CueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2CueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Label2CueText.Location = new System.Drawing.Point(247, 337);
            this.Label2CueText.Name = "Label2CueText";
            this.Label2CueText.Size = new System.Drawing.Size(47, 15);
            this.Label2CueText.TabIndex = 6;
            this.Label2CueText.Text = "标签2";
            this.Label2CueText.Click += new System.EventHandler(this.Label2CueText_Click);
            // 
            // Label2TextBox
            // 
            this.Label2TextBox.BackColor = System.Drawing.Color.White;
            this.Label2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label2TextBox.Font = new System.Drawing.Font("黑体", 14F);
            this.Label2TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Label2TextBox.Location = new System.Drawing.Point(252, 335);
            this.Label2TextBox.Name = "Label2TextBox";
            this.Label2TextBox.Size = new System.Drawing.Size(99, 22);
            this.Label2TextBox.TabIndex = 6;
            this.Label2TextBox.Enter += new System.EventHandler(this.Label2TextBox_Enter);
            this.Label2TextBox.Leave += new System.EventHandler(this.Label2TextBox_Leave);
            // 
            // Label2BG
            // 
            this.Label2BG.BackColor = System.Drawing.Color.White;
            this.Label2BG.Image = ((System.Drawing.Image)(resources.GetObject("Label2BG.Image")));
            this.Label2BG.Location = new System.Drawing.Point(206, 325);
            this.Label2BG.Name = "Label2BG";
            this.Label2BG.Size = new System.Drawing.Size(156, 42);
            this.Label2BG.TabIndex = 59;
            this.Label2BG.TabStop = false;
            // 
            // Label3CueText
            // 
            this.Label3CueText.AutoSize = true;
            this.Label3CueText.BackColor = System.Drawing.Color.White;
            this.Label3CueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3CueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Label3CueText.Location = new System.Drawing.Point(86, 388);
            this.Label3CueText.Name = "Label3CueText";
            this.Label3CueText.Size = new System.Drawing.Size(47, 15);
            this.Label3CueText.TabIndex = 7;
            this.Label3CueText.Text = "标签3";
            this.Label3CueText.Click += new System.EventHandler(this.Label3CueText_Click);
            // 
            // Label3TextBox
            // 
            this.Label3TextBox.BackColor = System.Drawing.Color.White;
            this.Label3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label3TextBox.Font = new System.Drawing.Font("黑体", 14F);
            this.Label3TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Label3TextBox.Location = new System.Drawing.Point(91, 386);
            this.Label3TextBox.Name = "Label3TextBox";
            this.Label3TextBox.Size = new System.Drawing.Size(254, 22);
            this.Label3TextBox.TabIndex = 7;
            this.Label3TextBox.Enter += new System.EventHandler(this.Label3TextBox_Enter);
            this.Label3TextBox.Leave += new System.EventHandler(this.Label3TextBox_Leave);
            // 
            // Label3BG
            // 
            this.Label3BG.BackColor = System.Drawing.Color.White;
            this.Label3BG.Image = ((System.Drawing.Image)(resources.GetObject("Label3BG.Image")));
            this.Label3BG.Location = new System.Drawing.Point(45, 376);
            this.Label3BG.Name = "Label3BG";
            this.Label3BG.Size = new System.Drawing.Size(317, 42);
            this.Label3BG.TabIndex = 62;
            this.Label3BG.TabStop = false;
            // 
            // AdminBookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.Label3CueText);
            this.Controls.Add(this.Label3TextBox);
            this.Controls.Add(this.Label3BG);
            this.Controls.Add(this.Label2CueText);
            this.Controls.Add(this.Label2TextBox);
            this.Controls.Add(this.Label2BG);
            this.Controls.Add(this.Label1CueText);
            this.Controls.Add(this.Label1TextBox);
            this.Controls.Add(this.Label1BG);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BookImagePictureBox);
            this.Controls.Add(this.BookInfoCueText);
            this.Controls.Add(this.BookInfoTextBox);
            this.Controls.Add(this.BookInfoBg);
            this.Controls.Add(this.BookAmountCueText);
            this.Controls.Add(this.BookAmountTextBox);
            this.Controls.Add(this.BookAmountBg);
            this.Controls.Add(this.PublisherCueText);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.PublisherBg);
            this.Controls.Add(this.AuthorCueText);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorBg);
            this.Controls.Add(this.BookNameCueText);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookNameBg);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDBg);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminBookAddForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNameBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublisherBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAmountBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookInfoBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label3BG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.PictureBox IDBg;
        private System.Windows.Forms.Label BookNameCueText;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.PictureBox BookNameBg;
        private System.Windows.Forms.Label AuthorCueText;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.PictureBox AuthorBg;
        private System.Windows.Forms.Label PublisherCueText;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.PictureBox PublisherBg;
        private System.Windows.Forms.Label BookAmountCueText;
        private System.Windows.Forms.TextBox BookAmountTextBox;
        private System.Windows.Forms.PictureBox BookAmountBg;
        private System.Windows.Forms.Label BookInfoCueText;
        private System.Windows.Forms.TextBox BookInfoTextBox;
        private System.Windows.Forms.PictureBox BookInfoBg;
        private System.Windows.Forms.PictureBox BookImagePictureBox;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
        private DMSkin.Controls.DM.DMButtonImage AddImageButton;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.Label Label1CueText;
        private System.Windows.Forms.TextBox Label1TextBox;
        private System.Windows.Forms.PictureBox Label1BG;
        private System.Windows.Forms.Label Label2CueText;
        private System.Windows.Forms.TextBox Label2TextBox;
        private System.Windows.Forms.PictureBox Label2BG;
        private System.Windows.Forms.Label Label3CueText;
        private System.Windows.Forms.TextBox Label3TextBox;
        private System.Windows.Forms.PictureBox Label3BG;
    }
}