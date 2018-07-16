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
    public partial class DeleteBox : DMSkin.Main
    {
		string bookIsbn;
        public DeleteBox(string bookIsbn)
        {
			this.bookIsbn = bookIsbn;
            InitializeComponent();
        }

        private void InfoBg_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AccrptButton_Click(object sender, EventArgs e)
        {
            PublicVar.ReturnValue = -233;
            FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminDeleteBook, 6000);
			fileProtocol.NowBook = new ClassBook(bookIsbn);

            LoadingBox loadingBox = new LoadingBox(RequestMode.AdminDeleteBook, "正在删除", fileProtocol);
            loadingBox.ShowDialog();
            loadingBox.Dispose();
            if (PublicVar.ReturnValue == 0)
            {
                System.Windows.Forms.MessageBox.Show("delete error!");
                PublicVar.ReturnValue = -233;
                return;
            }
            if (PublicVar.ReturnValue == -233)
            {
				System.Windows.Forms.MessageBox.Show("time out!");
				return;
            }
            else
            {
				System.Windows.Forms.MessageBox.Show("success!");
				Close();
				return;
            }
        }

		private void ShutDownButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
