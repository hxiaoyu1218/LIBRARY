using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibrarySystemBackEnd;

namespace LIBRARY
{
	public partial class BookDetailAdminForm : DMSkin.Main
	{
		private AdminMainForm frmMain;
		private int bookIndex;//booklist索引
		public BookDetailAdminForm(AdminMainForm frm, int bookindex)
		{
			bookIndex = bookindex;
			frmMain = frm;
			InitializeComponent();
		}
		public void BookListRefresh()
		{
			ResultDataSheet.Rows.Clear();
			for(int i = 0;i < ClassBackEnd.Currentbook.Bookamount;i++)
			{
				DataGridViewRow row = new DataGridViewRow();
				int index = ResultDataSheet.Rows.Add(row);
				ResultDataSheet.Rows[index].Cells[0].Value = ClassBackEnd.Currentbook.Book[i].Extisbn;
				if(ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Available)
				{
					ResultDataSheet.Rows[index].Cells[1].Value = "可借";
				}
				else if(ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Borrowed)
				{
					ResultDataSheet.Rows[index].Cells[1].Value = "已借";
				}
				else if(ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Invailable)
				{
					ResultDataSheet.Rows[index].Cells[1].Value = "不可用";
				}
				else if(ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Scheduled)
				{
					ResultDataSheet.Rows[index].Cells[1].Value = "仅预约";
				}

				ResultDataSheet.Rows[index].Height = 40;
			}
			ResultDataSheet.ClearSelection();
			ResultDataSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			ResultDataSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
		private void BookDetailLoad()
		{
			ClassBackEnd.LoadSearchResult(bookIndex);
			BookNameLabel.Text = ClassBackEnd.Currentbook.Bookname;
			AuthorText.Text = ClassBackEnd.Currentbook.Author;
			BookIDText.Text = ClassBackEnd.Currentbook.Bookisbn;
			PublisherText.Text = ClassBackEnd.Currentbook.Publisher;
			AmountText.Text = ClassBackEnd.Currentbook.Bookamount.ToString();
			Label1Text.Text = ClassBackEnd.Currentbook.Booklable1;
			Label2Text.Text = ClassBackEnd.Currentbook.Booklable2;
			Label3Text.Text = ClassBackEnd.Currentbook.Booklable3;

			if(ClassBackEnd.Currentbook.Introduction == "")
			{
				BookInfoTextbox.Text = "该书暂无相关简介。";
			}
			else
			{
				BookInfoTextbox.Text = ClassBackEnd.Currentbook.Introduction;
			}
			try
			{
				BookPictureBox.Image = Image.FromFile(ClassBackEnd.Currentbook.Bookimage);
			}
			catch
			{
				BookPictureBox.Image = Properties.Resources.BookNullImage;//set default image
			}

		}

		private void BookDetailForm_Load(object sender, EventArgs e)
		{


			BookDetailLoad();
			frmMain.ReturnButton.Tag = 2;

			#region 设置圆形按钮区域
			GraphicsPath myPath = new GraphicsPath();
			myPath.AddEllipse(0, 0, 96, 96);
			BookInfoButton.Region = new Region(myPath);
			BookPreserveButton.Region = new Region(myPath);
			BookImageButton.Region = new Region(myPath);
			#endregion

			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);

			BookListRefresh();

		}

		private void BookInfoButton_Click(object sender, EventArgs e)
		{
			BookInfoChangeForm bookInfoChangeForm = new BookInfoChangeForm();
			bookInfoChangeForm.ShowDialog();
			bookInfoChangeForm.Dispose();
			BookDetailLoad();
		}

		private void BookImageButton_Click(object sender, EventArgs e)
		{

			ChangeBookImageForm changeBookImageForm = new ChangeBookImageForm();
			changeBookImageForm.ShowDialog();
			changeBookImageForm.Dispose();
			BookPictureBox.Image.Dispose();
			if(Guest.DeletePath != "") System.IO.File.Delete(Guest.DeletePath);
			BookDetailLoad();

			Guest.DeletePath = "";
		}

		private void BookPreserveButton_Click(object sender, EventArgs e)
		{

			BookMaintainForm bookMaintainForm = new BookMaintainForm();
			bookMaintainForm.ShowDialog();
			bookMaintainForm.Dispose();
			BookListRefresh();
			BookPictureBox.Image.Dispose();
			if(Guest.Delpic != null && Guest.Delpic != "")
			{
				File.Delete(Guest.Delpic);
				Guest.Delpic = null;
				frmMain.ReturnButton.Tag = 2;
				ClassBackEnd.ClearBookList();
				frmMain.ReturnButton.PerformClick();
				//Close();
			}
		}
	}
}
