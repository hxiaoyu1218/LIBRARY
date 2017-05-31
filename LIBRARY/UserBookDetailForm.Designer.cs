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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.BookBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookOrderButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.NoUseButton = new DMSkin.Controls.DM.DMButtonImage();
            this.Label3Text = new System.Windows.Forms.Label();
            this.Label2Text = new System.Windows.Forms.Label();
            this.Label1Text = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.BookInfoTextbox = new System.Windows.Forms.Label();
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
            this.BookPictureBox.Location = new System.Drawing.Point(74, 141);
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
            this.BookOrderButton.Location = new System.Drawing.Point(689, 454);
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookState});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle8;
            this.ResultDataSheet.Location = new System.Drawing.Point(525, 141);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ResultDataSheet.RowTemplate.Height = 40;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(425, 204);
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
            // NoUseButton
            // 
            this.NoUseButton.BackColor = System.Drawing.Color.Transparent;
            this.NoUseButton.BackgroundImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NoUseButton.DM_DownImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("NoUseButton.DM_HoverImage")));
            this.NoUseButton.DM_Mode = false;
            this.NoUseButton.DM_NolImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.Location = new System.Drawing.Point(689, 454);
            this.NoUseButton.Name = "NoUseButton";
            this.NoUseButton.Size = new System.Drawing.Size(96, 96);
            this.NoUseButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.NoUseButton.TabIndex = 23;
            this.NoUseButton.Visible = false;
            this.NoUseButton.Click += new System.EventHandler(this.NoUseButton_Click);
            // 
            // Label3Text
            // 
            this.Label3Text.AutoSize = true;
            this.Label3Text.BackColor = System.Drawing.Color.Transparent;
            this.Label3Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3Text.Location = new System.Drawing.Point(351, 327);
            this.Label3Text.Name = "Label3Text";
            this.Label3Text.Size = new System.Drawing.Size(132, 27);
            this.Label3Text.TabIndex = 32;
            this.Label3Text.Text = "中国古典文学";
            // 
            // Label2Text
            // 
            this.Label2Text.AutoSize = true;
            this.Label2Text.BackColor = System.Drawing.Color.Transparent;
            this.Label2Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2Text.Location = new System.Drawing.Point(351, 296);
            this.Label2Text.Name = "Label2Text";
            this.Label2Text.Size = new System.Drawing.Size(107, 27);
            this.Label2Text.TabIndex = 31;
            this.Label2Text.Text = "中国文学>";
            // 
            // Label1Text
            // 
            this.Label1Text.AutoSize = true;
            this.Label1Text.BackColor = System.Drawing.Color.Transparent;
            this.Label1Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1Text.Location = new System.Drawing.Point(351, 265);
            this.Label1Text.Name = "Label1Text";
            this.Label1Text.Size = new System.Drawing.Size(67, 27);
            this.Label1Text.TabIndex = 30;
            this.Label1Text.Text = "文学>";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.BackColor = System.Drawing.Color.Transparent;
            this.AmountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountText.Location = new System.Drawing.Point(351, 234);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(36, 27);
            this.AmountText.TabIndex = 29;
            this.AmountText.Text = "12";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LabelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLabel.Location = new System.Drawing.Point(268, 265);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(92, 27);
            this.LabelLabel.TabIndex = 28;
            this.LabelLabel.Text = "标　签：";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountLabel.Location = new System.Drawing.Point(268, 234);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(92, 27);
            this.AmountLabel.TabIndex = 27;
            this.AmountLabel.Text = "总　数：";
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.BookInfoTextbox.Location = new System.Drawing.Point(76, 423);
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.Size = new System.Drawing.Size(407, 189);
            this.BookInfoTextbox.TabIndex = 33;
            this.BookInfoTextbox.Text = "label1";
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.BookInfoTextbox);
            this.Controls.Add(this.Label3Text);
            this.Controls.Add(this.Label2Text);
            this.Controls.Add(this.Label1Text);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookIDText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.ResultDataSheet);
            this.Controls.Add(this.BookOrderButton);
            this.Controls.Add(this.BookBorrowButton);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookPictureBox);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.NoUseButton);
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
        private DMSkin.Controls.DM.DMButtonImage BookBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage BookOrderButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label PublisherText;
        private DMSkin.Controls.DM.DMButtonImage NoUseButton;
        private System.Windows.Forms.Label Label3Text;
        private System.Windows.Forms.Label Label2Text;
        private System.Windows.Forms.Label Label1Text;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label BookInfoTextbox;
    }
}