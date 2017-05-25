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
    public partial class BookMaintainForm : DMSkin.Main
    {
        List<BOOKSTATE> list = new List<BOOKSTATE>();
        public BookMaintainForm()
        {
            InitializeComponent();
            DelButton.BackgroundImage = Properties.Resources.DelDisable;
            DelButton.Enabled = false;
        }
        private void CheckBox_Load()
        {
            int x = 27, y = 15;

            for (int i = 1; i <= list.Count; i++)
            {
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Font = new System.Drawing.Font("微软雅黑", 14F);
                cb.Location = new System.Drawing.Point(x, y);
                cb.Name = (i - 1).ToString();
                cb.Size = new System.Drawing.Size(75, 29);
                cb.TabIndex = 1;
                cb.Text = ClassBackEnd.Currentbook.Book[i - 1].Extisbn.Substring(10, 4);//id set
                cb.UseVisualStyleBackColor = true;
                cb.Visible = true;
                cb.Enabled = (list[i - 1] != BOOKSTATE.Borrowed);
                cb.Checked = (list[i - 1] == BOOKSTATE.Invailable);
                cb.Click += new EventHandler(CheckBox_Click);

                x += 211;

                if (i % 2 == 0)
                {
                    x = 27; y += 53;
                }
                CheckBoxPanel.Controls.Add(cb);
            }

        }
        private void DelButton_Check()
        {
            int flag = 0;
            foreach (Control c in CheckBoxPanel.Controls)
            {
                CheckBox ct = c as CheckBox;
                if (!ct.Checked)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                DelButton.Enabled = true;
                DelButton.BackgroundImage = DelButton.DM_NolImage;
            }
            else
            {
                DelButton.Enabled = false;
                DelButton.BackgroundImage = Properties.Resources.DelDisable;
            }

        }
        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int id = Convert.ToInt32(cb.Name);
            DelButton_Check();
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BookMaintainForm_Load(object sender, EventArgs e)
        {
            ClassBackEnd.GetBookState(ref list);

            CheckBox_Load();
            DelButton_Check();
        }

        #region Animate

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void DelButton_MouseMove(object sender, MouseEventArgs e)
        {
            DelButton.BackgroundImage = DelButton.DM_HoverImage;
        }

        private void DelButton_MouseLeave(object sender, EventArgs e)
        {
            DelButton.BackgroundImage = DelButton.DM_NolImage;
        }


        #endregion

        private void OKButton_Click(object sender, EventArgs e)
        {
            ClassBackEnd.MaintainBook(list);
            Close();
        }


        private void DelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
