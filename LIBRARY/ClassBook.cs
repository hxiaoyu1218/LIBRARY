using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Data.Common;

namespace LIBRARY
{
	/// <summary>
	/// 书籍类
	/// </summary>
	public class ClassBook
	{
		#region PrivateProperty
		private string bookName;
		private string bookIsbn;//书籍号，不带扩展
		private string bookPublisher;
		private string bookAuthor;
		private byte[] bookImage;
		private string bookIntroduction;
		private DateTime bookPublishTime;
		private int bookAmount;
		private string[] bookLable;
		private List<ClassABook> books;
		private LinkedList<string> scheduleQueue;
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
		/// 书号，不带扩展
		/// </summary>
		public string BookIsbn
		{
			get
			{
				return bookIsbn;
			}

			internal set
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
		/// 作者
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
		/// 书籍封面文件地址
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
		/// 简介
		/// </summary>
		public string BookIntroduction
		{
			get
			{
				return bookIntroduction;
			}

			set
			{
				bookIntroduction = value;
			}
		}

		/// <summary>
		/// 书籍数量
		/// </summary>
		public int BookAmount
		{
			get
			{
				return bookAmount;
			}

			internal set
			{
				bookAmount = value;
			}
		}

		/// <summary>
		/// 每一本书
		/// </summary>
		public List<ClassABook> Book
		{
			get
			{
				return books;
			}
		}

		/// <summary>
		/// 书籍标签第一个
		/// </summary>
		public string BookLable1
		{
			get
			{
				return bookLable[0];
			}

			set
			{
				bookLable[0] = value;
			}
		}

		/// <summary>
		/// 书籍标签第二个
		/// </summary>
		public string BookLable2
		{
			get
			{
				return bookLable[1];
			}

			set
			{
				bookLable[1] = value;
			}
		}

		/// <summary>
		/// 书籍标签第三个
		/// </summary>
		public string BookLable3
		{
			get
			{
				return bookLable[2];
			}

			set
			{
				bookLable[2] = value;
			}
		}

		public DateTime BookPublishTime
		{
			get
			{
				return bookPublishTime;
			}

			set
			{
				bookPublishTime = value;
			}
		}

		#endregion

		#region PrivateMethod

		/// <summary>
		/// 写入历史文件
		/// </summary>
		/// <param name="bookid">书籍编号，带扩展编号</param>
		/// <param name="bh"></param>
		/// <returns>成功/失败</returns>
		//private bool UpdateHistory(string bookid, ClassBookHis bh)
		//{
		//	FileStream fs = null; StreamWriter sw = null;
		//	string bookhisfile = ClassBackEnd.BookHisDirectory + bookid + ".his";
		//	try
		//	{
		//		if (!File.Exists(bookhisfile))
		//		{
		//			fs = File.Create(bookhisfile);
		//			sw = new StreamWriter(fs);
		//		}
		//		else
		//		{
		//			fs = new FileStream(bookhisfile, FileMode.Append);
		//			sw = new StreamWriter(fs);
		//		}
		//		bh.SaveToFile(sw);
		//		return true;

		//	}
		//	catch (Exception e) { return false; }
		//	finally
		//	{
		//		if (sw != null) sw.Close();
		//		if (fs != null) fs.Close();
		//	}
		//}

		#endregion

		#region PublicMethod
		/// <summary>
		/// 构造函数 构造时 名字 isbn 数量 购入时间 不能为空 其余可以
		/// 生成历史文件
		/// </summary>
		/// <param name="bookName">书名</param>
		/// <param name="bookIsbn">书号</param>
		/// <param name="bookAmount">书的数量</param>
		/// <param name="broughtTime">购入时间</param>
		/// <param name="bookPublisher">出版社</param>
		/// <param name="bookAuthor">作者</param>
		/// <param name="bookIntroduction">简介</param>
		/// <param name="bookImage">书籍封面地址</param>
		/// <param name="adminId">管理员id</param>
		/// <param name="bookLable1">标签1</param>
		/// <param name="bookLable2">标签2</param>
		/// <param name="bookLable3">标签3</param>
		internal ClassBook(string bookName, string bookIsbn, int bookAmount, DateTime broughtTime, DateTime publishTime, string adminId, string bookLable1, string bookLable2, string bookLable3, string bookPublisher, string bookAuthor, byte[] bookImage, string bookIntroduction)
		{
			this.bookName = bookName;
			this.bookIsbn = bookIsbn;
			this.bookPublisher = bookPublisher;
			this.bookAuthor = bookAuthor;
			this.bookImage = bookImage;
			this.bookIntroduction = bookIntroduction;
			this.bookAmount = bookAmount;
			this.bookPublishTime = publishTime;
			this.bookLable = new string[3] { bookLable1, bookLable2, bookLable3 };

			this.books = new List<ClassABook>();
			this.scheduleQueue = new LinkedList<string>();


			for (int i = 0; i < BookAmount; i++)
			{
				Book.Add(new ClassABook(bookName, bookIsbn + i.ToString("D4"), bookPublisher, bookAuthor, bookImage, publishTime, broughtTime));
				//UpdateHistory(Book.Last().BookIsbn, new ClassBookHis(broughtTime, adminId, 0));
			}
		}
        public ClassBook(string bookName,string bookIsbn,string bookAuthor,string bookPublisher)
        {
            this.bookName = bookName;
            this.bookIsbn = bookIsbn;
            this.bookAuthor = bookAuthor;
            this.bookPublisher = bookPublisher;
        }
		public ClassBook(DbDataReader dr)
		{
			this.bookName = dr["bookName"].ToString();
			this.bookIsbn = dr["bookIsbn"].ToString();
			this.bookPublisher = dr["bookPublisher"].ToString();
			this.bookAuthor = dr["bookAuthor"].ToString();
			this.bookImage = (byte[])dr["bookImage"];
			this.bookIntroduction = dr["bookIntroduction"].ToString();
			this.BookPublishTime = (DateTime)dr["bookPublishTime"];
			this.bookAmount = Convert.ToInt32(dr["bookAmount"]);
			this.bookLable = new string[3];
			this.BookLable1 = dr["bookLable1"].ToString();
			this.BookLable2 = dr["bookLable2"].ToString();
			this.BookLable3 = dr["bookLable3"].ToString();
		}
		#endregion




		//	/// <summary>
		//	/// 从文件构造类classbook，只载入基本信息
		//	/// </summary>
		//	/// <param name="sr">StreamReader</param>
		//	internal ClassBook(StreamReader sr)
		//	{
		//		BookIsbn = sr.ReadLine();
		//		BookName = sr.ReadLine();
		//		BookPublisher = sr.ReadLine();
		//		BookAuthor = sr.ReadLine();
		//		BookLable1 = sr.ReadLine();
		//		BookLable2 = sr.ReadLine();
		//		BookLable3 = sr.ReadLine();
		//	}
		//	/// <summary>
		//	/// 载入详细信息，如果没有载入基本信息，会返回false
		//	/// </summary>
		//	internal bool LoadDetailInformation()
		//	{
		//		books.Clear();
		//		scheduleQueue.Clear();

		//		if (BookIsbn == "") return false;
		//		FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
		//		fs = new FileStream(ClassBackEnd.BookDirectory + BookIsbn + ".lbs", FileMode.Open);
		//		zip = new GZipStream(fs, CompressionMode.Decompress);
		//		sr = new StreamReader(zip);
		//		BookIsbn = sr.ReadLine();
		//		BookName = sr.ReadLine();
		//		BookPublisher = sr.ReadLine();
		//		BookAuthor = sr.ReadLine();
		//		BookLable1 = sr.ReadLine();
		//		BookLable2 = sr.ReadLine();
		//		BookLable3 = sr.ReadLine();
		//		BookImage = sr.ReadLine();
		//		var a = Convert.ToInt32(sr.ReadLine());

		//		BookIntroduction = "";
		//		while (a-- > 0)
		//		{
		//			bookIntroduction += sr.ReadLine();
		//			if (a != 0) bookIntroduction += "\r\n";
		//		}

		//		BookAmount = Convert.ToInt32(sr.ReadLine());

		//		var count = Convert.ToInt32(sr.ReadLine());//each list amount
		//		for (int i = 0; i < count; i++) //load bookstate list
		//		{
		//			Book.Add(new ABook(sr));
		//		}

		//		count = Convert.ToInt32(sr.ReadLine());
		//		for (int i = 0; i < count; i++) //load schedulequeue list
		//		{
		//			scheduleQueue.AddLast(sr.ReadLine());
		//		}
		//		if (sr != null) sr.Close();
		//		if (zip != null) zip.Close();
		//		if (fs != null) fs.Close();
		//		return true;
		//	}
		//	/// <summary>
		//	///  载入详细信息，无需提前载入基本信息
		//	/// </summary>
		//	/// <param name="bookisbn">书籍编号</param>
		//	/// <returns></returns>
		//	public ClassBook(string bookisbn)
		//	{
		//		FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
		//		try
		//		{
		//			fs = new FileStream(ClassBackEnd.BookDirectory + bookisbn + ".lbs", FileMode.Open);
		//			zip = new GZipStream(fs, CompressionMode.Decompress);
		//			sr = new StreamReader(zip);

		//			BookIsbn = sr.ReadLine();
		//			BookName = sr.ReadLine();
		//			BookPublisher = sr.ReadLine();
		//			BookAuthor = sr.ReadLine();
		//			BookLable1 = sr.ReadLine();
		//			BookLable2 = sr.ReadLine();
		//			BookLable3 = sr.ReadLine();
		//			BookImage = sr.ReadLine();

		//			var a = Convert.ToInt32(sr.ReadLine());

		//			BookIntroduction = "";
		//			while (a-- > 0)
		//			{
		//				bookIntroduction += sr.ReadLine();
		//				if (a != 0) bookIntroduction += "\r\n";
		//			}

		//			BookAmount = Convert.ToInt32(sr.ReadLine());

		//			var count = Convert.ToInt32(sr.ReadLine());//each list amount
		//			for (int i = 0; i < count; i++) //load bookstate list
		//			{
		//				Book.Add(new ABook(sr));
		//			}

		//			count = Convert.ToInt32(sr.ReadLine());
		//			for (int i = 0; i < count; i++) //load schedulequeue list
		//			{
		//				scheduleQueue.AddLast(sr.ReadLine());
		//			}
		//		}
		//		catch (Exception e) { return; }
		//		finally
		//		{
		//			if (sr != null) sr.Close();
		//			if (zip != null) zip.Close();
		//			if (fs != null) fs.Close();
		//		}
		//	}



		//	/// <summary>
		//	/// 将类classbook存入文件中,并且覆盖源文件
		//	/// </summary>
		//	/// <param name="path">文件路径</param>
		//	/// <returns>存储成功返回true</returns>
		//	internal bool SaveDetailInformation(string path)
		//	{
		//		path = path + BookIsbn + ".lbs";
		//		FileStream fs = null; GZipStream zip = null; StreamWriter sw = null;

		//		fs = new FileStream(path, FileMode.Create, FileAccess.Write);
		//		zip = new GZipStream(fs, CompressionMode.Compress);
		//		sw = new StreamWriter(zip);
		//		sw.WriteLine(BookIsbn);
		//		sw.WriteLine(BookName);
		//		sw.WriteLine(BookPublisher);
		//		sw.WriteLine(BookAuthor);
		//		sw.WriteLine(BookLable1);
		//		sw.WriteLine(BookLable2);
		//		sw.WriteLine(BookLable3);
		//		sw.WriteLine(BookImage);
		//		int tmp = 1;
		//		for (int i = 0; i < bookIntroduction.Length; i++)
		//		{
		//			if (bookIntroduction[i] == '\n')
		//				tmp++;
		//		}
		//		sw.WriteLine(tmp);
		//		sw.WriteLine(BookIntroduction);
		//		sw.WriteLine(BookAmount.ToString());

		//		sw.WriteLine(Book.Count.ToString());
		//		foreach (var a in Book)
		//		{
		//			a.SaveToFile(sw);
		//		}

		//		sw.WriteLine(scheduleQueue.Count.ToString());
		//		foreach (var tt in scheduleQueue)
		//		{
		//			sw.WriteLine(tt);
		//		}


		//		if (sw != null) sw.Close();
		//		if (zip != null) zip.Close();
		//		if (fs != null) fs.Close();
		//		return true;
		//	}
		//	/// <summary>
		//	/// 储存基本信息
		//	/// </summary>
		//	/// <param name="sw">StreamWriter</param>
		//	internal void SaveBasicInformation(StreamWriter sw)
		//	{
		//		sw.WriteLine(BookIsbn);
		//		sw.WriteLine(BookName);
		//		sw.WriteLine(BookPublisher);
		//		sw.WriteLine(BookAuthor);
		//		sw.WriteLine(BookLable1);
		//		sw.WriteLine(BookLable2);
		//		sw.WriteLine(BookLable3);

		//	}
		//	/// <summary>
		//	/// 添加书的数量
		//	/// </summary>
		//	/// <param name="n">数量</param>
		//	/// <param name="time">购入时间</param>
		//	/// <param name="_adminid">管理员ID</param>
		//	internal void AddBook(int n, DateTime time, string _adminid)
		//	{
		//		int oldamount = Book.Count;
		//		BookAmount += n;

		//		int lastisbn = Convert.ToInt32((Book.Last().Extisbn).Substring(10, 4));
		//		for (int i = 0; i < n; i++)
		//		{
		//			lastisbn++;
		//			Book.Add(new ABook(BOOKSTATE.Available, "", time, BookIsbn + lastisbn.ToString("D4")));
		//			UpdateHistory(Book.Last().Extisbn, new ClassBookHis(time, _adminid, 0));
		//		}

		//		//通知预约者
		//		for (int i = oldamount; i < BookAmount; i++)
		//		{
		//			InformToScheduler(i);
		//		}
		//	}
		//	/// <summary>
		//	/// 减少书的数量
		//	/// </summary>
		//	/// <param name="n">数量</param>
		//	/// <returns>成功返回1，失败(有书正在被借)返回0</returns>
		//	internal bool DeleteBook(int n)
		//	{
		//		int tt = 0;
		//		for (int i = 0; i < BookAmount; i++)
		//		{
		//			if (Book[i].Bookstate == BOOKSTATE.Available)
		//			{
		//				tt++;
		//			}
		//		}
		//		if (tt < n) return false;
		//		else
		//		{
		//			for (int i = BookAmount - 1; i >= 0; i--)
		//			{
		//				if (Book[i].Bookstate == BOOKSTATE.Available)
		//				{
		//					Book.RemoveAt(i);
		//				}
		//			}
		//			BookAmount -= n;
		//			return true;
		//		}
		//	}
		//	/// <summary>
		//	/// 返回一个可借的书的序号，优先返回该用户已经预约的书
		//	/// </summary>
		//	/// <returns>序号</returns>
		//	internal int GetAnAvailableBook(string id)
		//	{
		//		for (int i = 0; i < BookAmount; i++)
		//		{
		//			if (Book[i].Bookstate == BOOKSTATE.Scheduled && Book[i].Borrowuserid == id) return i;
		//		}
		//		for (int i = 0; i < BookAmount; i++)
		//		{
		//			if (Book[i].Bookstate == BOOKSTATE.Available) return i;
		//		}
		//		return -1;
		//	}
		//	/// <summary>
		//	/// 当预约人数到达可用书籍的2倍时，该书籍不可预约
		//	/// </summary>
		//	/// <returns>可以/不可以</returns>
		//	internal bool Scheduleable()
		//	{
		//		int k = 0;
		//		for (int i = 0; i < books.Count; i++)
		//		{
		//			if (books[i].Bookstate != BOOKSTATE.Unavailable)
		//				k++;
		//		}
		//		int sch = scheduleQueue.Count;
		//		if (sch > 2 * k) return false;
		//		else return true;
		//	}
		//	/// <summary>
		//	/// 借书
		//	/// </summary>
		//	/// <param name="n">书在数组的序号</param>
		//	/// <param name="userid">用户id</param>
		//	/// <returns>成功返回1，失败(n越界)返回0</returns>
		//	internal bool BorrowBook(int n, string userid)
		//	{
		//		if (n < 0 || n >= BookAmount) return false;

		//		if (Book[n].Bookstate == BOOKSTATE.Available ||
		//			(Book[n].Bookstate == BOOKSTATE.Scheduled && Book[n].Borrowuserid == userid))
		//		{
		//			Book[n].Bookstate = BOOKSTATE.Borrowed;
		//			Book[n].Borrowuserid = userid;
		//			UpdateHistory(Book[n].Extisbn, new ClassBookHis(ClassTime.systemTime, userid, 1));
		//			return true;
		//		}
		//		return false;

		//	}
		//	/// <summary>
		//	/// 将人添加到预约队列
		//	/// </summary>
		//	/// <param name="userid">用户id</param>
		//	/// <returns></returns>
		//	internal void ScheduleBook(string userid)
		//	{
		//		scheduleQueue.AddLast(userid);
		//	}
		//	/// <summary>
		//	/// 还书
		//	/// </summary>
		//	/// <param name="userid">用户id</param>
		//	/// <returns>成功返回1失败返回0</returns>
		//	internal bool ReturnBook(string userid)
		//	{
		//		int id = -1;
		//		for (int i = 0; i < BookAmount; i++)
		//			if (Book[i].Borrowuserid == userid)
		//			{
		//				id = i;
		//				break;
		//			}
		//		if (id == -1) return false;
		//		Book[id].Bookstate = BOOKSTATE.Available;
		//		Book[id].Borrowuserid = "";

		//		UpdateHistory(Book[id].Extisbn, new ClassBookHis(ClassTime.systemTime, userid, 2));

		//		InformToScheduler(id);
		//		return true;
		//	}
		//	/// <summary>
		//	/// 将还的书分配给预约人
		//	/// </summary>
		//	/// <param name="bookid"></param>
		//	/// <returns></returns>
		//	private bool InformToScheduler(int bookid)
		//	{
		//		if (scheduleQueue.Any())
		//		{
		//			Book[bookid].Bookstate = BOOKSTATE.Scheduled;
		//			string ss = scheduleQueue.First();
		//			scheduleQueue.RemoveFirst();
		//			Book[bookid].Borrowuserid = ss;

		//			UpdateHistory(Book[bookid].Extisbn, new ClassBookHis(ClassTime.systemTime, ss, 3));

		//			//通知预约者，写入文件
		//			ClassUser us = new ClassUser("", ss, "", "", USERTYPE.Guest);
		//			us.ReadDetailInformation(ClassBackEnd.UserDetailDictory);
		//			us.bookget(BookIsbn);
		//			us.SaveDetailInformation(ClassBackEnd.UserDetailDictory);

		//			return true;
		//		}
		//		return false;
		//	}
		//	/// <summary>
		//	/// 取预约书
		//	/// </summary>
		//	/// <param name="userid">用户id</param>
		//	/// <returns>成功返回1，失败(没找到用户的预约)返回0</returns>
		//	internal bool GetScheduledBook(string userid)
		//	{
		//		for (int i = 0; i < BookAmount; i++)
		//		{
		//			if (Book[i].Borrowuserid == userid && Book[i].Bookstate == BOOKSTATE.Scheduled)
		//			{
		//				Book[i].Bookstate = BOOKSTATE.Borrowed;
		//				UpdateHistory(Book[i].Extisbn, new ClassBookHis(ClassTime.systemTime, userid, 1));
		//				return true;
		//			}
		//		}
		//		return false;
		//	}
		//	/// <summary>
		//	/// 取消预约
		//	/// </summary>
		//	/// <param name="userid">用户id</param>
		//	/// <returns>成功返回1，失败(没找到该用户的预约)返回0</returns>
		//	internal bool CancelScheduleBook(string userid)
		//	{
		//		for (int i = 0; i < BookAmount; i++)
		//		{
		//			if (Book[i].Bookstate == BOOKSTATE.Scheduled)
		//				if (Book[i].Borrowuserid == userid)
		//				{
		//					Book[i].Borrowuserid = "";
		//					scheduleQueue.Remove(userid);
		//					UpdateHistory(Book[i].Extisbn, new ClassBookHis(ClassTime.systemTime, userid, 4));

		//					if (!InformToScheduler(i))
		//					{
		//						Book[i].Bookstate = BOOKSTATE.Available;
		//					}
		//					return true;
		//				}
		//		}
		//		return scheduleQueue.Remove(userid);
		//	}
		//	/// <summary>
		//	/// 获取扩展isbn号
		//	/// </summary>
		//	/// <param name="i">book数组中第i个</param>
		//	/// <returns>扩展isbn号</returns>
		//	internal string GetExIsbn(int i)
		//	{
		//		return Book[i].Extisbn;
		//	}
		//	/// <summary>
		//	/// 修改书籍状态
		//	/// </summary>
		//	/// <param name="state">状态数组，保证长度为书籍数量</param>
		//	/// <param name="Id">管理员Id</param>
		//	/// <returns>成功/失败</returns>
		//	internal bool ChangeBookState(List<BOOKSTATE> state, string Id)
		//	{
		//		if (state.Count != Book.Count) return false;
		//		for (int i = 0; i < Book.Count; i++)
		//		{
		//			if (state[i] == BOOKSTATE.Unavailable && books[i].Bookstate != BOOKSTATE.Borrowed)
		//			{

		//				if (books[i].Bookstate == BOOKSTATE.Scheduled)
		//				{
		//					scheduleQueue.AddFirst(books[i].Borrowuserid);
		//					UpdateHistory(books[i].Extisbn, new ClassBookHis(ClassTime.systemTime, books[i].Borrowuserid, 4));
		//					ClassUser tmp = new ClassUser(books[i].Borrowuserid);
		//					tmp.ReadDetailInformation(ClassBackEnd.UserDetailDictory);
		//					tmp.MaintainSheduleBook(books[i].Extisbn);
		//					tmp.SaveDetailInformation(ClassBackEnd.UserDetailDictory);

		//				}
		//				if (books[i].Bookstate != BOOKSTATE.Unavailable)
		//				{
		//					books[i].Bookstate = BOOKSTATE.Unavailable;
		//					UpdateHistory(books[i].Extisbn, new ClassBookHis(ClassTime.systemTime, Id, 5));
		//				}


		//			}
		//		}
		//		for (int i = 0; i < Book.Count; i++)
		//		{
		//			if (books[i].Bookstate == BOOKSTATE.Unavailable && state[i] == BOOKSTATE.Available)
		//			{
		//				books[i].Bookstate = BOOKSTATE.Available;
		//				UpdateHistory(books[i].Extisbn, new ClassBookHis(ClassTime.systemTime, Id, 6));
		//				InformToScheduler(i);
		//			}
		//			if (books[i].Bookstate == BOOKSTATE.Available)
		//			{
		//				InformToScheduler(i);
		//			}
		//		}

		//		return SaveDetailInformation(ClassBackEnd.BookDirectory);
		//	}
		//	/// <summary>
		//	/// 获取书籍状态
		//	/// </summary>
		//	/// <param name="state">状态数组，函数内部会清空state</param>
		//	internal void GetBookState(ref List<BOOKSTATE> state)
		//	{
		//		state.Clear();
		//		foreach (ABook tmp in books)
		//		{
		//			state.Add(tmp.Bookstate);
		//		}
		//	}
		//	internal bool DelBook()
		//	{
		//		foreach (ABook tmp in books)
		//		{
		//			if (tmp.Bookstate != BOOKSTATE.Unavailable)
		//			{
		//				return false;
		//			}
		//		}
		//		foreach (string person in scheduleQueue)
		//		{
		//			ClassUser tmp = new ClassUser(person);
		//			tmp.deletebook(this.BookIsbn);
		//			tmp.SaveDetailInformation(ClassBackEnd.UserDetailDictory);
		//		}
		//		return true;
		//	}
	}
}
