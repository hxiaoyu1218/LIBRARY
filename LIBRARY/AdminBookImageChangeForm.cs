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
    public partial class AdminBookImageChangeForm : DMSkin.Main
    {
        string SavePath="";
        string OpenPath = "";
        string OpenFileName = "";
        public AdminBookImageChangeForm()
        {
            InitializeComponent();
        }
        private void ChangeBookImageForm_Load(object sender, EventArgs e)
        {

            try
            {
                OldImageBox.Image = PublicVar.BytesToImage(PublicVar.pic);
                OldImageBox.BorderStyle = BorderStyle.None;
            }
            catch
            {
                OldImageBox.Image = Properties.Resources.BookNullImage;//set default image
            }
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Animate


        private void AddImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_HoverImage;
        }

        private void AddImageButton_MouseLeave(object sender, EventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_NolImage;
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        #endregion

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenPath = OpenImage.FileName;
                OpenFileName = OpenImage.SafeFileName;
                SavePath = @"data\book\pic\" + OpenImage.SafeFileName;
                NewImageBox.Image = Image.FromFile(OpenPath);
                OpenImage.InitialDirectory = OpenPath.Substring(0, OpenPath.Length - OpenImage.SafeFileName.Length);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            /*PublicVar.DeletePath = ClassBackEnd.Currentbook.Bookimage;
            if (OpenPath != "" && SavePath != "")
                System.IO.File.Copy(OpenPath, SavePath, true);
            ClassBackEnd.ChangeBookImage(SavePath);
            OldImageBox.Image.Dispose();
            Close();*/
        }
    }
}
