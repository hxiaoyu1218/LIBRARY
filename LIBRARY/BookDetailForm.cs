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
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class BookDetailForm : DMSkin.Main
    {
        private UserMainForm frmMain;
        private int bookIndex;//booklist索引
        public BookDetailForm(UserMainForm frm, int bookindex)
        {
            bookIndex = bookindex;
            frmMain = frm;
            InitializeComponent();
            if (Guest.GuestFlag == 1)
            {
                BookBorrowButton.Hide();
                BookOrderButton.Hide();
            }
        }
        public void BookListRefresh()
        {
            ResultDataSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < ClassBackEnd.Currentbook.Bookamount; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = ClassBackEnd.Currentbook.Book[i].Extisbn;
                if (ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Available)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "可借";
                }
                else if (ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Borrowed)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "已借";
                }
                else if (ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Invailable)
                {
                    ResultDataSheet.Rows[index].Cells[1].Value = "不可用";
                }
                else if (ClassBackEnd.Currentbook.Book[i].Bookstate == BOOKSTATE.Scheduled)
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
            BookInfoTextbox.Text = ClassBackEnd.Currentbook.Introduction;
            AmountText.Text = ClassBackEnd.Currentbook.Bookamount.ToString();
            Label1Text.Text = ClassBackEnd.Currentbook.Booklable1;
            Label2Text.Text = ClassBackEnd.Currentbook.Booklable2;
            Label3Text.Text = ClassBackEnd.Currentbook.Booklable3;
            try
            {
                BookPictureBox.Image = Image.FromFile(ClassBackEnd.Currentbook.Bookimage);
            }
            catch
            {
                BookPictureBox.Image = Properties.Resources.BookNullImage;//set default image
            }

        }
        private void OrderOrBorrow()
        {
            if (ClassBackEnd.HasBorrowed(bookIndex))
            {
                BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
                BookBorrowButton.Enabled = false;
                BookOrderButton.Hide();
            }
            else if (ClassBackEnd.GetBookState(bookIndex) == 1)
            {
                BookOrderButton.Hide();
            }
            else
            {
                if (ClassBackEnd.HasScheduled(bookIndex))
                {
                    BookOrderButton.DM_NolImage = BookOrderButton.DM_HoverImage;
                    BookOrderButton.Enabled = false;
                    BookBorrowButton.Hide();
                }
                else if(ClassBackEnd.GetBookState(bookIndex) == 2)
                {
                    BookBorrowButton.Hide();
                    BookOrderButton.Show();
                }
                else
                {
                    BookBorrowButton.Hide();
                    BookOrderButton.Hide();
                    NoUseButton.Show();
                }
            }
        }
        private void BookDetailForm_Load(object sender, EventArgs e)
        {


            BookDetailLoad();
            if (Guest.GuestFlag != 1) OrderOrBorrow();

            frmMain.ReturnButton.Tag = 2;

            #region 设置圆形按钮区域
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);
            BookBorrowButton.Region = new Region(myPath);
            BookOrderButton.Region = new Region(myPath);
            #endregion

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            BookListRefresh();

        }

        private void BookBorrowButton_Click(object sender, EventArgs e)
        {
            var b = ClassBackEnd.BorrowBook(bookIndex);
            if (b == 1)
            {
                #region Infobox Show
                InfoBox infoBox = new InfoBox(1, this);
                infoBox.StartPosition = FormStartPosition.Manual;
                Point p = frmMain.Location;
                p.X += 375;
                p.Y += 300;
                infoBox.Location = p;
                infoBox.Show();
                #endregion
                this.Enabled = false;
                BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
                BookBorrowButton.Enabled = false;
            }
            else if (b == 2)
            {
                #region Infobox Show
                InfoBox infoBox = new InfoBox(11, this);
                infoBox.StartPosition = FormStartPosition.Manual;
                Point p = frmMain.Location;
                p.X += 375;
                p.Y += 300;
                infoBox.Location = p;
                infoBox.Show();
                #endregion
                this.Enabled = false;
                BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
                BookBorrowButton.Enabled = false;
            }
            else if (b == 0)
            {
                #region Infobox Show
                InfoBox infoBox = new InfoBox(9, this);
                infoBox.StartPosition = FormStartPosition.Manual;
                Point p = frmMain.Location;
                p.X += 375;
                p.Y += 300;
                infoBox.Location = p;
                infoBox.Show();
                #endregion
                this.Enabled = false;
            }

        }

        private void BookOrderButton_Click(object sender, EventArgs e)
        {
            var v = ClassBackEnd.ScheduleBook(bookIndex);
            if (v)
            {
                #region Infobox Show
                InfoBox infoBox = new InfoBox(2, this);
                infoBox.StartPosition = FormStartPosition.Manual;
                Point p = frmMain.Location;
                p.X += 375;
                p.Y += 300;
                infoBox.Location = p;
                infoBox.Show();
                #endregion
            }
            else
            {
                #region Infobox Show
                InfoBox ib = new InfoBox(12, this);
                ib.StartPosition = FormStartPosition.Manual;
                Point p1 = frmMain.Location;
                p1.X += 375;
                p1.Y += 300;
                ib.Location = p1;
                ib.Show();
                #endregion
            }
            this.Enabled = false;
            BookOrderButton.DM_NolImage = BookOrderButton.DM_HoverImage;
            BookOrderButton.Enabled = false;
        }

        private void NoUseButton_Click(object sender, EventArgs e)
        {
            #region Infobox Show
            InfoBox infoBox = new InfoBox(22, this);
            infoBox.StartPosition = FormStartPosition.Manual;
            Point p = frmMain.Location;
            p.X += 375;
            p.Y += 300;
            infoBox.Location = p;
            infoBox.Show();
            #endregion
        }

        private void PubCountText_Click(object sender, EventArgs e)
        {

        }

        private void PageNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void PageNumText_Click(object sender, EventArgs e)
        {

        }

        private void PubCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
