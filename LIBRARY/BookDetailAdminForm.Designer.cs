namespace LIBRARY
{
    partial class BookDetailAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailAdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.PubCountLabel = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.BookInfoTextbox = new System.Windows.Forms.TextBox();
            this.BookImageButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.PubCountText = new System.Windows.Forms.Label();
            this.PageNumText = new System.Windows.Forms.Label();
            this.BookPreserveButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookInfoButton = new DMSkin.Controls.DM.DMButtonImage();
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
            // BookImageButton
            // 
            this.BookImageButton.BackColor = System.Drawing.Color.Transparent;
            this.BookImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.BackgroundImage")));
            this.BookImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookImageButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_DownImage")));
            this.BookImageButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_HoverImage")));
            this.BookImageButton.DM_Mode = false;
            this.BookImageButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_NolImage")));
            this.BookImageButton.Location = new System.Drawing.Point(543, 454);
            this.BookImageButton.Name = "BookImageButton";
            this.BookImageButton.Size = new System.Drawing.Size(96, 96);
            this.BookImageButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookImageButton.TabIndex = 16;
            this.BookImageButton.Click += new System.EventHandler(this.BookImageButton_Click);
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookState});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResultDataSheet.Location = new System.Drawing.Point(525, 141);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            // BookPreserveButton
            // 
            this.BookPreserveButton.BackColor = System.Drawing.Color.Transparent;
            this.BookPreserveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.BackgroundImage")));
            this.BookPreserveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPreserveButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_DownImage")));
            this.BookPreserveButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_HoverImage")));
            this.BookPreserveButton.DM_Mode = false;
            this.BookPreserveButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_NolImage")));
            this.BookPreserveButton.Location = new System.Drawing.Point(817, 454);
            this.BookPreserveButton.Name = "BookPreserveButton";
            this.BookPreserveButton.Size = new System.Drawing.Size(96, 96);
            this.BookPreserveButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookPreserveButton.TabIndex = 23;
            // 
            // BookInfoButton
            // 
            this.BookInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.BookInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.BackgroundImage")));
            this.BookInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookInfoButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_DownImage")));
            this.BookInfoButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_HoverImage")));
            this.BookInfoButton.DM_Mode = false;
            this.BookInfoButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_NolImage")));
            this.BookInfoButton.Location = new System.Drawing.Point(680, 454);
            this.BookInfoButton.Name = "BookInfoButton";
            this.BookInfoButton.Size = new System.Drawing.Size(96, 96);
            this.BookInfoButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookInfoButton.TabIndex = 24;
            this.BookInfoButton.Click += new System.EventHandler(this.BookInfoButton_Click);
            // 
            // BookDetailAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.BookInfoButton);
            this.Controls.Add(this.BookPreserveButton);
            this.Controls.Add(this.PageNumText);
            this.Controls.Add(this.PubCountText);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookIDText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.ResultDataSheet);
            this.Controls.Add(this.BookImageButton);
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
            this.Name = "BookDetailAdminForm";
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
        private DMSkin.Controls.DM.DMButtonImage BookImageButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label PubCountText;
        private System.Windows.Forms.Label PageNumText;
        private DMSkin.Controls.DM.DMButtonImage BookPreserveButton;
        private DMSkin.Controls.DM.DMButtonImage BookInfoButton;
    }
}