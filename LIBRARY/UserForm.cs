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
        private MainForm frmMain;
        private int ButtonState;//0 借书信息 1 借阅记录 （默认0）
        public UserForm(MainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }
        private void SheeetRefresh()
        {
            MessageSheet.Rows.Clear();//清空上一次搜索表
            int i = 0;
            for (; i < ClassBackEnd.usermessage.Count; i++)//至少填充6个
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = MessageSheet.Rows.Add(row);
                MessageSheet.Rows[index].Cells[0].Value = (i + 1).ToString();
                MessageSheet.Rows[index].Cells[1].Value = ClassBackEnd.usermessage[i];
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


            BorrowInfoSheet.Rows.Clear();//清空上一次搜索表
            for (i = 0; i < ClassBackEnd.userbsbook.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = ClassBackEnd.userbsbook[i].bookname;
                BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.userbsbook[i].bsdate.ToShortDateString() + " " + ClassBackEnd.userbsbook[i].rgdate.ToShortDateString();
                if (ClassBackEnd.userbsbook[i].isborrowed)
                {
                    BorrowInfoSheet.Rows[index].Cells[2].Value = "归还/续借";
                }
                else
                {
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



            BookRecordSheet.Rows.Clear();//清空上一次搜索表
            for (i = 0; i < ClassBackEnd.borrowhis.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = ClassBackEnd.borrowhis[i].bookname;
                BookRecordSheet.Rows[index].Cells[1].Value = ClassBackEnd.borrowhis[i].borrowdata.ToShortDateString() + " " + ClassBackEnd.borrowhis[i].returndata.ToShortDateString();
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
            WelTextBox.Text = "欢迎，" + ClassBackEnd.userdetail[0] + "！";
            AcedemicText.Text = ClassBackEnd.userdetail[1];
            CreditText.Text = ClassBackEnd.userdetail[2];
            MaxBorrowText.Text = ClassBackEnd.userdetail[3];
            NowBorrowText.Text = ClassBackEnd.userdetail[4];
            NowOrderText.Text = ClassBackEnd.userdetail[5];
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
            ChargeForm chargeForm = new ChargeForm();
            chargeForm.ShowDialog();
            chargeForm.Dispose();
            UserInfoLoad();

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
                frmMain.MainPanel.Controls.Clear();
                ClassBackEnd.BorrowHistoryIDown(e.RowIndex);
                BookDetailForm bookDetailForm = new BookDetailForm(frmMain, 0);
                bookDetailForm.TopLevel = false;
                bookDetailForm.Dock = DockStyle.Fill;
                frmMain.MainPanel.Controls.Add(bookDetailForm);
                bookDetailForm.Show();
                frmMain.ReturnButton.Tag = 3;
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
