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
        public static int UserIndex;
        public UserDetailAdminForm(AdminMainForm frm, int index)
        {
            frmMain = frm;
            UserIndex = index;
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
                BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.Userbsbook[i].Bsdate + " " + ClassBackEnd.Userbsbook[i].Rgdate;
                if (ClassBackEnd.Userbsbook[i].Isborrowed) BorrowInfoSheet.Rows[index].Cells[2].Value = "借阅";
                else BorrowInfoSheet.Rows[index].Cells[2].Value = "预约";
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
            BorrowInfoSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            BookRecordSheet.Rows.Clear();
            for (i = 0; i < ClassBackEnd.Borrowhis.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = ClassBackEnd.Borrowhis[i].Bookname;
                BookRecordSheet.Rows[index].Cells[1].Value = ClassBackEnd.Borrowhis[i].Borrowdata + " " + ClassBackEnd.Borrowhis[i].Returndata;
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
            CreditLinkText.Text = ClassBackEnd.Currentuser.Credit.ToString();
            IDText.Text = ClassBackEnd.Currentuser.Userid;
            NameText.Text = ClassBackEnd.Currentuser.Username;
            UserCategoryText.Text = ClassBackEnd.Currentuser.Usertype == USERTYPE.Student ? "学生" : "老师";
            RegistTimeText.Text = ClassBackEnd.Currentuser.RegisterDate;
        }
        private void UserDetailAdminForm_Load(object sender, EventArgs e)
        {
            ClassBackEnd.SearchUserIDown(UserIndex);
            UserInfoLoad();
            SheeetRefresh();
            #region 返回按钮处理
            frmMain.ReturnButton.Tag = 3;
            Point t = new Point(61, 11);
            frmMain.ReturnButton.Show();
            frmMain.TitleLabel.Location = t;
            #endregion
        }

        private void UserChangeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }


        private void PwdChangedLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm();
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }

        private void BookRecordSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
				if(ClassBackEnd.BorrowHistoryIDown(e.RowIndex) == 2)
				{
					InfoBox infobox = new InfoBox(25);
					infobox.ShowDialog();
					infobox.Dispose();
				}
				else
				{
					frmMain.MainPanel.Controls.Clear();

					BookDetailAdminForm bookDetailAdminForm = new BookDetailAdminForm(frmMain, 0);
					bookDetailAdminForm.TopLevel = false;
					bookDetailAdminForm.Dock = DockStyle.Fill;
					frmMain.MainPanel.Controls.Add(bookDetailAdminForm);
					bookDetailAdminForm.Show();
					frmMain.ReturnButton.Tag = 4;
				}
				
            }
        }

        private void CreditRecordButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditRecordForm creditRecordForm = new CreditRecordForm();
            creditRecordForm.ShowDialog();
            creditRecordForm.Dispose();
        }

        private void PwdChangedLinkButton_Enter(object sender, EventArgs e)
        {
            TitleLabel.Focus();
        }

        private void CreditRecordButton_Enter(object sender, EventArgs e)
        {
            TitleLabel.Focus();
        }

        private void CreditLinkText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChargeForm chargeForm = new ChargeForm();
            chargeForm.ShowDialog();
            chargeForm.Dispose();
            UserInfoLoad();
        }
    }
}
