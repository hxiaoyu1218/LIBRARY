namespace LIBRARY
{
    partial class AdminUserManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserManageForm));
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.JumpPTextBox = new System.Windows.Forms.TextBox();
            this.NextPbutton = new System.Windows.Forms.PictureBox();
            this.LastPButton = new System.Windows.Forms.PictureBox();
            this.DividePicture = new System.Windows.Forms.PictureBox();
            this.DividerLine = new System.Windows.Forms.PictureBox();
            this.UserPanel = new LIBRARY.MyPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.SearchBox.Location = new System.Drawing.Point(194, 31);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(530, 46);
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
            this.SearchButton.Location = new System.Drawing.Point(724, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 46);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.PageTextBox.Location = new System.Drawing.Point(522, 658);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.ReadOnly = true;
            this.PageTextBox.Size = new System.Drawing.Size(68, 27);
            this.PageTextBox.TabIndex = 52;
            this.PageTextBox.TabStop = false;
            this.PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JumpPTextBox
            // 
            this.JumpPTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.JumpPTextBox.Location = new System.Drawing.Point(411, 658);
            this.JumpPTextBox.Name = "JumpPTextBox";
            this.JumpPTextBox.Size = new System.Drawing.Size(68, 27);
            this.JumpPTextBox.TabIndex = 51;
            this.JumpPTextBox.TabStop = false;
            this.JumpPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JumpPTextBox.TextChanged += new System.EventHandler(this.JumpPTextBox_TextChanged);
            // 
            // NextPbutton
            // 
            this.NextPbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPbutton.Image = ((System.Drawing.Image)(resources.GetObject("NextPbutton.Image")));
            this.NextPbutton.Location = new System.Drawing.Point(605, 653);
            this.NextPbutton.Name = "NextPbutton";
            this.NextPbutton.Size = new System.Drawing.Size(20, 36);
            this.NextPbutton.TabIndex = 54;
            this.NextPbutton.TabStop = false;
            this.NextPbutton.Click += new System.EventHandler(this.NextPbutton_Click);
            // 
            // LastPButton
            // 
            this.LastPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastPButton.Image = ((System.Drawing.Image)(resources.GetObject("LastPButton.Image")));
            this.LastPButton.Location = new System.Drawing.Point(376, 653);
            this.LastPButton.Name = "LastPButton";
            this.LastPButton.Size = new System.Drawing.Size(20, 36);
            this.LastPButton.TabIndex = 53;
            this.LastPButton.TabStop = false;
            this.LastPButton.Click += new System.EventHandler(this.LastPButton_Click);
            // 
            // DividePicture
            // 
            this.DividePicture.Image = ((System.Drawing.Image)(resources.GetObject("DividePicture.Image")));
            this.DividePicture.Location = new System.Drawing.Point(493, 658);
            this.DividePicture.Name = "DividePicture";
            this.DividePicture.Size = new System.Drawing.Size(18, 26);
            this.DividePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DividePicture.TabIndex = 50;
            this.DividePicture.TabStop = false;
            // 
            // DividerLine
            // 
            this.DividerLine.BackColor = System.Drawing.Color.Silver;
            this.DividerLine.Location = new System.Drawing.Point(60, 99);
            this.DividerLine.Name = "DividerLine";
            this.DividerLine.Size = new System.Drawing.Size(880, 1);
            this.DividerLine.TabIndex = 13;
            this.DividerLine.TabStop = false;
            // 
            // UserPanel
            // 
            this.UserPanel.Location = new System.Drawing.Point(0, 106);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1000, 541);
            this.UserPanel.TabIndex = 76;
            // 
            // AdminUserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.NextPbutton);
            this.Controls.Add(this.LastPButton);
            this.Controls.Add(this.PageTextBox);
            this.Controls.Add(this.JumpPTextBox);
            this.Controls.Add(this.DividePicture);
            this.Controls.Add(this.DividerLine);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.UserPanel);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.DM_ShadowWidth = 6;
            this.Name = "AdminUserManageForm";
            this.Text = "SearchResultForm";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividerLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;

        private System.Windows.Forms.PictureBox DividerLine;
        private System.Windows.Forms.PictureBox NextPbutton;
        private System.Windows.Forms.PictureBox LastPButton;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.TextBox JumpPTextBox;
        private System.Windows.Forms.PictureBox DividePicture;
        private MyPanel UserPanel;
    }
}