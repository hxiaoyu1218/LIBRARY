using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 日志类
	/// </summary>
	public class ClassLog
	{
		private DateTime date;
		private string user;
		private string inf;

		/// <summary>
		/// 日期
		/// </summary>
		public string Date
		{
			get
			{
				var a = date.Year.ToString("D4");
				var b = date.Month.ToString("D2");
				var c = date.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
		}
		/// <summary>
		/// 信息
		/// </summary>
		public string Inf
		{
			get
			{
				return inf;
			}
		}
		/// <summary>
		/// 用户
		/// </summary>
		public string User
		{
			get
			{
				return user;
			}
		}

		internal ClassLog(StreamReader sr)
		{
			date = Convert.ToDateTime(sr.ReadLine());
			user = sr.ReadLine();
			inf = sr.ReadLine();
		}

	}
}
