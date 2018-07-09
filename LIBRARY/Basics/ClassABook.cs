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
		private string bookImage;
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
		public string BookImage
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
