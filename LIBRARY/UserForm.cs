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
            for (i = 0; i < ClassBackEnd.userborredbook.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = ClassBackEnd.userborredbook[i].bookname;
                BorrowInfoSheet.Rows[index].Cells[1].Value = ClassBackEnd.userborredbook[i].bsdate.ToShortDateString() + " " + ClassBackEnd.userborredbook[i].rgdate.ToShortDateString();
                BorrowInfoSheet.Rows[index].Cells[2].Value = "归还/续借";
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
            for (i = 0; i < 7; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BookRecordSheet.Rows.Add(row);
                BookRecordSheet.Rows[index].Cells[0].Value = "C# 从入门到入土";
                BookRecordSheet.Rows[index].Cells[1].Value = "2020-12-12 2021-2-21";
                BookRecordSheet.Rows[index].Cells[2].Value = "详情";
                BookRecordSheet.Rows[index].Height = 60;
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
            CreditText.Text = ClassBackEnd.userdetail[2];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm();
            passwordChangeForm.ShowDialog();
            passwordChangeForm.Dispose();
        }
    }
}
