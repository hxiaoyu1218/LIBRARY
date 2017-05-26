using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 书籍状态 可借，已借，预约，不可用
	/// </summary>
	public enum BOOKSTATE
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
		Invailable
	};
	/// <summary>
	/// 单一的一本书
	/// </summary>
	public class ABook
	{
		#region PrivateProperty
		/// <summary>
		/// 书籍状态，BOOKSTATE类型
		/// </summary>
		private BOOKSTATE bookstate;
		/// <summary>
		/// 借阅的用户id，没人借就是空
		/// </summary>
		private string borrowuserid;
		/// <summary>
		/// 借阅时间，没人借就是空
		/// </summary>
		private DateTime broughttime;
		/// <summary>
		/// 完整的isbn
		/// </summary>
		private string extisbn;
		/// <summary>
		/// 书籍状态，BOOKSTATE类型
		/// </summary>
		public BOOKSTATE Bookstate
		{
			get
			{
				return bookstate;
			}

			internal set
			{
				bookstate = value;
			}
		}
		/// <summary>
		/// 借阅的用户id，没人借就是空
		/// </summary>
		public string Borrowuserid
		{
			get
			{
				return borrowuserid;
			}

			internal set
			{
				borrowuserid = value;
			}
		}
		/// <summary>
		/// 借阅时间，没人借就是空
		/// </summary>
		public string Broughttime
		{
			get
			{
				var a = broughttime.Year.ToString("D4");
				var b = broughttime.Month.ToString("D2");
				var c = broughttime.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}
		}
		/// <summary>
		/// 完整的isbn
		/// </summary>
		public string Extisbn
		{
			get
			{
				return extisbn;
			}

			internal set
			{
				extisbn = value;
			}
		}



		#endregion
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_bookstate">书籍状态，枚举类型</param>
		/// <param name="_borrowuserid">借书用户id，没借为空</param>
		/// <param name="_broughttime">结借书时间</param>
		/// <param name="_extisbn">完整的isbn</param>
		internal ABook(BOOKSTATE _bookstate, string _borrowuserid, DateTime _broughttime, string _extisbn)
		{
			Bookstate = _bookstate;
			Borrowuserid = _borrowuserid;
			broughttime = _broughttime;
			Extisbn = _extisbn;
		}
		/// <summary>
		/// 写入文件函数
		/// </summary>
		/// <param name="sw">streamwriter类型</param>
		internal void SaveToFile(StreamWriter sw)
		{
			sw.WriteLine(Convert.ToInt32(Bookstate));
			sw.WriteLine(Borrowuserid);
			sw.WriteLine(broughttime.ToString());
			sw.WriteLine(Extisbn);
		}
		/// <summary>
		/// 从文件的构造函数
		/// </summary>
		/// <param name="sr">streamreader类型</param>
		internal ABook(StreamReader sr)
		{
			Bookstate = (BOOKSTATE)(System.Enum.Parse(typeof(BOOKSTATE), Convert.ToInt16(sr.ReadLine()).ToString()));
			Borrowuserid = sr.ReadLine();
			broughttime = Convert.ToDateTime(sr.ReadLine());
			Extisbn = sr.ReadLine();
		}
	}

	/// <summary>
	/// 书籍类
	/// </summary>
	public class ClassBook
	{
		#region PrivateProperty
		/// <summary>
		/// 书名
		/// </summary>
		private string bookname;
		/// <summary>
		/// 书号，不带扩展
		/// </summary>
		private string bookisbn;
		/// <summary>
		/// 出版社
		/// </summary>
		private string publisher;
		/// <summary>
		/// 作者
		/// </summary>
		private string author;
		/// <summary>
		/// 书籍封面文件地址
		/// </summary>
		private string bookimage;
		/// <summary>
		/// 简介
		/// </summary>
		private string introduction;
		/// <summary>
		/// 书籍数量
		/// </summary>
		private int bookamount;
		private string[] booklable = new string[3];
		/// <summary>
		/// 每一本书
		/// </summary>
		private List<ABook> book = new List<ABook>();

		private LinkedList<string> schedulequeue = new LinkedList<string>();//预约队列

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
		/// 书号，不带扩展
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
		/// 出版社
		/// </summary>
		public string Publisher
		{
			get
			{
				return publisher;
			}

			internal set
			{
				publisher = value;
			}
		}
		/// <summary>
		/// 作者
		/// </summary>
		public string Author
		{
			get
			{
				return author;
			}

			internal set
			{
				author = value;
			}
		}
		/// <summary>
		/// 书籍封面文件地址
		/// </summary>
		public string Bookimage
		{
			get
			{
				return bookimage;
			}

			internal set
			{
				bookimage = value;
			}
		}
		/// <summary>
		/// 简介
		/// </summary>
		public string Introduction
		{
			get
			{
				return introduction;
			}

			internal set
			{
				introduction = value;
			}
		}
		/// <summary>
		/// 书籍数量
		/// </summary>
		public int Bookamount
		{
			get
			{
				return bookamount;
			}

			internal set
			{
				bookamount = value;
			}
		}
		/// <summary>
		/// 每一本书
		/// </summary>
		public List<ABook> Book
		{
			get
			{
				return book;
			}
		}
		/// <summary>
		/// 书籍标签第一个
		/// </summary>
		public string Booklable1
		{
			get
			{
				return booklable[0];
			}

			internal set
			{
				booklable[0] = value;
			}
		}
		/// <summary>
		/// 书籍标签第二个
		/// </summary>
		public string Booklable2
		{
			get
			{
				return booklable[1];
			}

			internal set
			{
				booklable[1] = value;
			}
		}
		/// <summary>
		/// 书籍标签第三个
		/// </summary>
		public string Booklable3
		{
			get
			{
				return booklable[2];
			}

			internal set
			{
				booklable[2] = value;
			}
		}

		#endregion

		#region PrivateMethod

		/// <summary>
		/// 写入历史文件
		/// </summary>
		/// <param name="bookid">书籍编号，带扩展编号</param>
		/// <param name="time">操作发生时间</param>
		/// <param name="userid">用户id</param>
		/// <param name="cat">操作种类，0表示购入，1表示借阅，2表示归还，3表示预约，4表示取消预约，5表示管理员取走维护，6表示维护结束</param>
		/// <returns>成功/失败</returns>
		private bool UpdateHistory(string bookid, DateTime time, string userid, int cat)
		{
			FileStream fs = null; StreamWriter sw = null;
			string bookhisfile = ClassBackEnd.BookHisDirectory + bookid + ".his";
			try
			{
				if(!File.Exists(bookhisfile))
				{
					fs = File.Create(bookhisfile);
					sw = new StreamWriter(fs);
				}
				else
				{
					fs = new FileStream(bookhisfile, FileMode.Append);
					sw = new StreamWriter(fs);
				}
				sw.WriteLine(cat);
				sw.WriteLine(time.ToString());
				sw.WriteLine(userid);
				return true;

			}
			catch(Exception e) { return false; }
			finally
			{
				if(sw != null) sw.Close();
				if(fs != null) fs.Close();
			}
		}

		#endregion

		#region PublicMethod
		/// <summary>
		/// 构造函数 构造时 名字 isbn 数量 购入时间 不能为空 其余可以
		/// 生成历史文件
		/// </summary>
		/// <param name="_name">书名</param>
		/// <param name="_isbn">书号</param>
		/// <param name="_amount">书的数量</param>
		/// <param name="_broughttime">购入时间</param>
		/// <param name="_publisher">出版社</param>
		/// <param name="_auther">作者</param>
		/// <param name="_introduction">简介</param>
		/// <param name="_bookimage">书籍封面地址</param>
		/// <param name="_adminid">管理员id</param>
		/// <param name="_lable1">标签1</param>
		/// <param name="_lable2">标签2</param>
		/// <param name="_lable3">标签3</param>
		internal ClassBook(string _name, string _isbn, int _amount, DateTime _broughttime, string _adminid, string _lable1, string _lable2, string _lable3, string _publisher = "", string _auther = "", string _bookimage = "", string _introduction = "")
		{
			Bookname = _name; Bookisbn = _isbn; Bookamount = _amount;
			Publisher = _publisher; Author = _auther; Introduction = _introduction; Bookimage = _bookimage; Booklable1 = _lable1; Booklable2 = _lable2; Booklable3 = _lable3;
			for(int i = 0;i < Bookamount;i++)
			{
				Book.Add(new ABook(BOOKSTATE.Available, "", _broughttime, _isbn + i.ToString("D4")));
				UpdateHistory(Book.Last().Extisbn.ToString(), _broughttime, _adminid, 0);
			}
		}
		/// <summary>
		/// 从文件构造类classbook，只载入基本信息
		/// </summary>
		/// <param name="sr">StreamReader</param>
		internal ClassBook(StreamReader sr)
		{
			Bookisbn = sr.ReadLine();
			Bookname = sr.ReadLine();
			Publisher = sr.ReadLine();
			Author = sr.ReadLine();
			Booklable1 = sr.ReadLine();
			Booklable2 = sr.ReadLine();
			Booklable3 = sr.ReadLine();
		}
		/// <summary>
		/// 载入详细信息，如果没有载入基本信息，会返回false
		/// </summary>
		internal bool LoadDetailInformation()
		{
			book.Clear();
			schedulequeue.Clear();

			if(Bookisbn == "") return false;
			FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
			fs = new FileStream(ClassBackEnd.BookDirectory + Bookisbn + ".lbs", FileMode.Open);
			zip = new GZipStream(fs, CompressionMode.Decompress);
			sr = new StreamReader(zip);
			Bookisbn = sr.ReadLine();
			Bookname = sr.ReadLine();
			Publisher = sr.ReadLine();
			Author = sr.ReadLine();
			Booklable1 = sr.ReadLine();
			Booklable2 = sr.ReadLine();
			Booklable3 = sr.ReadLine();
			Bookimage = sr.ReadLine();
			var a = Convert.ToInt32(sr.ReadLine());

			Introduction = "";
			while(a-- > 0)
			{
				introduction += sr.ReadLine();
				if(a != 0) introduction += "\r\n";
			}

			Bookamount = Convert.ToInt32(sr.ReadLine());

			var count = Convert.ToInt32(sr.ReadLine());//each list amount
			for(int i = 0;i < count;i++) //load bookstate list
			{
				Book.Add(new ABook(sr));
			}

			count = Convert.ToInt32(sr.ReadLine());
			for(int i = 0;i < count;i++) //load schedulequeue list
			{
				schedulequeue.AddLast(sr.ReadLine());
			}
			if(sr != null) sr.Close();
			if(zip != null) zip.Close();
			if(fs != null) fs.Close();
			return true;
		}
		/// <summary>
		///  载入详细信息，无需提前载入基本信息
		/// </summary>
		/// <param name="bookisbn">书籍编号</param>
		/// <returns></returns>
		internal ClassBook(string bookisbn)
		{
			FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
			try
			{
				fs = new FileStream(ClassBackEnd.BookDirectory + bookisbn + ".lbs", FileMode.Open);
				zip = new GZipStream(fs, CompressionMode.Decompress);
				sr = new StreamReader(zip);

				Bookisbn = sr.ReadLine();
				Bookname = sr.ReadLine();
				Publisher = sr.ReadLine();
				Author = sr.ReadLine();
				Booklable1 = sr.ReadLine();
				Booklable2 = sr.ReadLine();
				Booklable3 = sr.ReadLine();
				Bookimage = sr.ReadLine();

				var a = Convert.ToInt32(sr.ReadLine());

				Introduction = "";
				while(a-- > 0)
				{
					introduction += sr.ReadLine();
					if(a != 0) introduction += "\r\n";
				}

				Bookamount = Convert.ToInt32(sr.ReadLine());

				var count = Convert.ToInt32(sr.ReadLine());//each list amount
				for(int i = 0;i < count;i++) //load bookstate list
				{
					Book.Add(new ABook(sr));
				}

				count = Convert.ToInt32(sr.ReadLine());
				for(int i = 0;i < count;i++) //load schedulequeue list
				{
					schedulequeue.AddLast(sr.ReadLine());
				}
			}
			catch(Exception e) { return; }
			finally
			{
				if(sr != null) sr.Close();
				if(zip != null) zip.Close();
				if(fs != null) fs.Close();
			}
		}
		/// <summary>
		/// 将类classbook存入文件中,并且覆盖源文件
		/// </summary>
		/// <param name="path">文件路径</param>
		/// <returns>存储成功返回true</returns>
		internal bool SaveDetailInformation(string path)
		{
			path = path + Bookisbn + ".lbs";
			FileStream fs = null; GZipStream zip = null; StreamWriter sw = null;

			fs = new FileStream(path, FileMode.Create, FileAccess.Write);
			zip = new GZipStream(fs, CompressionMode.Compress);
			sw = new StreamWriter(zip);
			sw.WriteLine(Bookisbn);
			sw.WriteLine(Bookname);
			sw.WriteLine(Publisher);
			sw.WriteLine(Author);
			sw.WriteLine(Booklable1);
			sw.WriteLine(Booklable2);
			sw.WriteLine(Booklable3);
			sw.WriteLine(Bookimage);
			int tmp = 1;
			for(int i = 0;i < introduction.Length;i++)
			{
				if(introduction[i] == '\n')
					tmp++;
			}
			sw.WriteLine(tmp);
			sw.WriteLine(Introduction);
			sw.WriteLine(Bookamount.ToString());

			sw.WriteLine(Book.Count.ToString());
			foreach(var a in Book)
			{
				a.SaveToFile(sw);
			}

			sw.WriteLine(schedulequeue.Count.ToString());
			foreach(var tt in schedulequeue)
			{
				sw.WriteLine(tt);
			}


			if(sw != null) sw.Close();
			if(zip != null) zip.Close();
			if(fs != null) fs.Close();
			return true;
		}
		/// <summary>
		/// 储存基本信息
		/// </summary>
		/// <param name="sw">StreamWriter</param>
		internal void SaveBasicInformation(StreamWriter sw)
		{
			sw.WriteLine(Bookisbn);
			sw.WriteLine(Bookname);
			sw.WriteLine(Publisher);
			sw.WriteLine(Author);
			sw.WriteLine(Booklable1);
			sw.WriteLine(Booklable2);
			sw.WriteLine(Booklable3);

		}
		/// <summary>
		/// 添加书的数量
		/// </summary>
		/// <param name="n">数量</param>
		/// <param name="time">购入时间</param>
		/// <param name="_adminid">管理员ID</param>
		internal void AddBook(int n, DateTime time, string _adminid)
		{
			int oldamount = Book.Count;
			Bookamount += n;

			int lastisbn = Convert.ToInt32((Book.Last().Extisbn).Substring(10, 4));
			for(int i = 0;i < n;i++)
			{
				lastisbn++;
				Book.Add(new ABook(BOOKSTATE.Available, "", time, Bookisbn + lastisbn.ToString("D4")));
				UpdateHistory(Book.Last().Extisbn, time, _adminid, 0);
			}

			//通知预约者
			for(int i = oldamount;i < Bookamount;i++)
			{
				InformToScheduler(i);
			}
		}
		/// <summary>
		/// 减少书的数量
		/// </summary>
		/// <param name="n">数量</param>
		/// <returns>成功返回1，失败(有书正在被借)返回0</returns>
		internal bool DeleteBook(int n)
		{
			int tt = 0;
			for(int i = 0;i < Bookamount;i++)
			{
				if(Book[i].Bookstate == BOOKSTATE.Available)
				{
					tt++;
				}
			}
			if(tt < n) return false;
			else
			{
				for(int i = Bookamount - 1;i >= 0;i--)
				{
					if(Book[i].Bookstate == BOOKSTATE.Available)
					{
						Book.RemoveAt(i);
					}
				}
				Bookamount -= n;
				return true;
			}
		}
		/// <summary>
		/// 返回一个可借的书的序号，优先返回该用户已经预约的书
		/// </summary>
		/// <returns>序号</returns>
		internal int GetAnAvailableBook(string id)
		{
			for(int i = 0;i < Bookamount;i++)
			{
				if(Book[i].Bookstate == BOOKSTATE.Scheduled && Book[i].Borrowuserid == id) return i;
			}
			for(int i = 0;i < Bookamount;i++)
			{
				if(Book[i].Bookstate == BOOKSTATE.Available) return i;
			}
			return -1;
		}
		/// <summary>
		/// 当预约人数到达可用书籍的2倍时，该书籍不可预约
		/// </summary>
		/// <returns>可以/不可以</returns>
		internal bool Scheduleable()
		{
			int k = 0;
			for(int i = 0;i < book.Count;i++)
			{
				if(book[i].Bookstate != BOOKSTATE.Invailable)
					k++;
			}
			int sch = schedulequeue.Count;
			if(sch > 2 * k) return false;
			else return true;
		}
		/// <summary>
		/// 借书
		/// </summary>
		/// <param name="n">书在数组的序号</param>
		/// <param name="userid">用户id</param>
		/// <returns>成功返回1，失败(n越界)返回0</returns>
		internal bool BorrowBook(int n, string userid)
		{
			if(n < 0 || n >= Bookamount) return false;

			if(Book[n].Bookstate == BOOKSTATE.Available ||
				(Book[n].Bookstate == BOOKSTATE.Scheduled && Book[n].Borrowuserid == userid))
			{
				Book[n].Bookstate = BOOKSTATE.Borrowed;
				Book[n].Borrowuserid = userid;
				UpdateHistory(Book[n].Extisbn, ClassTime.systemTime, userid, 1);
				return true;
			}
			return false;

		}
		/// <summary>
		/// 将人添加到预约队列
		/// </summary>
		/// <param name="userid">用户id</param>
		/// <returns></returns>
		internal void ScheduleBook(string userid)
		{
			schedulequeue.AddLast(userid);
		}
		/// <summary>
		/// 还书
		/// </summary>
		/// <param name="userid">用户id</param>
		/// <returns>成功返回1失败返回0</returns>
		internal bool ReturnBook(string userid)
		{
			int id = -1;
			for(int i = 0;i < Bookamount;i++)
				if(Book[i].Borrowuserid == userid)
				{
					id = i;
					break;
				}
			if(id == -1) return false;
			Book[id].Bookstate = BOOKSTATE.Available;
			Book[id].Borrowuserid = "";

			UpdateHistory(Book[id].Extisbn, ClassTime.systemTime, userid, 2);

			InformToScheduler(id);
			return true;
		}
		/// <summary>
		/// 将还的书分配给预约人
		/// </summary>
		/// <param name="bookid"></param>
		/// <returns></returns>
		private bool InformToScheduler(int bookid)
		{
			if(schedulequeue.Any())
			{
				Book[bookid].Bookstate = BOOKSTATE.Scheduled;
				string ss = schedulequeue.First();
				schedulequeue.RemoveFirst();
				Book[bookid].Borrowuserid = ss;

				UpdateHistory(Book[bookid].Extisbn, ClassTime.systemTime, ss, 3);

				//通知预约者，写入文件
				ClassUser us = new ClassUser("", ss, "", "", USERTYPE.Guest);
				us.ReadDetailInformation(ClassBackEnd.UserDetailDictory);
				us.bookget(Bookisbn);
				us.SaveDetailInformation(ClassBackEnd.UserDetailDictory);

				return true;
			}
			return false;
		}
		/// <summary>
		/// 取预约书
		/// </summary>
		/// <param name="userid">用户id</param>
		/// <returns>成功返回1，失败(没找到用户的预约)返回0</returns>
		internal bool GetScheduledBook(string userid)
		{
			for(int i = 0;i < Bookamount;i++)
			{
				if(Book[i].Borrowuserid == userid && Book[i].Bookstate == BOOKSTATE.Scheduled)
				{
					Book[i].Bookstate = BOOKSTATE.Borrowed;
					UpdateHistory(Book[i].Extisbn, ClassTime.systemTime, userid, 1);
					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// 取消预约
		/// </summary>
		/// <param name="userid">用户id</param>
		/// <returns>成功返回1，失败(没找到该用户的预约)返回0</returns>
		internal bool CancelScheduleBook(string userid)
		{
			for(int i = 0;i < Bookamount;i++)
			{
				if(Book[i].Bookstate == BOOKSTATE.Scheduled)
					if(Book[i].Borrowuserid == userid)
					{
						Book[i].Borrowuserid = "";
						schedulequeue.Remove(userid);
						UpdateHistory(Book[i].Extisbn, ClassTime.systemTime, userid, 4);

						if(!InformToScheduler(i))
						{
							Book[i].Bookstate = BOOKSTATE.Available;
						}
						return true;
					}
			}
			return schedulequeue.Remove(userid);
		}
		/// <summary>
		/// 获取扩展isbn号
		/// </summary>
		/// <param name="i">book数组中第i个</param>
		/// <returns>扩展isbn号</returns>
		internal string GetExIsbn(int i)
		{
			return Book[i].Extisbn;
		}
		/// <summary>
		/// 修改书籍状态
		/// </summary>
		/// <param name="state">状态数组，保证长度为书籍数量</param>
		/// <returns>成功/失败</returns>
		internal bool ChangeBookState(List<BOOKSTATE> state)
		{
			if(state.Count != Book.Count) return false;
			for(int i = 0;i < Book.Count;i++)
			{
				if(state[i] == BOOKSTATE.Invailable && book[i].Bookstate != BOOKSTATE.Borrowed)
				{

					if(book[i].Bookstate == BOOKSTATE.Scheduled)
					{
						schedulequeue.AddFirst(book[i].Borrowuserid);
						UpdateHistory(book[i].Extisbn, ClassTime.systemTime, book[i].Borrowuserid, 4);
						ClassUser tmp = new ClassUser(book[i].Borrowuserid);
						tmp.ReadDetailInformation(ClassBackEnd.UserDetailDictory);
						tmp.MaintainSheduleBook(book[i].Extisbn);
						tmp.SaveDetailInformation(ClassBackEnd.UserDetailDictory);

					}
					if(book[i].Bookstate != BOOKSTATE.Invailable)
					{
						book[i].Bookstate = BOOKSTATE.Invailable;
						UpdateHistory(book[i].Extisbn, ClassTime.systemTime, ClassBackEnd.Currentadmin.Id, 5);
					}


				}
			}
			for(int i = 0;i < Book.Count;i++)
			{
				if(book[i].Bookstate == BOOKSTATE.Invailable && state[i] == BOOKSTATE.Available)
				{
					book[i].Bookstate = BOOKSTATE.Available;
					UpdateHistory(book[i].Extisbn, ClassTime.systemTime, ClassBackEnd.Currentadmin.Id, 6);
					InformToScheduler(i);
				}
				if(book[i].Bookstate == BOOKSTATE.Available)
				{
					InformToScheduler(i);
				}
			}

			return SaveDetailInformation(ClassBackEnd.BookDirectory);
		}
		/// <summary>
		/// 获取书籍状态
		/// </summary>
		/// <param name="state">状态数组，函数内部会清空state</param>
		internal void GetBookState(ref List<BOOKSTATE> state)
		{
			state.Clear();
			foreach(ABook tmp in book)
			{
				state.Add(tmp.Bookstate);
			}
		}
		internal bool DelBook()
		{
			foreach(ABook tmp in book)
			{
				if(tmp.Bookstate != BOOKSTATE.Invailable)
				{
					return false;
				}
			}
			foreach(string person in schedulequeue)
			{
				ClassUser tmp = new ClassUser(person);
				tmp.deletebook(this.Bookisbn);
				tmp.SaveDetailInformation(ClassBackEnd.UserDetailDictory);
			}
			return true;
		}
		#endregion
	}
}
