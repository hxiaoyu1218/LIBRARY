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
    public partial class UserForm : DMSkin.Main
    {
        private MainForm frmMain;
        private int ButtonState;//0 借书信息 1 借阅记录 （默认0）
        public UserForm(MainForm frm)
        {
            frmMain = frm;
            InitializeComponent();
        }
        private void test()
        {
            MessageSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < 6; i++)//至少填充6个
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = MessageSheet.Rows.Add(row);
                MessageSheet.Rows[index].Cells[0].Value = i.ToString();
                MessageSheet.Rows[index].Cells[1].Value = "你预约的书已经到库请注意";
                MessageSheet.Rows[index].Height = 40;
            }
            MessageSheet.ClearSelection();
            MessageSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            BorrowInfoSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < 7; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = BorrowInfoSheet.Rows.Add(row);
                BorrowInfoSheet.Rows[index].Cells[0].Value = "SQL 从删库到跑路";
                BorrowInfoSheet.Rows[index].Cells[1].Value = "2017-12-12 2015-2-21";
                BorrowInfoSheet.Rows[index].Cells[2].Value = "归还/续借";
                BorrowInfoSheet.Rows[index].Height = 60;
            }
            BorrowInfoSheet.ClearSelection();
            BorrowInfoSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BorrowInfoSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            BookRecordSheet.Rows.Clear();//清空上一次搜索表
            for (int i = 0; i < 7; i++)
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
        private void UserForm_Load(object sender, EventArgs e)
        {
            ButtonState = 0;
            test();
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
    }
}
