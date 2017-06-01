using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class AdminBookManageForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private static int maxPage;
        private static int nPage=1;
        private int lastState;
        private string lastString;
        private int flag = 1;
        private int ButtonState;// 1 ALL 2 ISBN 3 NAME 4 AUTHOR 5 PUBLISHER 6 LABEL

        public AdminBookManageForm(AdminMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }

        private void DataSheetLoad(int page)
        {
            ResultDataSheet.Rows.Clear();
            ResultDataSheet.Hide();
            if (ClassBackEnd.Book.Count == 0)
            {
                LoadGIFBox.Hide();
                NoResultTextBox.Show();
                AddBookButton.Show();
                NextPbutton.Hide();
                LastPButton.Hide();
                JumpPTextBox.Hide();
                PageTextBox.Hide();
                DividePicture.Hide();
                return;
            }
            else
            {
                NoResultTextBox.Hide();
                AddBookButton.Hide();
                NextPbutton.Show();
                LastPButton.Show();
                JumpPTextBox.Show();
                PageTextBox.Show();
                DividePicture.Show();
            }
            int start = (nPage - 1) * 10;
            int end = nPage * 10;
            if (nPage == maxPage) end = ClassBackEnd.Book.Count;

            for (int i = start; i < end; i++)
            {
                var c = ClassBackEnd.Book[i];
                DataGridViewRow row = (DataGridViewRow)ResultDataSheet.RowTemplate.Clone();
                int index = ResultDataSheet.Rows.Add(row);
                ResultDataSheet.Rows[index].Cells[0].Value = c.Bookisbn;
                ResultDataSheet.Rows[index].Cells[1].Value = c.Bookname;
                ResultDataSheet.Rows[index].Cells[2].Value = c.Author;
                ResultDataSheet.Rows[index].Cells[3].Value = c.Publisher;
                ResultDataSheet.Rows[index].Cells[4].Value = "详情";
            }
            LoadGIFBox.Hide();
            ResultDataSheet.Show();
            ResultDataSheet.ClearSelection();
            ResultDataSheet.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            JumpPTextBox.Text = nPage.ToString();
            PageTextBox.Text = maxPage.ToString();

        }

        private void BookManageForm_Load(object sender, EventArgs e)
        {
            DataSheetLoad(nPage);

            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;
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
            LabelBackground.Hide();
            ButtonState = 1;
            #endregion
        }

        #region SearchResultForm 按钮动画处理
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)//屏蔽换行回车键
        {
            if ((int)e.KeyCode == 13)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
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

        private void LabelButton_MouseMove(object sender, MouseEventArgs e)
        {
            LabelButton.ForeColor = Color.White;
        }

        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonState != 6)
            {
                LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
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
            LabelBackground.Hide();
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
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchISBN_Click(object sender, EventArgs e)
        {
            ButtonState = 2;
            AllBackground.Hide();
            ISBNBackground.Show();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
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
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            ButtonState = 3;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Show();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
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
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchAuthor_Click(object sender, EventArgs e)
        {
            ButtonState = 4;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Show();
            PublisherBackgound.Hide();
            LabelBackground.Hide();
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
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void SearchPublisher_Click(object sender, EventArgs e)
        {
            ButtonState = 5;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Show();
            LabelBackground.Hide();
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
            LabelButton.ForeColor = Color.FromArgb(26, 148, 129);
            LabelButton.BackColor = Color.Transparent;
        }

        private void LabelButton_Click(object sender, EventArgs e)
        {
            ButtonState = 6;
            AllBackground.Hide();
            ISBNBackground.Hide();
            NameBackground.Hide();
            AuthorBackground.Hide();
            PublisherBackgound.Hide();
            LabelBackground.Show();
            SearchAll.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAll.BackColor = Color.Transparent;
            SearchISBN.ForeColor = Color.FromArgb(26, 148, 129);
            SearchISBN.BackColor = Color.Transparent;
            SearchName.ForeColor = Color.FromArgb(26, 148, 129);
            SearchName.BackColor = Color.Transparent;
            SearchAuthor.ForeColor = Color.FromArgb(26, 148, 129);
            SearchAuthor.BackColor = Color.Transparent;
            SearchPublisher.ForeColor = Color.FromArgb(26, 148, 129);
            SearchPublisher.BackColor = Color.Transparent;
            LabelButton.ForeColor = Color.White;
            LabelButton.BackColor = Color.FromArgb(26, 148, 129);
        }

        private void AddBookButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddBookButton.BackgroundImage = AddBookButton.DM_HoverImage;
        }

        private void AddBookButton_MouseLeave(object sender, EventArgs e)
        {
            AddBookButton.BackgroundImage = AddBookButton.DM_NolImage;
        }
        #endregion

        private void ResultDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmMain.MainPanel.Controls.Clear();
                AdminBookDetailForm bookDetailAdminForm = new AdminBookDetailForm(frmMain, e.RowIndex + (nPage - 1) * 10);
                bookDetailAdminForm.TopLevel = false;
                bookDetailAdminForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailAdminForm);
                bookDetailAdminForm.Show();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                ClassBackEnd.Book.Clear();
                nPage = 1;
                DataSheetLoad(1);
                return;
            }
            NoResultTextBox.Hide();
            AddBookButton.Hide();
            ResultDataSheet.Rows.Clear();
            lastState = ButtonState;
            lastString = SearchBox.Text;
            LoadGIFBox.Show();
            while (SearchWorker.IsBusy)
            {
                SearchWorker.CancelAsync();
            }

            SearchWorker.RunWorkerAsync();
        }

        private void SearchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ClassBackEnd.SearchBook(lastState, lastString, SearchWorker,e);
            //System.Threading.Thread.Sleep(800);
        }

        private void SearchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ClassBackEnd.Book.Count <= 10) maxPage = 1;
            else maxPage = ClassBackEnd.Book.Count / 10 + 1;
            PageTextBox.Text = maxPage.ToString();
            JumpPTextBox.Text = "1";
            nPage = 1;
            DataSheetLoad(1);
        }

        private void LastPButton_Click(object sender, EventArgs e)
        {
            if (nPage == 1) return;
            JumpPTextBox.Text = (--nPage).ToString();
            DataSheetLoad(nPage);
        }

        private void NextPButton_Click(object sender, EventArgs e)
        {
            if (nPage == maxPage) return;
            JumpPTextBox.Text = (++nPage).ToString();
            DataSheetLoad(nPage);
        }

        private void JumpPTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var JumpPage = Convert.ToInt32(JumpPTextBox.Text);
                if (JumpPage > maxPage)
                {
                    nPage = maxPage;
                    JumpPTextBox.Text = nPage.ToString();
                }
                else nPage = Convert.ToInt32(JumpPTextBox.Text);
                DataSheetLoad(nPage);
            }
            catch
            {
                MessageBox infoBox = new MessageBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                JumpPTextBox.Focus();
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AdminBookAddForm addBookForm = new AdminBookAddForm();
            addBookForm.ShowDialog();
            addBookForm.Dispose();
        }
    }

}