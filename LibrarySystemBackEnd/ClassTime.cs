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
	/// 系统时间
	/// </summary>
	public static class ClassTime
	{
		internal static DateTime systemTime;
		internal static int num = 0;
		private static TimeSpan ts = new TimeSpan(1, 0, 0, 0);

		/// <summary>
		/// get属性，set属性
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
		/// 增长时间
		/// </summary>
		public static void inc()
		{
			systemTime = systemTime + ts;
			num = 0;
		}
		internal static void ReadFromFile(StreamReader sr)
		{
			var a = Convert.ToInt32(sr.ReadLine());
			var b = Convert.ToInt32(sr.ReadLine());
			var c = Convert.ToInt32(sr.ReadLine());
			systemTime = new DateTime(a, b, c);
			num = Convert.ToInt32(sr.ReadLine());
		}
		internal static void SaveToFile(StreamWriter sw)
		{
			sw.WriteLine(systemTime.Year);
			sw.WriteLine(systemTime.Month);
			sw.WriteLine(systemTime.Day);
			sw.WriteLine(num);
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
			if(num > 99) return null;
			return a + b + c + num.ToString("D2");
		}
		internal static void IncNum()
		{
			num++;
		}
	}
}
