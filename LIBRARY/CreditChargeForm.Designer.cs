namespace LIBRARY
{
    partial class CreditChargeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditChargeForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.TextLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyCueText = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
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
            this.TitleLabel.Text = "信用充值";
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(450, 265);
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
            // TextLabel1
            // 
            this.TextLabel1.AutoSize = true;
            this.TextLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TextLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TextLabel1.Location = new System.Drawing.Point(77, 74);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.Size = new System.Drawing.Size(295, 21);
            this.TextLabel1.TabIndex = 7;
            this.TextLabel1.Text = "信用满分100，还书时每逾期3天信用减1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "信用会影响可借书数量，交钱一元可恢复一点信用";
            // 
            // MoneyCueText
            // 
            this.MoneyCueText.AutoSize = true;
            this.MoneyCueText.BackColor = System.Drawing.Color.White;
            this.MoneyCueText.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoneyCueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MoneyCueText.Location = new System.Drawing.Point(110, 151);
            this.MoneyCueText.Name = "MoneyCueText";
            this.MoneyCueText.Size = new System.Drawing.Size(119, 15);
            this.MoneyCueText.TabIndex = 24;
            this.MoneyCueText.Text = "请输入充值金额";
            this.MoneyCueText.Click += new System.EventHandler(this.MoneyCueText_Click);
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.BackColor = System.Drawing.Color.White;
            this.MoneyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyTextBox.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MoneyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MoneyTextBox.Location = new System.Drawing.Point(114, 148);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(259, 22);
            this.MoneyTextBox.TabIndex = 22;
            this.MoneyTextBox.TabStop = false;
            this.MoneyTextBox.Enter += new System.EventHandler(this.MoneyTextBox_Enter);
            this.MoneyTextBox.Leave += new System.EventHandler(this.MoneyTextBox_Leave);
            // 
            // MoneyBg
            // 
            this.MoneyBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MoneyBg.Image = ((System.Drawing.Image)(resources.GetObject("MoneyBg.Image")));
            this.MoneyBg.Location = new System.Drawing.Point(68, 139);
            this.MoneyBg.Name = "MoneyBg";
            this.MoneyBg.Size = new System.Drawing.Size(314, 42);
            this.MoneyBg.TabIndex = 23;
            this.MoneyBg.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.OKButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKButton.BackgroundImage")));
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OKButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_DownImage")));
            this.OKButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_HoverImage")));
            this.OKButton.DM_Mode = false;
            this.OKButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("OKButton.DM_NolImage")));
            this.OKButton.Location = new System.Drawing.Point(185, 202);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 80);
            this.OKButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.OKButton.TabIndex = 25;
            this.OKButton.TabStop = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            // 
            // CreditChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MoneyCueText);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.MoneyBg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextLabel1);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.BgImage);
            this.Controls.Add(this.TitleLabel);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditChargeForm";
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
        private System.Windows.Forms.Label TextLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoneyCueText;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.PictureBox MoneyBg;
        private DMSkin.Controls.DM.DMButtonImage OKButton;
    }
}