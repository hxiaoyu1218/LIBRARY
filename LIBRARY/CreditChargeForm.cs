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
    public partial class CreditChargeForm : DMSkin.Main
    {
        private string userId;
        public CreditChargeForm(string _userId)
        {
            userId = _userId;
            InitializeComponent();
        }

        private void ChargeForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 80, 80);
            OKButton.Region = new Region(myPath);
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Close();
        }

        private void MoneyTextBox_Enter(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Hide();
            }
        }

        private void MoneyTextBox_Leave(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Show();
            }
        }

        private void MoneyCueText_Click(object sender, EventArgs e)
        {
            if (MoneyTextBox.Text == "")
            {
                MoneyCueText.Hide();
                MoneyTextBox.Focus();
            }
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                var num = Convert.ToInt32(MoneyTextBox.Text);
                PublicVar.ReturnValue = -233;
                FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminChargeUser, 6000);
                fileProtocol.Userinfo = new ClassUserBasicInfo(userId);
                fileProtocol.ChargeNum = num;
                fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
                fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;


                LoadingBox loadingBox = new LoadingBox(RequestMode.AdminChargeUser, "正在提交", fileProtocol);
                loadingBox.ShowDialog();
                loadingBox.Dispose();


                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }
                else if (PublicVar.ReturnValue == 0)
                {
                    MessageBox infoBox = new MessageBox(14);
                    infoBox.ShowDialog();
                    infoBox.Dispose();
                    this.Tag = true;
                    Close();
                }
                else
                {
                    MessageBox ib = new MessageBox(9);
                    ib.ShowDialog();
                    ib.Dispose();
                    return;
                }


            }
            catch
            {
                MessageBox infoBox = new MessageBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                MoneyTextBox.Focus();
            }
        }
    }
}
