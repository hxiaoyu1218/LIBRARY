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
    public partial class AdminUserDetailForm : DMSkin.Main
    {
        private AdminMainForm frmMain;
        public static int UserIndex;
        public AdminUserDetailForm(AdminMainForm frm, int index)
        {
            frmMain = frm;
            UserIndex = index;
            InitializeComponent();
        }
        private void SheeetRefresh()
        {
            int i = 0;

            BorrowInfoSheet.Rows.Clear();
            for (i = 0; i < PublicVar.classUser.BorrowedBooks.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = PublicVar.classUser.BorrowedBooks[i].BookName;
                BorrowInfoSheet.Rows[index].Cells[1].Value = PublicVar.classUser.BorrowedBooks[i].BorrowTime + " " + PublicVar.classUser.BorrowedBooks[i].ReturnTime;
                BorrowInfoSheet.Rows[index].Cells[2].Value = "借阅";
                BorrowInfoSheet.Rows[index].Height = 60;
            }
            int offset = i;
            for (; i < PublicVar.classUser.ScheduledBooks.Count + offset; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = PublicVar.classUser.ScheduledBooks[i].BookName;
                BorrowInfoSheet.Rows[index].Cells[1].Value = PublicVar.classUser.ScheduledBooks[i].BorrowTime + " " + PublicVar.classUser.ScheduledBooks[i].ReturnTime;
                BorrowInfoSheet.Rows[index].Cells[2].Value = "预约";
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
            for (i = 0; i < PublicVar.classUser.BorrowHis.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = PublicVar.classUser.BorrowHis[i].BookName;
                BookRecordSheet.Rows[index].Cells[1].Value = PublicVar.classUser.BorrowHis[i].BorrowTime + " " + PublicVar.classUser.BorrowHis[i].ReturnTime;
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
            AcedemicText.Text = PublicVar.classUser.UserBasic.UserSchool;
            CreditLinkText.Text = PublicVar.classUser.UserBasic.UserCredit.ToString();
            IDText.Text = PublicVar.classUser.UserBasic.UserId;
            NameText.Text = PublicVar.classUser.UserBasic.UserName;
            UserCategoryText.Text = PublicVar.classUser.UserBasic.UserType == Usertype.Student ? "学生" : "老师";
            RegistTimeText.Text = PublicVar.classUser.UserBasic.UserRegisterDate.ToShortDateString();
        }
        private void UserDetailAdminForm_Load(object sender, EventArgs e)
        {

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
            PasswordResetForm passwordChangeForm = new PasswordResetForm();
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }

        private void BookRecordSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //detail
            if (e.ColumnIndex == 2)
            {
                if (ClassBackEnd.BorrowHistoryIDown(e.RowIndex) == 2)
                {
                    MessageBox infobox = new MessageBox(25);
                    infobox.ShowDialog();
                    infobox.Dispose();
                }
                else
                {
                    frmMain.MainPanel.Controls.Clear();

                    AdminBookDetailForm bookDetailAdminForm = new AdminBookDetailForm(frmMain, 0);
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
            CreditChargeForm chargeForm = new CreditChargeForm();
            chargeForm.ShowDialog();
            chargeForm.Dispose();

            //renew user info
            UserInfoLoad();
        }
    }
}
