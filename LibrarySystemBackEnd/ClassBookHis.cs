using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 书籍历史记录类
	/// </summary>
	public class ClassBookHis
	{
		private string bookid;
		private DateTime time;
		private string userid;
		// 操作种类：0表示购入，1表示借阅，
		//			2表示归还，3表示预约，4表示取消预约，
		//			5表示管理员取走维护，6表示维护结束
		private int cat;

		/// <summary>
		/// 书籍ID，扩展ISBN
		/// </summary>
		public string Bookid
		{
			get
			{
				return bookid;
			}

			internal set
			{
				bookid = value;
			}
		}
		/// <summary>
		/// 操作发生时间
		/// </summary>
		public string Time
		{
			get
			{
				var a = time.Year.ToString("D4");
				var b = time.Month.ToString("D2");
				var c = time.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
		}
		/// <summary>
		/// 与操作相关的用户ID
		/// </summary>
		public string Userid
		{
			get
			{
				if(userid == "0000000000") return "管理员";
				return userid;
			}

			internal set
			{
				userid = value;
			}
		}

		/// <summary>
		/// 操作种类号
		/// 操作种类：0表示购入，1表示借阅，2表示归还，3表示预约，4表示取消预约，
		/// 5表示管理员取走维护，6表示维护结束
		/// </summary>
		public string Cat
		{
			get
			{
				if(cat == 0) return "购入";
				else if(cat == 1) return "借阅";
				else if(cat == 2) return "归还";
				else if(cat == 3) return "预约";
				else if(cat == 4) return "取消预约";
				else if(cat == 5) return "维护";
				else if(cat == 6) return "结束维护";
				else return "其他";
			}

		}


		/// <summary>
		/// 普通构造
		/// </summary>
		/// <param name="_time">操作发生时间</param>
		/// <param name="_userid">与操作相关的用户ID</param>
		/// <param name="_cat">操作种类：0表示购入，1表示借阅，2表示归还，3表示预约，4表示取消预约，5表示管理员取走维护，6表示维护结束</param>
		internal ClassBookHis(DateTime _time, string _userid, int _cat)
		{
			time = _time;
			userid = _userid;
			cat = _cat;
		}
		/// <summary>
		/// 文件构造
		/// </summary>
		/// <param name="sr">StreamReader</param>
		internal ClassBookHis(StreamReader sr)
		{
			cat = Convert.ToInt32(sr.ReadLine());
			time = Convert.ToDateTime(sr.ReadLine());
			userid = sr.ReadLine();
		}
		/// <summary>
		/// 写入文件
		/// </summary>
		/// <param name="sw">StreamWriter</param>
		internal void SaveToFile(StreamWriter sw)
		{
			sw.WriteLine(cat);
			sw.WriteLine(time.ToString());
			sw.WriteLine(userid);
		}
	}
}
