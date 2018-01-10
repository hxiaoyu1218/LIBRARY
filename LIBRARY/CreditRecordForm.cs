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

namespace LIBRARY
{
    public partial class CreditRecordForm : DMSkin.Main
    {
        List<string> list = new List<string>();
        public CreditRecordForm()
        {
            InitializeComponent();
        }
        private void SheetLoad()
        {
            int i = 0;
            for (i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = (i + 1).ToString();
                CreditRecordSheet.Rows[i].Cells[1].Value = list[i];
                CreditRecordSheet.Rows[index].Height = 68;
            }
            while (i < 8)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = "";
                CreditRecordSheet.Rows[i].Cells[1].Value = "";
                CreditRecordSheet.Rows[index].Height = 68;
                i++;
            }
            CreditRecordSheet.ClearSelection();
            CreditRecordSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void CreditRecordForm_Load(object sender, EventArgs e)
        {
            ClassBackEnd.GetUserCreditFile(ref list);
            SheetLoad();

        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
