using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystemBackEnd;
using System.Drawing.Imaging;
using System.IO;

namespace LIBRARY
{
    class PublicVar
    {
        public static int GuestFlag = 0;
        public static string DeletePath = "";
		public static string Delpic = "";
        public static int ReturnValue = -233;
        public static int TEMP = -1;
        public static ClassBook[] currentBookList;
        public static ClassBook nowBook;
        public static ClassABook[] eachBookState;
        public static int bookTotalAmount;
        public static Image LoadHeadImage(string name)
        {
            switch (name[0])
            {
                case 'A':
                case 'a':
                    return Properties.Resources.A;
                case 'B':
                case 'b':
                    return Properties.Resources.B;
                case 'C':
                case 'c':
                    return Properties.Resources.C;
                case 'D':
                case 'd':
                    return Properties.Resources.D;
                case 'E':
                case 'e':
                    return Properties.Resources.E;
                case 'F':
                case 'f':
                    return Properties.Resources.F;
                case 'G':
                case 'g':
                    return Properties.Resources.G;
                case 'H':
                case 'h':
                    return Properties.Resources.H;
                case 'I':
                case 'i':
                    return Properties.Resources.I;
                case 'J':
                case 'j':
                    return Properties.Resources.J;
                case 'K':
                case 'k':
                    return Properties.Resources.K;
                case 'L':
                case 'l':
                    return Properties.Resources.L;
                case 'M':
                case 'm':
                    return Properties.Resources.M;
                case 'N':
                case 'n':
                    return Properties.Resources.N;
                case 'O':
                case 'o':
                    return Properties.Resources.O;
                case 'P':
                case 'p':
                    return Properties.Resources.P;
                case 'Q':
                case 'q':
                    return Properties.Resources.Q;
                case 'R':
                case 'r':
                    return Properties.Resources.R;
                case 'S':
                case 's':
                    return Properties.Resources.S;
                case 'T':
                case 't':
                    return Properties.Resources.T;
                case 'U':
                case 'u':
                    return Properties.Resources.U;
                case 'V':
                case 'v':
                    return Properties.Resources.V;
                case 'W':
                case 'w':
                    return Properties.Resources.W;
                case 'X':
                case 'x':
                    return Properties.Resources.X;
                case 'Y':
                case 'y':
                    return Properties.Resources.Y;
                case 'Z':
                case 'z':
                    return Properties.Resources.Z;
                default:
                    return Properties.Resources.DefaultHead;
            }
        }
        public static byte[] ImageToBytes(Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        /// <summary>
        /// Convert Byte[] to Image
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }
        public static ClassUserBasicInfo logUser;
        public static ClassComment nowComment;
        public static ClassComment[] currentCommentList;
        public static byte[] pic;
    }
}
