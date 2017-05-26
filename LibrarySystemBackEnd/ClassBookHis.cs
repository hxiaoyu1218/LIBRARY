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
		public DateTime Time
		{
			get
			{
				return time;
			}

			internal set
			{
				time = value;
			}
		}
		/// <summary>
		/// 与操作相关的用户ID
		/// </summary>
		public string Userid
		{
			get
			{
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
		public int Cat
		{
			get
			{
				return cat;
			}

			internal set
			{
				cat = value;
			}
		}


		/// <summary>
		/// 普通构造
		/// </summary>
		/// <param name="_time">操作发生时间</param>
		/// <param name="_userid">与操作相关的用户ID</param>
		/// <param name="_cat">操作种类：0表示购入，1表示借阅，2表示归还，3表示预约，4表示取消预约，5表示管理员取走维护，6表示维护结束</param>
		internal ClassBookHis(DateTime _time,string _userid,int _cat)
		{
			Time = _time;
			Userid = _userid;
			cat = _cat;
		}
		/// <summary>
		/// 文件构造
		/// </summary>
		/// <param name="sr">StreamReader</param>
		internal ClassBookHis(StreamReader sr)
		{
			Cat = Convert.ToInt32(sr.ReadLine());
			Time = Convert.ToDateTime(sr.ReadLine());
			Userid = sr.ReadLine();
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
