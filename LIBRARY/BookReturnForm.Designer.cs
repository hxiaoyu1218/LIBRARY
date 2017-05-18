
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Panel = new LIBRARY.MyPanel();
            this.RemindLabel = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label RemindLabel;
        private MyPanel Panel;
    }
}