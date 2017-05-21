namespace LIBRARY
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TimeWorker = new System.ComponentModel.BackgroundWorker();
            this.TimeTextBox = new System.Windows.Forms.Label();
            this.MinButton = new System.Windows.Forms.Button();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.UserChangeButton = new System.Windows.Forms.Button();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 16F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(61, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(142, 22);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "图书管理系统";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 705);
            this.MainPanel.TabIndex = 7;
            // 
            // TimeWorker
            // 
            this.TimeWorker.WorkerReportsProgress = true;
            this.TimeWorker.WorkerSupportsCancellation = true;
            this.TimeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TimeWorker_DoWork);
            this.TimeWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.TimeWorker_ProgressChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.AutoSize = true;
            this.TimeTextBox.Font = new System.Drawing.Font("黑体", 16F);
            this.TimeTextBox.ForeColor = System.Drawing.Color.White;
            this.TimeTextBox.Location = new System.Drawing.Point(418, 13);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(164, 22);
            this.TimeTextBox.TabIndex = 17;
            this.TimeTextBox.Text = "2017年04月21日";
            this.TimeTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeTextBox_MouseDown);
            this.TimeTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeTextBox_MouseMove);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.Transparent;
            this.MinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinButton.BackgroundImage")));
            this.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.MinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Location = new System.Drawing.Point(901, 5);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(35, 35);
            this.MinButton.TabIndex = 11;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
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
            this.ShutDownButton.Location = new System.Drawing.Point(954, 5);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 10;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(146)))), ((int)(((byte)(126)))));
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Location = new System.Drawing.Point(16, 5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(35, 35);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // UserChangeButton
            // 
            this.UserChangeButton.BackColor = System.Drawing.Color.Transparent;
            this.UserChangeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserChangeButton.BackgroundImage")));
            this.UserChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserChangeButton.FlatAppearance.BorderSize = 0;
            this.UserChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(146)))), ((int)(((byte)(126)))));
            this.UserChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.UserChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserChangeButton.Location = new System.Drawing.Point(848, 5);
            this.UserChangeButton.Name = "UserChangeButton";
            this.UserChangeButton.Size = new System.Drawing.Size(35, 35);
            this.UserChangeButton.TabIndex = 18;
            this.UserChangeButton.UseVisualStyleBackColor = false;
            this.UserChangeButton.Click += new System.EventHandler(this.UserChangeButton_Click);
            this.UserChangeButton.MouseLeave += new System.EventHandler(this.UserChangeButton_MouseLeave);
            this.UserChangeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserChangeButton_MouseMove);
            // 
            // RemindLabel
            // 
            this.RemindLabel.AutoSize = true;
            this.RemindLabel.ForeColor = System.Drawing.Color.White;
            this.RemindLabel.Location = new System.Drawing.Point(795, 27);
            this.RemindLabel.Name = "RemindLabel";
            this.RemindLabel.Size = new System.Drawing.Size(53, 12);
            this.RemindLabel.TabIndex = 19;
            this.RemindLabel.Text = "切换用户";
            this.RemindLabel.Visible = false;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.RemindLabel);
            this.Controls.Add(this.UserChangeButton);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainPanel);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 5;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button ShutDownButton;
        public System.Windows.Forms.Button ReturnButton;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Panel MainPanel;
        private System.ComponentModel.BackgroundWorker TimeWorker;
        private System.Windows.Forms.Label TimeTextBox;
        private System.Windows.Forms.Button UserChangeButton;
        private System.Windows.Forms.Label RemindLabel;
    }
}