namespace LIBRARY
{
    partial class DeleteBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBox));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoBg = new System.Windows.Forms.PictureBox();
            this.AccrptButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(7, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 16);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "图书管理系统";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TextBox.Font = new System.Drawing.Font("等线", 12F);
            this.TextBox.Location = new System.Drawing.Point(117, 62);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 23);
            this.TextBox.TabIndex = 9;
            this.TextBox.Text = "确认删除？";
            this.TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // InfoBg
            // 
            this.InfoBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.InfoBg.Location = new System.Drawing.Point(0, 30);
            this.InfoBg.Name = "InfoBg";
            this.InfoBg.Size = new System.Drawing.Size(250, 120);
            this.InfoBg.TabIndex = 3;
            this.InfoBg.TabStop = false;
            this.InfoBg.Click += new System.EventHandler(this.InfoBg_Click);
            // 
            // AccrptButton
            // 
            this.AccrptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.AccrptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.AccrptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AccrptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccrptButton.Location = new System.Drawing.Point(40, 115);
            this.AccrptButton.Name = "AccrptButton";
            this.AccrptButton.Size = new System.Drawing.Size(73, 23);
            this.AccrptButton.TabIndex = 26;
            this.AccrptButton.TabStop = false;
            this.AccrptButton.Text = "是";
            this.AccrptButton.UseVisualStyleBackColor = false;
            this.AccrptButton.Click += new System.EventHandler(this.AccrptButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(138, 115);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(73, 23);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "否";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AccrptButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InfoBg);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Name = "DeleteBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox InfoBg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Button AccrptButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}