using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
	/// <summary>
	/// 书籍状态 可借，已借，预约，不可用
	/// </summary>
	public enum Bookstate
	{
		/// <summary>
		/// 可用，可借
		/// </summary>
		Available,
		/// <summary>
		/// 已被借阅
		/// </summary>
		Borrowed,
		/// <summary>
		/// 已被预约，等待取书
		/// </summary>
		Scheduled,
		/// <summary>
		/// 不可用
		/// </summary>
		Unavailable
	};

	/// <summary>
	/// 单一的一本书
	/// </summary>
	public class ClassABook
	{
		#region PrivateProperty

		private string bookName;
		private string bookIsbn;// 完整的isbn
		private string bookPublisher;
		private string bookAuthor;
		private byte[] bookImage;
		private DateTime bookPublishDate;
		private DateTime bookBroughtTime;// 购买时间
		private Bookstate bookState;// 书籍状态
		private string borrowUserId;// 借阅的用户id，没人借就是空
		private DateTime borrowTime;
		private DateTime returnTime;
		private bool delayed;//是否已续借
		private bool deleted;//书籍是否已被删除

		#endregion

		#region 访问器
		/// <summary>
		/// 书名
		/// </summary>
		public string BookName
		{
			get
			{
				return bookName;
			}

			set
			{
				bookName = value;
			}
		}

		/// <summary>
		/// ISBN，带扩展的书号
		/// </summary>
		public string BookIsbn
		{
			get
			{
				return bookIsbn;
			}

			set
			{
				bookIsbn = value;
			}
		}

		/// <summary>
		/// 出版社
		/// </summary>
		public string BookPublisher
		{
			get
			{
				return bookPublisher;
			}

			set
			{
				bookPublisher = value;
			}
		}

		/// <summary>
		/// 书籍作者
		/// </summary>
		public string BookAuthor
		{
			get
			{
				return bookAuthor;
			}

			set
			{
				bookAuthor = value;
			}
		}

		/// <summary>
		/// 书籍图片地址
		/// </summary>
		public byte[] BookImage
		{
			get
			{
				return bookImage;
			}

			set
			{
				bookImage = value;
			}
		}

		/// <summary>
		/// 书籍购入时间
		/// </summary>
		public DateTime BookBroughtTime
		{
			get
			{
				return bookBroughtTime;
			}

			set
			{
				bookBroughtTime = value;
			}
		}

		/// <summary>
		/// 书籍状态
		/// </summary>
		public Bookstate BookState
		{
			get
			{
				return bookState;
			}

			set
			{
				bookState = value;
			}
		}

		/// <summary>
		/// 书籍的借阅者或预约者，不存在即为空
		/// </summary>
		public string BorrowUserId
		{
			get
			{
				return borrowUserId;
			}

			set
			{
				borrowUserId = value;
			}
		}

		/// <summary>
		/// 书籍的借出时间，不存在即为空
		/// </summary>
		public DateTime BorrowTime
		{
			get
			{
				return borrowTime;
			}

			set
			{
				borrowTime = value;
			}
		}

		/// <summary>
		/// 书籍的应归还时间，不存在即为空
		/// </summary>
		public DateTime ReturnTime
		{
			get
			{
				return returnTime;
			}

			set
			{
				returnTime = value;
			}
		}

		/// <summary>
		/// 书籍是否已被续借
		/// </summary>
		public bool Delayed
		{
			get
			{
				return delayed;
			}

			set
			{
				delayed = value;
			}
		}

		/// <summary>
		/// 书籍是否已被管理员回收
		/// </summary>
		public bool Deleted
		{
			get
			{
				return deleted;
			}

			set
			{
				deleted = value;
			}
		}

		public DateTime BookPublishDate
		{
			get
			{
				return bookPublishDate;
			}

			set
			{
				bookPublishDate = value;
			}
		}

		#endregion

		///// <summary>
		///// 写入文件函数
		///// </summary>
		///// <param name="sw">streamwriter类型</param>
		//internal void SaveToFile(StreamWriter sw)
		//{
		//	sw.WriteLine(Convert.ToInt32(Bookstate));
		//	sw.WriteLine(Borrowuserid);
		//	sw.WriteLine(BroughtTime.ToString());
		//	sw.WriteLine(Extisbn);
		//}
		///// <summary>
		///// 从文件的构造函数
		///// </summary>
		///// <param name="sr">streamreader类型</param>
		//internal ABook(StreamReader sr)
		//{
		//	Bookstate = (BOOKSTATE)(System.Enum.Parse(typeof(BOOKSTATE), Convert.ToInt16(sr.ReadLine()).ToString()));
		//	Borrowuserid = sr.ReadLine();
		//	BroughtTime = Convert.ToDateTime(sr.ReadLine());
		//	Extisbn = sr.ReadLine();
		//}

		/// <summary>
		/// 完整的构造函数
		/// </summary>
		/// <param name="bookName">书名</param>
		/// <param name="bookIsbn">完整ISBN</param>
		/// <param name="bookPublisher">出版社</param>
		/// <param name="bookAuthor">作者</param>
		/// <param name="bookImage">图片地址</param>
		/// <param name="bookPublishDate">出版日期</param>
		/// <param name="broughtTime">购买时间</param>
		/// <param name="bookState">书籍状态</param>
		/// <param name="borrowUserId">借阅用户ID</param>
		/// <param name="borrowTime">借出时间</param>
		/// <param name="returnTime">应归还时间</param>
		/// <param name="delayed">是否已续借</param>
		/// <param name="deleted">是否已被管理员回收</param>
		public ClassABook(string bookName, string bookIsbn, string bookPublisher, string bookAuthor, byte[] bookImage, DateTime bookPublishDate, DateTime broughtTime, Bookstate bookState, string borrowUserId, DateTime borrowTime, DateTime returnTime, bool delayed, bool deleted)
		{
			this.BookName = bookName;
			this.BookIsbn = bookIsbn;
			this.BookPublisher = bookPublisher;
			this.BookAuthor = bookAuthor;
			this.BookImage = bookImage;
			this.BookPublishDate = bookPublishDate;
			this.BookBroughtTime = broughtTime;
			this.BookState = bookState;
			this.BorrowUserId = borrowUserId;
			this.BorrowTime = borrowTime;
			this.ReturnTime = returnTime;
			this.Delayed = delayed;
			this.Deleted = deleted;
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="bookName">书名</param>
		/// <param name="bookIsbn">完整ISBN</param>
		/// <param name="bookPublisher">出版社</param>
		/// <param name="bookAuthor">作者</param>
		/// <param name="bookImage">图片地址</param>
		/// <param name="bookPublishDate">出版时间</param>
		/// <param name="broughtTime">购买时间</param>
		public ClassABook(string bookName, string bookIsbn, string bookPublisher, string bookAuthor, byte[] bookImage, DateTime bookPublishDate, DateTime broughtTime)
		{
			this.BookName = bookName;
			this.BookIsbn = bookIsbn;
			this.BookPublisher = bookPublisher;
			this.BookAuthor = bookAuthor;
			this.BookImage = bookImage;
			this.BookPublishDate = bookPublishDate;
			this.BookBroughtTime = broughtTime;

			this.BookState = Bookstate.Available;
			this.BorrowUserId = "";
			this.BorrowTime = DateTime.Now;
			this.ReturnTime = DateTime.Now;
			this.Delayed = false;
			this.Deleted = false;
		}

		internal ClassABook(DbDataReader dr)
		{
			this.BookName = dr["bookName"].ToString();
			this.BookIsbn = dr["bookIsbn"].ToString();
			this.BookPublisher = dr["bookPublisher"].ToString();
			this.BookAuthor = dr["bookAuthor"].ToString();
			this.BookImage = (byte[])dr["bookImage"];
			this.BookPublishDate = (DateTime)dr["bookPublishDate"];
			this.BookBroughtTime = (DateTime)dr["broughtTime"];

			this.BookState = (Bookstate)Enum.ToObject(typeof(Bookstate), dr["bookState"]);
			this.BorrowUserId = dr["borrowUserId"].ToString();
			this.BorrowTime = (DateTime)dr["borrowTime"];
			this.ReturnTime = (DateTime)dr["returnTime"];
			this.Delayed = (bool)dr["delayed"];
			this.Deleted = (bool)dr["deleted"];
		}
        public ClassABook(string isbn)
        {
            this.bookIsbn = isbn;
        }
		//public override string ToString()
		//{
  //          //return String.Format()
		//}
	}
}
