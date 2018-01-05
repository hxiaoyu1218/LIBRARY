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
    public partial class UserForm : DMSkin.Main
    {
        private UserMainForm frmMain;
        private int ButtonState;//0 借书信息 1 借阅记录 （默认0）
        public UserForm(UserMainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }
        private void SheeetRefresh()
        {
            MessageSheet.Rows.Clear();
            int i = 0;
            for (; i < ClassBackEnd.Usermessage.Count; i++)//至少填充6个
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = MessageSheet.Rows.Add(row);
                MessageSheet.Rows[index].Cells[0].Value = (i + 1).ToString();
                MessageSheet.Rows[index].Cells[1].Value = ClassBackEnd.Usermessage[i];
                MessageSheet.Rows[index].Height = 48;
            }
            while (i < 5)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = MessageSheet.Rows.Add(row);
                MessageSheet.Rows[index].Cells[0].Value = "";
                MessageSheet.Rows[index].Cells[1].Value = "";
                MessageSheet.Rows[index].Height = 48;
                i++;
            }
            MessageSheet.ClearSelection();
            MessageSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            BorrowInfoSheet.Rows.Clear();
            for (i = 0; i < ClassBackEnd.Userbsbook.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = ClassBackEnd.Userbsbook[i].Bookname;
                
                if (ClassBackEnd.Userbsbook[i].Isborrowed)
                {
					BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.Userbsbook[i].Bsdate + " " + ClassBackEnd.Userbsbook[i].Rgdate;
					BorrowInfoSheet.Rows[index].Cells[2].Value = "归还/续借";
                }
                else
                {
					BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.Userbsbook[i].Bsdate ;
					BorrowInfoSheet.Rows[index].Cells[2].Value = "取消预约";
                }
                BorrowInfoSheet.Rows[index].Height = 60;
            }
            while (i < 7)
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
            WelTextBox.Text = "欢迎，" + ClassBackEnd.Currentuser.Username + "！";
            AcedemicText.Text = ClassBackEnd.Currentuser.School;
            CreditText.Text = ClassBackEnd.Currentuser.Credit.ToString();
            MaxBorrowText.Text = ClassBackEnd.Currentuser.Currentmaxborrowableamount.ToString();
            NowBorrowText.Text = ClassBackEnd.Currentuser.Currentborrowedamount.ToString();
            NowOrderText.Text = ClassBackEnd.Currentuser.Currentscheduleamount.ToString();
            UserPicBox.Image = PickHeadImage();
        }
        private Image PickHeadImage()
        {
            if (Char.IsLetter(ClassBackEnd.Currentuser.Username[0]))
            {
                switch (ClassBackEnd.Currentuser.Username[0])
                {
                    case 'A':
                    case 'a':
                        return Properties.Resources.A;
                    case 'B':
                    case 'b':
                        return Properties.Resources.B;
                    case 'C':
                    case 'c':
                        return Properties.Resources.C;
                    case 'D':
                    case 'd':
                        return Properties.Resources.D;
                    case 'E':
                    case 'e':
                        return Properties.Resources.E;
                    case 'F':
                    case 'f':
                        return Properties.Resources.F;
                    case 'G':
                    case 'g':
                        return Properties.Resources.G;
                    case 'H':
                    case 'h':
                        return Properties.Resources.H;
                    case 'I':
                    case 'i':
                        return Properties.Resources.I;
                    case 'J':
                    case 'j':
                        return Properties.Resources.J;
                    case 'K':
                    case 'k':
                        return Properties.Resources.K;
                    case 'L':
                    case 'l':
                        return Properties.Resources.L;
                    case 'M':
                    case 'm':
                        return Properties.Resources.M;
                    case 'N':
                    case 'n':
                        return Properties.Resources.N;
                    case 'O':
                    case 'o':
                        return Properties.Resources.O;
                    case 'P':
                    case 'p':
                        return Properties.Resources.P;
                    case 'Q':
                    case 'q':
                        return Properties.Resources.Q;
                    case 'R':
                    case 'r':
                        return Properties.Resources.R;
                    case 'S':
                    case 's':
                        return Properties.Resources.S;
                    case 'T':
                    case 't':
                        return Properties.Resources.T;
                    case 'U':
                    case 'u':
                        return Properties.Resources.U;
                    case 'V':
                    case 'v':
                        return Properties.Resources.V;
                    case 'W':
                    case 'w':
                        return Properties.Resources.W;
                    case 'X':
                    case 'x':
                        return Properties.Resources.X;
                    case 'Y':
                    case 'y':
                        return Properties.Resources.Y;
                    case 'Z':
                    case 'z':
                        return Properties.Resources.Z;
                    default:
                        return Properties.Resources.DefaultHead;
                }

            }
            else
            {
                return Properties.Resources.DefaultHead;
            }
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
        private void BookInfoButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ButtonState == 0)
            {
                BookInfoLabel.Text = "借阅记录";
                BookInfoButton.Text = "借书信息";
                ButtonState = 1;
                BookRecordSheet.Show();
                BorrowInfoSheet.Hide();
            }
            else
            {
                BookInfoLabel.Text = "借书信息";
                BookInfoButton.Text = "借阅记录";
                ButtonState = 0;
                BookRecordSheet.Hide();
                BorrowInfoSheet.Show();
            }
        }

        private void UserChangeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void ChargeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditChargeForm chargeForm = new CreditChargeForm();
            chargeForm.ShowDialog();
            chargeForm.Dispose();
            UserInfoLoad();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordResetForm passwordChangeForm = new PasswordResetForm();
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }

        private void BookRecordSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                
                if(ClassBackEnd.BorrowHistoryIDown(e.RowIndex)==2)
				{
					MessageBox infobox = new MessageBox(25);
					infobox.ShowDialog();
					infobox.Dispose();
				}
				else
				{
					frmMain.MainPanel.Controls.Clear();
					UserBookDetailForm bookDetailForm = new UserBookDetailForm(frmMain, 0);
					bookDetailForm.TopLevel = false;
					bookDetailForm.Dock = DockStyle.Fill;
					frmMain.MainPanel.Controls.Add(bookDetailForm);
					bookDetailForm.Show();
					frmMain.ReturnButton.Tag = 3;
				}
                
            }
        }

        private void BorrowInfoSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (BorrowInfoSheet.Rows[e.RowIndex].Cells[2].Value.ToString() == "归还/续借")
                {

                    ClassBackEnd.BorrowedBookIDown(e.RowIndex);

                    UserReturnForm returnForm = new UserReturnForm(e.RowIndex);
                    returnForm.ShowDialog();
                    returnForm.Dispose();

                    ClassBackEnd.GetIntoPersonCenter();
                    SheeetRefresh();
                    UserInfoLoad();
                }
                else
                {
                    ClassBackEnd.CancelScheduleBook(e.RowIndex);
                    MessageBox ib = new MessageBox(21);
                    ib.ShowDialog();
                    ib.Dispose();

                    ClassBackEnd.GetIntoPersonCenter();
                    SheeetRefresh();
                    UserInfoLoad();
                }

            }
        }

        private void CreditRecordButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreditRecordForm creditRecordForm = new CreditRecordForm();
            creditRecordForm.ShowDialog();
            creditRecordForm.Dispose();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            UserChangeInfo userChangeInfo = new UserChangeInfo();
            userChangeInfo.Show();
        }
    }
}
