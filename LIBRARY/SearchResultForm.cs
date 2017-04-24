using System;
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
    public partial class SearchResultForm : DMSkin.Main
    {
        private MainForm frmMain;
        private int ButtonState;//控制滑块位置 1 ALL 2 ISBN 3 NAME 4 AUTHOR 5 PUBLISHER
        public SearchResultForm(MainForm frm)//待增加参数，用于接收searchForm页面的搜索参数并执行搜索，展示结果
        {
            frmMain = frm;
            InitializeComponent();
        }

        private void SearchResultForm_Load(object sender, EventArgs e)
        {

            frmMain.ReturnButton.Tag = 1;//1 代表搜索界面 2代表书籍详情
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;



            AllBackground.Show();
            SearchAll.ForeColor = Color.White;//默认检索条件：全部检索
            SearchAll.BackColor = Color.FromArgb(26, 148, 129);
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            ButtonState = 1;


            for (int i = 0; i < 13; i++)//searchform的搜索结果，测试填表
            {

                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = "2233456";
                ResultDataSheet.Rows[index].Cells[1].Value = "c++ begin and give up";
                ResultDataSheet.Rows[index].Cells[2].Value = "bupt";
                ResultDataSheet.Rows[index].Cells[3].Value = "c326 all";
                ResultDataSheet.Rows[index].Cells[4].Value = "233";
                ResultDataSheet.Rows[index].Cells[5].Value = "借书";
                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();

            ResultDataSheet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
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

        private void ResultDataSheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得link点击事件
            /* if (ResultDataSheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == null && e.ColumnIndex == 5) 
             {
                 MessageBox.Show("选中操作列的第" + (e.RowIndex + 1).ToString() + "行");
                 ResultDataSheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = true;//重新搜索后需要重置tag值
                 ResultDataSheet.ClearSelection();
                 ResultDataSheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "已借阅";       
             }*/
            if (e.ColumnIndex == 5)
            {
                frmMain.MainPanel.Controls.Clear();
                BookDetailForm bookDetailForm = new BookDetailForm(frmMain);
                bookDetailForm.TopLevel = false;
                bookDetailForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailForm);
                bookDetailForm.Show();

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)//重新检索按钮
        {
            ResultDataSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < 5; i++)//测试填表
            {

                DataGridViewRow row = new DataGridViewRow();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = "22";
                ResultDataSheet.Rows[index].Cells[1].Value = "c# give up";
                ResultDataSheet.Rows[index].Cells[2].Value = "bupt";
                ResultDataSheet.Rows[index].Cells[3].Value = "byr";
                ResultDataSheet.Rows[index].Cells[4].Value = "233";
                ResultDataSheet.Rows[index].Cells[5].Value = "借书";
                ResultDataSheet.Rows[index].Height = 40;
            }
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }

}
