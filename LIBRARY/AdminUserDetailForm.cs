using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
                BorrowInfoSheet.Rows[index].Cells[1].Value = PublicVar.classUser.BorrowedBooks[i].BorrowTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " + PublicVar.classUser.BorrowedBooks[i].ReturnTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
                BorrowInfoSheet.Rows[index].Cells[2].Value = "借阅";
                BorrowInfoSheet.Rows[index].Height = 60;
            }
            int offset = i;
            for (; i < PublicVar.classUser.ScheduledBooks.Count + offset; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = PublicVar.classUser.ScheduledBooks[i].BookName;
                BorrowInfoSheet.Rows[index].Cells[1].Value = PublicVar.classUser.ScheduledBooks[i].BorrowTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
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
                BookRecordSheet.Rows[index].Cells[1].Value = PublicVar.classUser.BorrowHis[i].BorrowTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " + PublicVar.classUser.BorrowHis[i].ReturnTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
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
            RegistTimeText.Text = PublicVar.classUser.UserBasic.UserRegisterDate.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
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
            PasswordResetForm passwordChangeForm = new PasswordResetForm(PublicVar.classUser.UserBasic.UserId);
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }

        private void BookRecordSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //detail
            if (e.ColumnIndex == 2)
            {
                PublicVar.ReturnValue = -233;
                FileProtocol fileProtocol = new FileProtocol(RequestMode.UserBookLoad, 6000);
                fileProtocol.NowBook = new ClassBook(PublicVar.classUser.BorrowHis[e.RowIndex].BookIsbn);
                fileProtocol.Userinfo = PublicVar.logUser;


                LoadingBox loadingBox = new LoadingBox(RequestMode.UserBookLoad, "正在加载", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();

                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }




                frmMain.MainPanel.Controls.Clear();

                AdminBookDetailForm bookDetailAdminForm = new AdminBookDetailForm(frmMain, 0);
                bookDetailAdminForm.TopLevel = false;
                bookDetailAdminForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailAdminForm);
                bookDetailAdminForm.Show();
                frmMain.ReturnButton.Tag = 4;

            }
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

            CreditChargeForm chargeForm = new CreditChargeForm(PublicVar.classUser.UserBasic.UserId);
            chargeForm.ShowDialog();

            if ((bool)chargeForm.Tag == true)
            {
                PublicVar.ReturnValue = -233;
                FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminGetUserDetail, 6000);

                fileProtocol.Userinfo = PublicVar.adminSearchUser[UserIndex];
                fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
                fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;


                LoadingBox loadingBox = new LoadingBox(RequestMode.AdminGetUserDetail, "更新数据", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();


                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }
                PublicVar.ReturnValue = -233;
            }
            chargeForm.Dispose();

            UserInfoLoad();
        }
    }
}
