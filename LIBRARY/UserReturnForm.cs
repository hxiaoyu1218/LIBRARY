using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class UserReturnForm : DMSkin.Main
    {
        private int index;
        public UserReturnForm(int _index)
        {
            index = _index;
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 102, 102);
            ReturnButton.Region = new Region(myPath);
            ReBorrowButton.Region = new Region(myPath);
            BookDetailLoad();
        }


        #region 按钮动画
        private void ReturnButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_HoverImage;
        }

        private void ReturnButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnButton.BackgroundImage = ReturnButton.DM_NolImage;
        }

        private void ReBorrowButton_MouseMove(object sender, MouseEventArgs e)
        {
            ReBorrowButton.BackgroundImage = ReBorrowButton.DM_HoverImage;
        }

        private void ReBorrowButton_MouseLeave(object sender, EventArgs e)
        {
            ReBorrowButton.BackgroundImage = ReBorrowButton.DM_NolImage;
        }
        #endregion
        private void BookDetailLoad()
        {
            BookNameText.Text = PublicVar.nowABook.BookName;
            AuthorText.Text = PublicVar.nowABook.BookAuthor;
            BookIDText.Text = PublicVar.nowABook.BookIsbn;
            PublisherText.Text = PublicVar.nowABook.BookPublisher;
            BorrowDateText.Text = PublicVar.nowABook.BorrowTime.ToLongDateString();
            ReturnDateText.Text = PublicVar.nowABook.ReturnTime.ToLongDateString();

            try
            {
                BookPictureBox.Image = PublicVar.BytesToImage(PublicVar.pic);
            }
            catch
            {
                BookPictureBox.Image = Properties.Resources.BookNullImage;
            }

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (ClassBackEnd.ReturnBook())
            {
                MessageBox ib = new MessageBox(16);
                ib.ShowDialog();
                ib.Dispose();
                Close();
            }
            else
            {
                MessageBox ib = new MessageBox(9);
                ib.ShowDialog();
                ib.Dispose();
            }
        }

        private void ReBorrowButton_Click(object sender, EventArgs e)
        {
            var t = ClassBackEnd.RenewBook();
            if (t == 1)
            {
                MessageBox ib = new MessageBox(17);
                ib.ShowDialog();
                ib.Dispose();
                Close();
            }
            else if (t == 2)
            {
                MessageBox ib = new MessageBox(18);
                ib.ShowDialog();
                ib.Dispose();
            }
            else if (t == 3)
            {
                MessageBox ib = new MessageBox(20);
                ib.ShowDialog();
                ib.Dispose();
            }
            else
            {
                MessageBox ib = new MessageBox(19);
                ib.ShowDialog();
                ib.Dispose();
            }
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
