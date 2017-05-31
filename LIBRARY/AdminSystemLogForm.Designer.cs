namespace LIBRARY
{
    partial class AdminSystemLogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSystemLogForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SystemInformationButton = new System.Windows.Forms.PictureBox();
            this.BookLendingRateButton = new System.Windows.Forms.PictureBox();
            this.UserComingRateButton = new System.Windows.Forms.PictureBox();
            this.UserComingRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UserComingRateComboBox = new System.Windows.Forms.ComboBox();
            this.BookLendingRateComboBox = new System.Windows.Forms.ComboBox();
            this.BookLendingRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogDataSheet = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextPbutton = new System.Windows.Forms.PictureBox();
            this.LastPButton = new System.Windows.Forms.PictureBox();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.JumpPTextBox = new System.Windows.Forms.TextBox();
            this.DividePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SystemInformationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLendingRateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserComingRateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserComingRateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLendingRateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemInformationButton
            // 
            this.SystemInformationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemInformationButton.BackgroundImage")));
            this.SystemInformationButton.Location = new System.Drawing.Point(303, 38);
            this.SystemInformationButton.Name = "SystemInformationButton";
            this.SystemInformationButton.Size = new System.Drawing.Size(75, 75);
            this.SystemInformationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SystemInformationButton.TabIndex = 2;
            this.SystemInformationButton.TabStop = false;
            this.ToolTip.SetToolTip(this.SystemInformationButton, "系统详细日志");
            this.SystemInformationButton.Click += new System.EventHandler(this.SystemInformationButton_Click);
            this.SystemInformationButton.MouseLeave += new System.EventHandler(this.SystemInformationButton_MouseLeave);
            this.SystemInformationButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SystemInformationButton_MouseMove);
            // 
            // BookLendingRateButton
            // 
            this.BookLendingRateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookLendingRateButton.BackgroundImage")));
            this.BookLendingRateButton.Location = new System.Drawing.Point(187, 38);
            this.BookLendingRateButton.Name = "BookLendingRateButton";
            this.BookLendingRateButton.Size = new System.Drawing.Size(75, 75);
            this.BookLendingRateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookLendingRateButton.TabIndex = 1;
            this.BookLendingRateButton.TabStop = false;
            this.ToolTip.SetToolTip(this.BookLendingRateButton, "书籍借阅率");
            this.BookLendingRateButton.Click += new System.EventHandler(this.BookLendingRateButton_Click);
            this.BookLendingRateButton.MouseLeave += new System.EventHandler(this.BookLendingRateButton_MouseLeave);
            this.BookLendingRateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookLendingRateButton_MouseMove);
            // 
            // UserComingRateButton
            // 
            this.UserComingRateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserComingRateButton.BackgroundImage")));
            this.UserComingRateButton.Location = new System.Drawing.Point(69, 38);
            this.UserComingRateButton.Name = "UserComingRateButton";
            this.UserComingRateButton.Size = new System.Drawing.Size(75, 75);
            this.UserComingRateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserComingRateButton.TabIndex = 0;
            this.UserComingRateButton.TabStop = false;
            this.ToolTip.SetToolTip(this.UserComingRateButton, "用户到馆率");
            this.UserComingRateButton.Click += new System.EventHandler(this.UserComingRateButton_Click);
            this.UserComingRateButton.MouseLeave += new System.EventHandler(this.UserComingRateButton_MouseLeave);
            this.UserComingRateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserComingRateButton_MouseMove);
            // 
            // UserComingRateChart
            // 
            this.UserComingRateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.UserComingRateChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Title = "日期";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY.Title = "到馆量";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            chartArea1.Name = "ChartArea1";
            this.UserComingRateChart.ChartAreas.Add(chartArea1);
            this.UserComingRateChart.Location = new System.Drawing.Point(64, 151);
            this.UserComingRateChart.Name = "UserComingRateChart";
            this.UserComingRateChart.Size = new System.Drawing.Size(872, 473);
            this.UserComingRateChart.TabIndex = 3;
            this.UserComingRateChart.Text = "UserComingRateChart";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            title1.Name = "Title1";
            title1.Text = "用户到馆数量";
            this.UserComingRateChart.Titles.Add(title1);
            // 
            // UserComingRateComboBox
            // 
            this.UserComingRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComingRateComboBox.FormattingEnabled = true;
            this.UserComingRateComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserComingRateComboBox.Items.AddRange(new object[] {
            "最近7天",
            "最近30天",
            "最近90天",
            "最近1年"});
            this.UserComingRateComboBox.Location = new System.Drawing.Point(793, 172);
            this.UserComingRateComboBox.Name = "UserComingRateComboBox";
            this.UserComingRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.UserComingRateComboBox.TabIndex = 4;
            this.UserComingRateComboBox.TabStop = false;
            this.UserComingRateComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComingRateComboBox_SelectedIndexChanged);
            // 
            // BookLendingRateComboBox
            // 
            this.BookLendingRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookLendingRateComboBox.FormattingEnabled = true;
            this.BookLendingRateComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BookLendingRateComboBox.Items.AddRange(new object[] {
            "最近7天",
            "最近30天",
            "最近90天",
            "最近1年"});
            this.BookLendingRateComboBox.Location = new System.Drawing.Point(793, 172);
            this.BookLendingRateComboBox.Name = "BookLendingRateComboBox";
            this.BookLendingRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.BookLendingRateComboBox.TabIndex = 6;
            this.BookLendingRateComboBox.TabStop = false;
            this.BookLendingRateComboBox.SelectedIndexChanged += new System.EventHandler(this.BookLendingRateComboBox_SelectedIndexChanged);
            // 
            // BookLendingRateChart
            // 
            this.BookLendingRateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BookLendingRateChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.Title = "日期";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea2.AxisY.Title = "借阅率";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            chartArea2.Name = "ChartArea1";
            this.BookLendingRateChart.ChartAreas.Add(chartArea2);
            this.BookLendingRateChart.Location = new System.Drawing.Point(64, 151);
            this.BookLendingRateChart.Name = "BookLendingRateChart";
            this.BookLendingRateChart.Size = new System.Drawing.Size(872, 473);
            this.BookLendingRateChart.TabIndex = 5;
            this.BookLendingRateChart.Text = "BookLendingRateChart";
            title2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            title2.Name = "Title1";
            title2.Text = "书籍借阅率";
            this.BookLendingRateChart.Titles.Add(title2);
            // 
            // LogDataSheet
            // 
            this.LogDataSheet.AllowUserToAddRows = false;
            this.LogDataSheet.AllowUserToDeleteRows = false;
            this.LogDataSheet.AllowUserToResizeColumns = false;
            this.LogDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.LogDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LogDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.LogDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogDataSheet.CausesValidation = false;
            this.LogDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LogDataSheet.ColumnHeadersHeight = 40;
            this.LogDataSheet.ColumnHeadersVisible = false;
            this.LogDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Data,
            this.user,
            this.Detail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogDataSheet.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogDataSheet.Location = new System.Drawing.Point(69, 151);
            this.LogDataSheet.MultiSelect = false;
            this.LogDataSheet.Name = "LogDataSheet";
            this.LogDataSheet.ReadOnly = true;
            this.LogDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LogDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LogDataSheet.RowTemplate.Height = 45;
            this.LogDataSheet.RowTemplate.ReadOnly = true;
            this.LogDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LogDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDataSheet.ShowEditingIcon = false;
            this.LogDataSheet.Size = new System.Drawing.Size(867, 473);
            this.LogDataSheet.StandardTab = true;
            this.LogDataSheet.TabIndex = 7;
            this.LogDataSheet.TabStop = false;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // Data
            // 
            this.Data.HeaderText = "日期";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "用户";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "详情";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 616;
            // 
            // NextPbutton
            // 
            this.NextPbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPbutton.Image = ((System.Drawing.Image)(resources.GetObject("NextPbutton.Image")));
            this.NextPbutton.Location = new System.Drawing.Point(605, 625);
            this.NextPbutton.Name = "NextPbutton";
            this.NextPbutton.Size = new System.Drawing.Size(20, 36);
            this.NextPbutton.TabIndex = 40;
            this.NextPbutton.TabStop = false;
            this.NextPbutton.Click += new System.EventHandler(this.NextPButton_Click);
            // 
            // LastPButton
            // 
            this.LastPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastPButton.Image = ((System.Drawing.Image)(resources.GetObject("LastPButton.Image")));
            this.LastPButton.Location = new System.Drawing.Point(376, 625);
            this.LastPButton.Name = "LastPButton";
            this.LastPButton.Size = new System.Drawing.Size(20, 36);
            this.LastPButton.TabIndex = 39;
            this.LastPButton.TabStop = false;
            this.LastPButton.Click += new System.EventHandler(this.LastPButton_Click);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.PageTextBox.Location = new System.Drawing.Point(522, 630);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.ReadOnly = true;
            this.PageTextBox.Size = new System.Drawing.Size(68, 27);
            this.PageTextBox.TabIndex = 38;
            this.PageTextBox.TabStop = false;
            this.PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JumpPTextBox
            // 
            this.JumpPTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.JumpPTextBox.Location = new System.Drawing.Point(411, 630);
            this.JumpPTextBox.Name = "JumpPTextBox";
            this.JumpPTextBox.Size = new System.Drawing.Size(68, 27);
            this.JumpPTextBox.TabIndex = 37;
            this.JumpPTextBox.TabStop = false;
            this.JumpPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JumpPTextBox.TextChanged += new System.EventHandler(this.JumpPTextBox_TextChanged);
            // 
            // DividePicture
            // 
            this.DividePicture.Image = ((System.Drawing.Image)(resources.GetObject("DividePicture.Image")));
            this.DividePicture.Location = new System.Drawing.Point(493, 630);
            this.DividePicture.Name = "DividePicture";
            this.DividePicture.Size = new System.Drawing.Size(18, 26);
            this.DividePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DividePicture.TabIndex = 36;
            this.DividePicture.TabStop = false;
            // 
            // AdminSystemLogForm
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
            this.Controls.Add(this.SystemInformationButton);
            this.Controls.Add(this.BookLendingRateButton);
            this.Controls.Add(this.UserComingRateButton);
            this.Controls.Add(this.BookLendingRateComboBox);
            this.Controls.Add(this.BookLendingRateChart);
            this.Controls.Add(this.LogDataSheet);
            this.Controls.Add(this.UserComingRateChart);
            this.Controls.Add(this.UserComingRateComboBox);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.DM_ShadowWidth = 6;
            this.Name = "AdminSystemLogForm";
            this.Text = "SearchResultForm";
            this.Load += new System.EventHandler(this.AdminSystemLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemInformationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLendingRateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserComingRateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserComingRateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLendingRateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.PictureBox UserComingRateButton;
		private System.Windows.Forms.PictureBox BookLendingRateButton;
		private System.Windows.Forms.PictureBox SystemInformationButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart UserComingRateChart;
		private System.Windows.Forms.ComboBox UserComingRateComboBox;
		private System.Windows.Forms.ComboBox BookLendingRateComboBox;
		private System.Windows.Forms.DataVisualization.Charting.Chart BookLendingRateChart;
		private System.Windows.Forms.DataGridView LogDataSheet;
		private System.Windows.Forms.PictureBox NextPbutton;
		private System.Windows.Forms.PictureBox LastPButton;
		private System.Windows.Forms.TextBox PageTextBox;
		private System.Windows.Forms.TextBox JumpPTextBox;
		private System.Windows.Forms.PictureBox DividePicture;
		private System.Windows.Forms.DataGridViewTextBoxColumn Num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
	}
}