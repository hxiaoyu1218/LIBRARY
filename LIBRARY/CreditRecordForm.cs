using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class CreditRecordForm : DMSkin.Main
    {
        public CreditRecordForm()
        {
            InitializeComponent();
        }
        private void SheetLoad()
        {
            for (int i = 0; i < 16; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = (i + 1).ToString();
                CreditRecordSheet.Rows[i].Cells[1].Value = "用户于2017-05-22借阅了书籍《10086100860000》，于2017-05-22归还了书籍。扣除信用45。";
                CreditRecordSheet.Rows[index].Height = 48;
            }
            CreditRecordSheet.ClearSelection();
            CreditRecordSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void CreditRecordForm_Load(object sender, EventArgs e)
        {
            SheetLoad();

        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
