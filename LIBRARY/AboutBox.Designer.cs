namespace LIBRARY
{
    partial class AboutBox
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
			this.AboutBg = new System.Windows.Forms.PictureBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.TextBox = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AboutBg)).BeginInit();
			this.SuspendLayout();
			// 
			// AboutBg
			// 
			this.AboutBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.AboutBg.Location = new System.Drawing.Point(0, 45);
			this.AboutBg.Name = "AboutBg";
			this.AboutBg.Size = new System.Drawing.Size(500, 255);
			this.AboutBg.TabIndex = 0;
			this.AboutBg.TabStop = false;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("黑体", 16F);
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(7, 10);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(142, 22);
			this.TitleLabel.TabIndex = 2;
			this.TitleLabel.Text = "图书管理系统";
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
			this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ConfirmButton.Font = new System.Drawing.Font("宋体", 12F);
			this.ConfirmButton.Location = new System.Drawing.Point(207, 258);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(87, 28);
			this.ConfirmButton.TabIndex = 6;
			this.ConfirmButton.TabStop = false;
			this.ConfirmButton.Text = "确定";
			this.ConfirmButton.UseVisualStyleBackColor = false;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// TextBox
			// 
			this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.TextBox.Font = new System.Drawing.Font("微软雅黑", 13F);
			this.TextBox.Location = new System.Drawing.Point(0, 58);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(500, 197);
			this.TextBox.TabIndex = 7;
			this.TextBox.Text = "Author: Hxy, Xzx, Lsp    \r\nEnvironment: C# with Winform on \r\n                    " +
    "         Visual Stdio 2015\r\n\r\nAny question please mail\r\nxzxxzx401@gmail.com";
			this.TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
			this.ClientSize = new System.Drawing.Size(500, 300);
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.AboutBg);
			this.DM_howBorder = false;
			this.Name = "AboutBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "InfoBox";
			this.Load += new System.EventHandler(this.InfoBox_Load);
			((System.ComponentModel.ISupportInitialize)(this.AboutBg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AboutBg;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label TextBox;
    }
}