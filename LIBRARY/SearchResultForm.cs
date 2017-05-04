using System;
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
    public partial class SearchResultForm : DMSkin.Main
    {
        private MainForm frmMain;
        private int ButtonState;//控制滑块位置 1 ALL 2 ISBN 3 NAME 4 AUTHOR 5 PUBLISHER
        public SearchResultForm(MainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }

        private void SearchResultForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;//1 第一层  2 第二层
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion

            #region 默认搜索条件：全部检索
            AllBackground.Show();
            SearchAll.ForeColor = Color.White;//默认检索条件：全部检索
            SearchAll.BackColor = Color.FromArgb(26, 148, 129);
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            ButtonState = 1;
            #endregion

            // to do 装载第一次搜索结果booklist
            for (int i = 0; i < ClassBackEnd.book.Count; i++)
            {
                var c = ClassBackEnd.book[i];
                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = c.bookisbn;
                ResultDataSheet.Rows[index].Cells[1].Value = c.bookname;
                ResultDataSheet.Rows[index].Cells[2].Value = c.author;
                ResultDataSheet.Rows[index].Cells[3].Value = c.publisher;
                ResultDataSheet.Rows[index].Cells[4].Value = c.bookamount;
                ResultDataSheet.Rows[index].Cells[5].Value = "详情";
                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #region SearchResultForm 按钮动画处理
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)//屏蔽换行回车键
        {
            if ((int)e.KeyCode == 13)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void SearchAll_MouseMove(object sender, MouseEventArgs e)
        {
            SearchAll.ForeColor = Color.White;
        }

        private void SearchAll_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 1)
            {
                SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchISBN_MouseMove(object sender, MouseEventArgs e)
        {
            SearchISBN.ForeColor = Color.White;
        }

        private void SearchISBN_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 2)
            {
                SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }
        private void SearchName_MouseMove(object sender, MouseEventArgs e)
        {
            SearchName.ForeColor = Color.White;
        }
        private void SearchName_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 3)
            {
                SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            SearchAuthor.ForeColor = Color.White;
        }

        private void SearchAuthor_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 4)
            {
                SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchPublisher_MouseMove(object sender, MouseEventArgs e)
        {
            SearchPublisher.ForeColor = Color.White;
        }

        private void SearchPublisher_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 5)
            {
                SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            }
        }

        private void SearchAll_Click(object sender, EventArgs e)
        {
            ButtonState = 1;
            AllBackground.Show();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            SearchAll.ForeColor = Color.White;
            SearchAll.BackColor = Color.FromArgb(26, 148, 129);
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
        }

        private void SearchISBN_Click(object sender, EventArgs e)
        {
            ButtonState = 2;
            AllBackground.Hide();
            ISBNBackground.Show();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.White;
            SearchISBN.BackColor = Color.FromArgb(26, 148, 129);
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            ButtonState = 3;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Show();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.White;
            SearchName.BackColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
        }

        private void SearchAuthor_Click(object sender, EventArgs e)
        {
            ButtonState = 4;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Show();
            PublisherBackgound.Hide();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.White;
            SearchAuthor.BackColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
        }

        private void SearchPublisher_Click(object sender, EventArgs e)
        {
            ButtonState = 5;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Show();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.White;
            SearchPublisher.BackColor = Color.FromArgb(26, 148, 129);
        }
        #endregion

        private void ResultDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                frmMain.MainPanel.Controls.Clear();
                BookDetailForm bookDetailForm = new BookDetailForm(frmMain, e.RowIndex);
                bookDetailForm.TopLevel = false;
                bookDetailForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailForm);
                bookDetailForm.Show();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)//重新检索按钮
        {
            ResultDataSheet.Rows.Clear();

            ClassBackEnd.book.Clear();
            ClassBackEnd.SearchBook(ButtonState, SearchBox.Text);

            for (int i = 0; i < ClassBackEnd.book.Count; i++)
            {
                var c = ClassBackEnd.book[i];
                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = c.bookisbn;
                ResultDataSheet.Rows[index].Cells[1].Value = c.bookname;
                ResultDataSheet.Rows[index].Cells[2].Value = c.author;
                ResultDataSheet.Rows[index].Cells[3].Value = c.publisher;
                ResultDataSheet.Rows[index].Cells[4].Value = c.bookamount;
                ResultDataSheet.Rows[index].Cells[5].Value = "详情";
                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }

}
