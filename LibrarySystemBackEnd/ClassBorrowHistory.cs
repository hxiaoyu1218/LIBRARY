using System;
using System.IO;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 用户借阅历史用的类
	/// </summary>
	public class ClassBorrowHistory
	{
		/// <summary>
		/// 书名
		/// </summary>
		private string bookname;
		/// <summary>
		/// 书籍编号
		/// </summary>
		private string bookisbn;
		/// <summary>
		/// 借阅时间
		/// </summary>
		private DateTime borrowdata;
		/// <summary>
		/// 归还时间
		/// </summary>
		private DateTime returndata;

		/// <summary>
		/// 书名
		/// </summary>
		public string Bookname
		{
			get
			{
				return bookname;
			}

			internal set
			{
				bookname = value;
			}
		}
		/// <summary>
		/// 书籍编号
		/// </summary>
		public string Bookisbn
		{
			get
			{
				return bookisbn;
			}

			internal set
			{
				bookisbn = value;
			}
		}
		/// <summary>
		/// 借阅时间
		/// </summary>
		public string Borrowdata
		{
			get
			{
				var a = borrowdata.Year.ToString("D4");
				var b = borrowdata.Month.ToString("D2");
				var c = borrowdata.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
			
		}
		/// <summary>
		/// 归还时间
		/// </summary>
		public string Returndata
		{
			get
			{
				var a = returndata.Year.ToString("D4");
				var b = returndata.Month.ToString("D2");
				var c = returndata.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
			
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_bookname">书名</param>
		/// <param name="_bookisbn">书籍编号</param>
		/// <param name="_borrowdata">借阅日期</param>
		/// <param name="_returndata">归还日期</param>
		internal ClassBorrowHistory(string _bookname, string _bookisbn, DateTime _borrowdata, DateTime _returndata)
		{
			Bookname = _bookname;
			Bookisbn = _bookisbn;
			borrowdata = _borrowdata;
			returndata = _returndata;
		}
		/// <summary>
		/// 从文件的构造函数
		/// </summary>
		/// <param name="sr">StreamReader</param>
		internal ClassBorrowHistory(StreamReader sr)
		{
			Bookname = sr.ReadLine();
			Bookisbn = sr.ReadLine();
			borrowdata = Convert.ToDateTime(sr.ReadLine());
			returndata = Convert.ToDateTime(sr.ReadLine());
		}
		/// <summary>
		/// 写入文件函数
		/// </summary>
		/// <param name="sw">StreamWriter</param>
		internal void SaveToFile(StreamWriter sw)
		{
			sw.WriteLine(Bookname);
			sw.WriteLine(Bookisbn);
			sw.WriteLine(borrowdata.ToString());
			sw.WriteLine(returndata.ToString());
		}
	}
}
