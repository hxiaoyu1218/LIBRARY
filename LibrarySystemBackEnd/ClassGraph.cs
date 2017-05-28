using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 生成图表用的类
	/// </summary>
	public class ClassGraph
	{
		private DateTime date;
		private int userComing;
		private double lendingRate;
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime Date
		{
			get
			{
				return date;
			}
		}
		/// <summary>
		/// 用户到馆数
		/// </summary>
		public int UserComing
		{
			get
			{
				return userComing;
			}
		}
		/// <summary>
		/// 借阅率
		/// </summary>
		public double LendingRate
		{
			get
			{
				return lendingRate;
			}
		}

		internal ClassGraph(StreamReader sr)
		{
			date = Convert.ToDateTime(sr.ReadLine());
			userComing = Convert.ToInt32(sr.ReadLine());
			lendingRate = Convert.ToDouble(sr.ReadLine());
		}
	}
}
