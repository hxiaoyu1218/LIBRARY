using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystemBackEnd;
using System.Collections.Generic;

namespace LIBRARY
{
	public partial class AdminSystemLogForm : DMSkin.Main
	{
		private AdminMainForm frmMain;
		private static int state = 0;//用户到馆率1，书籍借阅率2，系统日志3
		private List<ClassGraph> lig = new List<ClassGraph>();
		private List<ClassLog> lil = new List<ClassLog>();
		private static int maxPage = 1;
		private static int nPage = 1;

		public AdminSystemLogForm(AdminMainForm frm)
		{
			frmMain = frm;
			InitializeComponent();

			UserComingRateComboBox.Hide();
			UserComingRateChart.Hide();
			BookLendingRateComboBox.Hide();
			BookLendingRateChart.Hide();
			LogDataSheet.Hide();
			LastPButton.Hide();
			JumpPTextBox.Hide();
			DividePicture.Hide();
			PageTextBox.Hide();
			NextPbutton.Hide();
		}

		private void AdminSystemLogForm_Load(object sender, EventArgs e)
		{
			#region 返回按钮处理
			frmMain.ReturnButton.Tag = 1;
			Point t = new Point(61, 11);
			frmMain.ReturnButton.Show();
			frmMain.TitleLabel.Location = t;
			#endregion
		}
		private void LoadUserComingRateGraph(int index)
		{
			this.UserComingRateChart.Series.Clear();

			DateTime o = new DateTime(1900, 1, 1);
			TimeSpan oo = new TimeSpan(2, 0, 0, 0);

			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
			series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
			series1.BorderWidth = 5;
			series1.Color = System.Drawing.SystemColors.Highlight;
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1;
			int last = lig.Count; int am = 0;
			if(index == 0) am = (7 < last ? last - 7 : 0);
			else if(index == 1) am = (30 < last ? last - 30 : 0);
			else if(index == 2) am = (90 < last ? last - 90 : 0);
			else if(index == 3) am = (365 <= last ? last - 365 : 0);

			for(int i = am;i < last;i++)
			{
				dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint((lig[i].Date - o + oo).TotalDays, lig[i].UserComing);
				series1.Points.Add(dataPoint1);
			}
			if(last - am < 15) series1.IsValueShownAsLabel = true;
			else series1.IsValueShownAsLabel = false;

			this.UserComingRateChart.Series.Add(series1);
		}
		private void LoadBookLendingRateGraph(int index)
		{
			this.BookLendingRateChart.Series.Clear();

			DateTime o = new DateTime(1900, 1, 1);
			TimeSpan oo = new TimeSpan(2, 0, 0, 0);

			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
			series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
			series1.BorderWidth = 5;
			series1.Color = System.Drawing.SystemColors.Highlight;
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1;
			int last = lig.Count; int am = 0;
			if(index == 0) am = (7 < last ? last - 7 : 0);
			else if(index == 1) am = (30 < last ? last - 30 : 0);
			else if(index == 2) am = (90 < last ? last - 90 : 0);
			else if(index == 3) am = (365 <= last ? last - 365 : 0);

			for(int i = am;i < last;i++)
			{
				dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint((lig[i].Date - o + oo).TotalDays, lig[i].LendingRate);
				series1.Points.Add(dataPoint1);
			}
			if(last - am < 15)
			{
				series1.IsValueShownAsLabel = true;
				series1.LabelFormat = "0.0000 %";
			}
			else series1.IsValueShownAsLabel = false;

			this.BookLendingRateChart.Series.Add(series1);
		}

		private void check()
		{
			if(state == 1)
			{
				BookLendingRateButton.Image = Properties.Resources.书籍借阅率;
				SystemInformationButton.Image = Properties.Resources.系统日志查看;
				UserComingRateComboBox.Show();
				UserComingRateChart.Show();
				BookLendingRateComboBox.Hide();
				BookLendingRateChart.Hide();
				LogDataSheet.Hide();
				LastPButton.Hide();
				JumpPTextBox.Hide();
				DividePicture.Hide();
				PageTextBox.Hide();
				NextPbutton.Hide();

				LoadUserComingRateGraph(UserComingRateComboBox.SelectedIndex);
			}
			else if(state == 2)
			{
				UserComingRateButton.Image = Properties.Resources.用户到馆率;
				SystemInformationButton.Image = Properties.Resources.系统日志查看;
				UserComingRateComboBox.Hide();
				UserComingRateChart.Hide();
				BookLendingRateComboBox.Show();
				BookLendingRateChart.Show();
				LogDataSheet.Hide();
				LastPButton.Hide();
				JumpPTextBox.Hide();
				DividePicture.Hide();
				PageTextBox.Hide();
				NextPbutton.Hide();

				LoadBookLendingRateGraph(BookLendingRateComboBox.SelectedIndex);
			}
			else if(state == 3)
			{
				UserComingRateButton.Image = Properties.Resources.用户到馆率;
				BookLendingRateButton.Image = Properties.Resources.书籍借阅率;
				UserComingRateComboBox.Hide();
				UserComingRateChart.Hide();
				BookLendingRateComboBox.Hide();
				BookLendingRateChart.Hide();
				LogDataSheet.Show();
				LastPButton.Show();
				JumpPTextBox.Show();
				DividePicture.Show();
				PageTextBox.Show();
				NextPbutton.Show();

				DataSheetLoad(nPage);
			}
		}

