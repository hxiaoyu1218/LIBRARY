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
        public DeleteBox()
        {
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
            FileProtocol fileProtocol = new FileProtocol(RequestMode.UserDelComment, 6000);

            LoadingBox loadingBox = new LoadingBox(RequestMode.UserDelComment, "正在删除", fileProtocol);
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
                return;
            }
            else
            {
                PublicVar.ReturnValue = -233;
            }
        }
    }
}
