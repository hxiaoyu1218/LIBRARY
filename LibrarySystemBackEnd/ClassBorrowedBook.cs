using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 用户已借阅图书封装类
	/// </summary>
	public class ClassBorrowedBook
	{
		/// <summary>
		/// 借阅true，预约false
		/// </summary>
		private bool isborrowed;
		/// <summary>
		/// 书号
		/// </summary>
		private string bookisbn;
		/// <summary>
		/// 书名
		/// </summary>
		private string bookname;
		/// <summary>
		/// 借阅/预约日期
		/// </summary>
		private DateTime bsdate;
		/// <summary>
		/// 应还/最晚取书日期
		/// </summary>
		private DateTime rgdate;

		/// <summary>
		/// 借阅true，预约false
		/// </summary>
		public bool Isborrowed
		{
			get
			{
				return isborrowed;
			}

			internal set
			{
				isborrowed = value;
			}
		}
		/// <summary>
		/// 书号
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
		/// 借阅/预约日期
		/// </summary>
		public string Bsdate
		{
			get
			{
				var a = bsdate.Year.ToString("D4");
				var b = bsdate.Month.ToString("D2");
				var c = bsdate.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
			
		}
		/// <summary>
		/// 应还/最晚取书日期
		/// </summary>
		public string Rgdate
		{
			get
			{
				var a = rgdate.Year.ToString("D4");
				var b = rgdate.Month.ToString("D2");
				var c = rgdate.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_bookisbn">书号isbn</param>
		/// <param name="_bookname">书名</param>
		/// <param name="_bsdate">借/预约日期</param>
		/// <param name="_rgdate">应还日期</param>
		internal ClassBorrowedBook(string _bookisbn, string _bookname, DateTime _bsdate, DateTime _rgdate)
		{
			Bookisbn = _bookisbn;
			Bookname = _bookname;
			bsdate = _bsdate;
			rgdate = _rgdate;
		}
		internal ClassBorrowedBook(ClassBookAndDate bad,bool _isborrowed)
		{
			Bookisbn = bad.Bookisbn;
			Bookname = bad.Bookname;
			bsdate = bad.bsdate;
			rgdate = bad.rgdate;
			Isborrowed = _isborrowed;
		}
	}
}
