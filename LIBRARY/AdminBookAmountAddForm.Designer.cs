namespace LIBRARY
{
    partial class AdminBookAmountAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookAmountAddForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.AmountCueText = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.MoneyBg = new System.Windows.Forms.PictureBox();
            this.OKButton = new DMSkin.Controls.DM.DMButtonImage();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBg)).BeginInit();
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
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "添加数量";
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.White;
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(450, 165);
            this.BgImage.TabIndex = 3;
            this.BgImage.TabStop = false;
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
            this.ShutDownButton.Location = new System.Drawing.Point(415, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 6;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // AmountCueText
            // 
            this.AmountCueText.AutoSize = true;
            this.AmountCueText.BackColor = System.Drawing.Color.White;
            this.AmountCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AmountCueText.Location = new System.Drawing.Point(59, 97);
            this.AmountCueText.Name = "AmountCueText";
            this.AmountCueText.Size = new System.Drawing.Size(135, 15);
            this.AmountCueText.TabIndex = 24;
            this.AmountCueText.Text = "请输入增加的数量";
            this.AmountCueText.Click += new System.EventHandler(this.AmountCueText_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.BackColor = System.Drawing.Color.White;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AmountTextBox.Location = new System.Drawing.Point(63, 94);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(259, 22);
            this.AmountTextBox.TabIndex = 22;
            this.AmountTextBox.TabStop = false;
            this.AmountTextBox.Enter += new System.EventHandler(this.AmountTextBox_Enter);
            this.AmountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // MoneyBg
            // 
            this.MoneyBg.BackColor = System.Drawing.Color.White;
            this.MoneyBg.Image = ((System.Drawing.Image)(resources.GetObject("MoneyBg.Image")));
            this.MoneyBg.Location = new System.Drawing.Point(17, 85);
            this.MoneyBg.Name = "MoneyBg";
            this.MoneyBg.Size = new System.Drawing.Size(314, 42);
            this.MoneyBg.TabIndex = 23;
            this.MoneyBg.TabStop = false;
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
            this.OKButton.Location = new System.Drawing.Point(354, 67);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 80);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 25;
            this.OKButton.TabStop = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // AdminBookAmountAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AmountCueText);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.MoneyBg);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.BgImage);
            this.Controls.Add(this.TitleLabel);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminBookAmountAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChargeForm";
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox BgImage;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Label AmountCueText;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.PictureBox MoneyBg;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
    }
}