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
    public partial class BookAmountAddForm : DMSkin.Main
    {
        public BookAmountAddForm()
        {
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
            Close();
        }

        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Hide();
            }
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Show();
            }
        }

        private void AmountCueText_Click(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Hide();
                AmountTextBox.Focus();
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
                var num = Convert.ToInt32(AmountTextBox.Text);
                if(!ClassBackEnd.AddBookAmount(num))
                {
                    InfoBox ib = new InfoBox(9);
                    ib.ShowDialog();
                    ib.Dispose();
                    return;
                }

                InfoBox infoBox = new InfoBox(3);
                infoBox.ShowDialog();
                infoBox.Dispose();
                Close();
            }
            catch
            {
                InfoBox infoBox = new InfoBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                AmountTextBox.Focus();
            }
        }
    }
}
