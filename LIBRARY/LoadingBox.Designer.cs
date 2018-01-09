namespace LIBRARY
{
    partial class LoadingBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingBox));
            this.InfoBg = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.Label();
            this.LoadGIFBox = new System.Windows.Forms.PictureBox();
            this.WaitingThread = new System.ComponentModel.BackgroundWorker();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SendingThread = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBg
            // 
            this.InfoBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.InfoBg.Location = new System.Drawing.Point(0, 30);
            this.InfoBg.Name = "InfoBg";
            this.InfoBg.Size = new System.Drawing.Size(250, 120);
            this.InfoBg.TabIndex = 0;
            this.InfoBg.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(6, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 16);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "图书管理系统";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TextBox.Font = new System.Drawing.Font("等线", 12F);
            this.TextBox.Location = new System.Drawing.Point(116, 73);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 23);
            this.TextBox.TabIndex = 7;
            this.TextBox.Text = "正在登录";
            this.TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadGIFBox
            // 
            this.LoadGIFBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.LoadGIFBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadGIFBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadGIFBox.Image")));
            this.LoadGIFBox.Location = new System.Drawing.Point(59, 59);
            this.LoadGIFBox.Name = "LoadGIFBox";
            this.LoadGIFBox.Size = new System.Drawing.Size(50, 50);
            this.LoadGIFBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadGIFBox.TabIndex = 24;
            this.LoadGIFBox.TabStop = false;
            // 
            // WaitingThread
            // 
            this.WaitingThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitingThread_DoWork);
            this.WaitingThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitingThread_RunWorkerCompleted);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(89, 119);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(73, 23);
            this.ConfirmButton.TabIndex = 25;
            this.ConfirmButton.TabStop = false;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SendingThread
            // 
            this.SendingThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendingThread_DoWork);
            this.SendingThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SendingThread_RunWorkerCompleted);
            // 
            // LoadingBox
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.LoadGIFBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InfoBg);
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.InfoBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InfoBg;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.PictureBox LoadGIFBox;
        private System.ComponentModel.BackgroundWorker WaitingThread;
        private System.Windows.Forms.Button ConfirmButton;
        private System.ComponentModel.BackgroundWorker SendingThread;
    }
}