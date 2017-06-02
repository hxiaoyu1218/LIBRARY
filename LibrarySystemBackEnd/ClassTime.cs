using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
    /// <summary>
    /// 系统间时
    /// </summary>
    public static class ClassTime
    {
        internal static DateTime systemTime;
        internal static int bookNum = 0;
        /// <summary>
        /// 用户到馆数量
        /// </summary>
        internal static int userCome = 0;
        private readonly static TimeSpan ts = new TimeSpan(1, 0, 0, 0);
        private static double lendingRate;

        /// <summary>
        /// 系统时间
        /// </summary>
        public static string SystemTime
        {
            get
            {
                var a = systemTime.Year.ToString("D4");
                var b = systemTime.Month.ToString("D2");
                var c = systemTime.Day.ToString("D2");
                return a + "年" + b + "月" + c + "日";
            }
        }
		/// <summary>
		/// 系统时间-表示
		/// </summary>
		internal static string SystemTimeEng
		{
			get
			{
				var a = systemTime.Year.ToString("D4");
				var b = systemTime.Month.ToString("D2");
				var c = systemTime.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
		}

		/// <summary>
		/// 增长时间
		/// </summary>
		public static void inc()
        {
            FileStream fs = null; StreamWriter sw = null;
            int i = 0; bool flag = false;
            while (i++ < 3 && flag == false)
            {
                try
                {
                    fs = new FileStream(ClassBackEnd.UserComingRate, FileMode.Append);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(systemTime);
                    sw.WriteLine(userCome);
                    sw.WriteLine(lendingRate);
                    userCome = 0;

                    flag = true;
                }
                catch
                {
                    System.Threading.Thread.Sleep(200);
                    continue;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }

            if (flag)
            {
                systemTime = systemTime + ts;
                bookNum = 0;
            }
        }
        internal static void ReadFromFile(StreamReader sr)
        {
            var a = Convert.ToInt32(sr.ReadLine());
            var b = Convert.ToInt32(sr.ReadLine());
            var c = Convert.ToInt32(sr.ReadLine());
            systemTime = new DateTime(a, b, c);
            bookNum = Convert.ToInt32(sr.ReadLine());
            userCome = Convert.ToInt32(sr.ReadLine());
        }
        internal static void SaveToFile(StreamWriter sw)
        {
            sw.WriteLine(systemTime.Year);
            sw.WriteLine(systemTime.Month);
            sw.WriteLine(systemTime.Day);
            sw.WriteLine(bookNum);
            sw.WriteLine(userCome);
        }
        /// <summary>
        /// 获取下一本书的ISBN
        /// </summary>
        /// <returns>ISBN,10位,为年4+月2+日2+当天的书籍序号2</returns>
        public static string getNextIsbn()
        {
            var a = systemTime.Year.ToString("D4");
            var b = systemTime.Month.ToString("D2");
            var c = systemTime.Day.ToString("D2");
            if (bookNum > 99) return null;
            return a + b + c + bookNum.ToString("D2");
        }
        internal static void IncNum()
        {
            bookNum++;
        }
        internal static void IncUserVis()
        {
            userCome++;
        }
        internal static void ChangeLendingRate(double tmp)
        {
            lendingRate = tmp;
        }
    }
}
