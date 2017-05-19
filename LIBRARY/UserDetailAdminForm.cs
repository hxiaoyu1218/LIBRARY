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
    public partial class UserDetailAdminForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        private int ButtonState;//0 借书信息 1 借阅记录 （默认0）
        public UserDetailAdminForm(AdminMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }
        private void SheeetRefresh()
        {
            int i = 0;

            BorrowInfoSheet.Rows.Clear();
            for (i = 0; i < ClassBackEnd.Userbsbook.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = ClassBackEnd.Userbsbook[i].Bookname;
                BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.Userbsbook[i].Bsdate.ToShortDateString() + " " + ClassBackEnd.Userbsbook[i].Rgdate.ToShortDateString();
                if (ClassBackEnd.Userbsbook[i].Isborrowed)
                {
                    BorrowInfoSheet.Rows[index].Cells[2].Value = "归还/续借";
                }
                else
                {
                    BorrowInfoSheet.Rows[index].Cells[2].Value = "取消预约";
                }
                BorrowInfoSheet.Rows[index].Height = 60;
            }
            while (i < 4)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = "";
                BorrowInfoSheet.Rows[index].Cells[1].Value = "";
                BorrowInfoSheet.Rows[index].Cells[2].Value = "";
                BorrowInfoSheet.Rows[index].Height = 60;
                i++;
            }
            BorrowInfoSheet.ClearSelection();
            BorrowInfoSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            BookRecordSheet.Rows.Clear();
            for (i = 0; i < ClassBackEnd.Borrowhis.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = ClassBackEnd.Borrowhis[i].Bookname;
                BookRecordSheet.Rows[index].Cells[1].Value = ClassBackEnd.Borrowhis[i].Borrowdata.ToShortDateString() + " " + ClassBackEnd.Borrowhis[i].Returndata.ToShortDateString();
                BookRecordSheet.Rows[index].Cells[2].Value = "详情";
                BookRecordSheet.Rows[index].Height = 60;
            }
            while (i < 7)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = "";
                BookRecordSheet.Rows[index].Cells[1].Value = "";
                BookRecordSheet.Rows[index].Cells[2].Value = "";
                BookRecordSheet.Rows[index].Height = 60;
                i++;
            }
            BookRecordSheet.ClearSelection();
            BookRecordSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BookRecordSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BookRecordSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void UserInfoLoad()
        {
            AcedemicText.Text = ClassBackEnd.Currentuser.School;
            CreditText.Text = ClassBackEnd.Currentuser.Credit.ToString();
            IDText.Text = ClassBackEnd.Currentuser.Currentmaxborrowableamount.ToString();
            NameText.Text = ClassBackEnd.Currentuser.Currentborrowedamount.ToString();
            RegistTimeText.Text = ClassBackEnd.Currentuser.Currentscheduleamount.ToString();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            ClassBackEnd.GetIntoPersonCenter();
            UserInfoLoad();
            ButtonState = 0;
            SheeetRefresh();
            BookRecordSheet.Hide();
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 1;
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
        }
   
        private void UserChangeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm();
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }

        private void BookRecordSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                //frmMain.MainPanel.Controls.Clear();
                //ClassBackEnd.BorrowHistoryIDown(e.RowIndex);
                //BookDetailForm bookDetailForm = new BookDetailForm(frmMain, 0);
                //bookDetailForm.TopLevel = false;
                //bookDetailForm.Dock = DockStyle.Fill;
                //frmMain.MainPanel.Controls.Add(bookDetailForm);
                //bookDetailForm.Show();
                //frmMain.ReturnButton.Tag = 3;
            }
        }

        private void BorrowInfoSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (BorrowInfoSheet.Rows[e.RowIndex].Cells[2].Value.ToString() == "归还/续借")
                {

                    ClassBackEnd.BorrowedBookIDown(e.RowIndex);

                    ReturnForm returnForm = new ReturnForm(e.RowIndex);
                    returnForm.ShowDialog();
                    returnForm.Dispose();

                    ClassBackEnd.GetIntoPersonCenter();
                    SheeetRefresh();
                    UserInfoLoad();
                }
                else
                {
                    ClassBackEnd.CancelScheduleBook(e.RowIndex);
                    InfoBox ib = new InfoBox(21);
                    ib.ShowDialog();
                    ib.Dispose();

                    ClassBackEnd.GetIntoPersonCenter();
                    SheeetRefresh();
                    UserInfoLoad();
                }

            }
        }
    }
}