		private void UserComingRateButton_Click(object sender, EventArgs e)
		{
			state = 1;
			check();
			UserComingRateButton.Image = Properties.Resources.用户到馆率down;
			UserComingRateComboBox.SelectedIndex = 0;

			ClassBackEnd.GetGraphImformation(ref lig);
			LoadUserComingRateGraph(UserComingRateComboBox.SelectedIndex);
		}

		private void UserComingRateButton_MouseMove(object sender, MouseEventArgs e)
		{
			if(state != 1)
				UserComingRateButton.Image = Properties.Resources.用户到馆率touch;
		}

		private void UserComingRateButton_MouseLeave(object sender, EventArgs e)
		{
			if(state != 1)
				UserComingRateButton.Image = Properties.Resources.用户到馆率;
		}

		private void BookLendingRateButton_Click(object sender, EventArgs e)
		{
			state = 2;
			check();
			BookLendingRateButton.Image = Properties.Resources.书籍借阅率down;
			BookLendingRateComboBox.SelectedIndex = 0;

			ClassBackEnd.GetGraphImformation(ref lig);
			LoadBookLendingRateGraph(BookLendingRateComboBox.SelectedIndex);
		}

		private void BookLendingRateButton_MouseMove(object sender, MouseEventArgs e)
		{
			if(state != 2)
				BookLendingRateButton.Image = Properties.Resources.书籍借阅率touch;
		}

		private void BookLendingRateButton_MouseLeave(object sender, EventArgs e)
		{
			if(state != 2)
				BookLendingRateButton.Image = Properties.Resources.书籍借阅率;
		}

		private void SystemInformationButton_Click(object sender, EventArgs e)
		{
			state = 3;
			check();
			SystemInformationButton.Image = Properties.Resources.系统日志查看down;


			ClassBackEnd.GetLogImformation(ref lil);
			lil.Reverse();
			if(lil.Count <= 10) maxPage = 1;
			else maxPage = lil.Count / 10 + 1;

			PageTextBox.Text = maxPage.ToString();
			JumpPTextBox.Text = "1";
			nPage = 1;
			DataSheetLoad(1);
		}

		private void SystemInformationButton_MouseMove(object sender, MouseEventArgs e)
		{
			if(state != 3)
				SystemInformationButton.Image = Properties.Resources.系统日志查看touch;
		}

		private void SystemInformationButton_MouseLeave(object sender, EventArgs e)
		{
			if(state != 3)
				SystemInformationButton.Image = Properties.Resources.系统日志查看;
		}

		private void UserComingRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadUserComingRateGraph(UserComingRateComboBox.SelectedIndex);
		}

		private void BookLendingRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadBookLendingRateGraph(BookLendingRateComboBox.SelectedIndex);
		}

		private void DataSheetLoad(int page)
		{
			LogDataSheet.Rows.Clear();
			LogDataSheet.Hide();

			nPage = page;

			int start = (nPage - 1) * 10;
			int end = nPage * 10;
			if(nPage == maxPage) end = lil.Count;
			int num = 1;
			for(int i = start;i < end;i++)
			{
				var c = lil[i];
				DataGridViewRow row = (DataGridViewRow)LogDataSheet.RowTemplate.Clone();
				int index = LogDataSheet.Rows.Add(row);
				LogDataSheet.Rows[index].Cells[0].Value = num++;
				LogDataSheet.Rows[index].Cells[1].Value = c.Date;
				LogDataSheet.Rows[index].Cells[2].Value = c.User;
				LogDataSheet.Rows[index].Cells[3].Value = c.Inf;
			}
			LogDataSheet.Show();
			LogDataSheet.ClearSelection();
			LogDataSheet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

		}
		private void JumpPTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				var JumpPage = Convert.ToInt32(JumpPTextBox.Text);
				if(JumpPage > maxPage)
				{
					nPage = maxPage;
					JumpPTextBox.Text = nPage.ToString();
				}
				else nPage = Convert.ToInt32(JumpPTextBox.Text);
				DataSheetLoad(nPage);
			}
			catch
			{
				if(JumpPTextBox.Text == "") return;
				MessageBox infoBox = new MessageBox(13);
				infoBox.ShowDialog();
				infoBox.Dispose();
				JumpPTextBox.Focus();
			}
		}

		private void LastPButton_Click(object sender, EventArgs e)
		{
			if(nPage == 1) return;
			JumpPTextBox.Text = (--nPage).ToString();
			DataSheetLoad(nPage);
		}

		private void NextPButton_Click(object sender, EventArgs e)
		{
			if(nPage == maxPage) return;
			JumpPTextBox.Text = (++nPage).ToString();
			DataSheetLoad(nPage);
		}
	}

}