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

namespace LIBRARY
{
    public partial class BookDetailForm : DMSkin.Main
    {
        private MainForm frmMain;
        public BookDetailForm(MainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //to do button show or hide
            //search book if it is available to borrow
            BookBorrowButton.Show();
            BookOrderButton.Hide();
            frmMain.ReturnButton.Tag = 2;//return from bookdetailform to searchresultform


            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 96, 96);

            BookBorrowButton.Region = new Region(myPath);
            BookOrderButton.Region = new Region(myPath);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            // Mention: one kind of book can be borrowed or ordered once!
            //
            //if no book can be borrowed button enabled false
            // to do :
            //  bookborrowbutton.enabled = false;
            //
            //if no book can be ordered button enabled false
            // to do :
            //  bookorderbutton.enabled = false;



            for (int i = 0; i < 9; i++)//searchform的搜索结果，测试填表，共13行
            {

                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = "2233456123";
                ResultDataSheet.Rows[index].Cells[1].Value = "可借";

                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();

            ResultDataSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ResultDataSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;






        }

        private void BookBorrowButton_Click(object sender, EventArgs e)
        {
            InfoBox infoBox = new InfoBox(1,this);
            infoBox.StartPosition = FormStartPosition.Manual;
            Point p = frmMain.Location;
            p.X += 375;
            p.Y += 300;
            infoBox.Location = p;
            infoBox.Show();
            this.Enabled = false;
            BookBorrowButton.DM_NolImage = BookBorrowButton.DM_HoverImage;
            BookBorrowButton.Enabled = false;
        }

        private void BookOrderButton_Click(object sender, EventArgs e)
        {
            InfoBox infoBox = new InfoBox(2, this);
            infoBox.StartPosition = FormStartPosition.Manual;
            Point p = frmMain.Location;
            p.X += 375;
            p.Y += 300;
            infoBox.Location = p;
            infoBox.Show();
            this.Enabled = false;
            BookOrderButton.DM_NolImage = BookOrderButton.DM_HoverImage;
            BookOrderButton.Enabled = false;
        }
    }
}
