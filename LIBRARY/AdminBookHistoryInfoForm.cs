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
    public partial class AdminBookHistoryInfoForm : DMSkin.Main
    {
        private int index;
        public AdminBookHistoryInfoForm(int i)
        {
            //CreditRecordSheet.Rows.Clear();
            InitializeComponent();
            index = i;
        }
        private void SheetLoad()
        {
            CreditRecordSheet.Rows.Clear();
            int i = 0;
            for (i = 0; i < PublicVar.bookhis.Length; i++)
            {
                var tmp = PublicVar.bookhis.Length - i;
				DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = (i+1).ToString();
                CreditRecordSheet.Rows[i].Cells[1].Value = PublicVar.bookhis[tmp - 1].UserId;
                CreditRecordSheet.Rows[i].Cells[2].Value = PublicVar.bookhis[tmp - 1].BorrowTime.ToShortDateString();
                CreditRecordSheet.Rows[i].Cells[3].Value = PublicVar.bookhis[tmp - 1].ReturnTime.ToShortDateString();
				CreditRecordSheet.Rows[index].Height = 48;
            }
            while (i < 10)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = "";
                CreditRecordSheet.Rows[i].Cells[1].Value = "";
				CreditRecordSheet.Rows[i].Cells[2].Value = "";
				CreditRecordSheet.Rows[i].Cells[3].Value = "";
				CreditRecordSheet.Rows[index].Height = 48;
                i++;
            }
            CreditRecordSheet.ClearSelection();
            CreditRecordSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			CreditRecordSheet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			CreditRecordSheet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			CreditRecordSheet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}
        private void BookHistoryInfoForm_Load(object sender, EventArgs e)
        {
            //ClassBackEnd.GetBookHistory(index);
            FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminLoadABookHis, 6000);
            fileProtocol.NowABook = new ClassABook(PublicVar.eachBookState[index].BookIsbn);
            fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
            fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;

            LoadingBox loadingBox = new LoadingBox(RequestMode.AdminLoadABookHis, "正在加载", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();
            if (PublicVar.ReturnValue == -233) Close();
            SheetLoad();
            PublicVar.ReturnValue = -233;

        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
