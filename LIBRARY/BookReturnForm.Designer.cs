
namespace LIBRARY
{
    partial class BookReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReturnForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Panel = new LIBRARY.MyPanel();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.LastPButton = new System.Windows.Forms.PictureBox();
            this.JumpPTextBox = new System.Windows.Forms.TextBox();
            this.DividePicture = new System.Windows.Forms.PictureBox();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.NextPbutton = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TitleLabel.Location = new System.Drawing.Point(62, 56);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(178, 51);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "书籍归还";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Panel.BackgroundImage = global::LIBRARY.Properties.Resources.UserFormBG;
            this.Panel.Controls.Add(this.NextPbutton);
            this.Panel.Controls.Add(this.PageTextBox);
            this.Panel.Controls.Add(this.DividePicture);
            this.Panel.Controls.Add(this.JumpPTextBox);
            this.Panel.Controls.Add(this.LastPButton);
            this.Panel.Controls.Add(this.RemindLabel);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1000, 705);
            this.Panel.TabIndex = 20;
            // 
            // RemindLabel
            // 
            this.RemindLabel.AutoSize = true;
            this.RemindLabel.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RemindLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.RemindLabel.Location = new System.Drawing.Point(354, 347);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(292, 27);
            this.RemindLabel.TabIndex = 0;
            this.RemindLabel.Text = "这里空空的。。。快去借点书吧";
            // 
            // LastPButton
            // 
            this.LastPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastPButton.Image = ((System.Drawing.Image)(resources.GetObject("LastPButton.Image")));
            this.LastPButton.Location = new System.Drawing.Point(404, 655);
            this.LastPButton.Name = "LastPButton";
            this.LastPButton.Size = new System.Drawing.Size(20, 36);
            this.LastPButton.TabIndex = 34;
            this.LastPButton.TabStop = false;
            // 
            // JumpPTextBox
            // 
            this.JumpPTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.JumpPTextBox.Location = new System.Drawing.Point(439, 660);
            this.JumpPTextBox.Name = "JumpPTextBox";
            this.JumpPTextBox.Size = new System.Drawing.Size(40, 27);
            this.JumpPTextBox.TabIndex = 35;
            this.JumpPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DividePicture
            // 
            this.DividePicture.Image = ((System.Drawing.Image)(resources.GetObject("DividePicture.Image")));
            this.DividePicture.Location = new System.Drawing.Point(493, 660);
            this.DividePicture.Name = "DividePicture";
            this.DividePicture.Size = new System.Drawing.Size(18, 26);
            this.DividePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DividePicture.TabIndex = 36;
            this.DividePicture.TabStop = false;
            // 
            // PageTextBox
            // 
            this.PageTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.PageTextBox.Location = new System.Drawing.Point(522, 660);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.ReadOnly = true;
            this.PageTextBox.Size = new System.Drawing.Size(40, 27);
            this.PageTextBox.TabIndex = 37;
            this.PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextPbutton
            // 
            this.NextPbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPbutton.Image = ((System.Drawing.Image)(resources.GetObject("NextPbutton.Image")));
            this.NextPbutton.Location = new System.Drawing.Point(577, 655);
            this.NextPbutton.Name = "NextPbutton";
            this.NextPbutton.Size = new System.Drawing.Size(20, 36);
            this.NextPbutton.TabIndex = 38;
            this.NextPbutton.TabStop = false;
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LIBRARY.Properties.Resources.UserFormBG;
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Panel);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookReturnForm";
            this.Text = "BookReturnForm";
            this.Load += new System.EventHandler(this.BookReturnForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label RemindLabel;
        private MyPanel Panel;
        private System.Windows.Forms.PictureBox LastPButton;
        private System.Windows.Forms.TextBox JumpPTextBox;
        private System.Windows.Forms.PictureBox DividePicture;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.PictureBox NextPbutton;
    }
}