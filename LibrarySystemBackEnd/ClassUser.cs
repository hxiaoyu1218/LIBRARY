using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 用户种类
	/// </summary>
	public enum USERTYPE
	{
		/// <summary>
		/// 学生
		/// </summary>
		Student,
		/// <summary>
		/// 老师
		/// </summary>
		Lecturer,
		/// <summary>
		/// 访客
		/// </summary>
		Guest,
	};
	/// <summary>
	/// 为用户封装的已借图书类
	/// </summary>
	public class ClassBookAndDate
	{
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
		internal DateTime bsdate;
		/// <summary>
		/// 应还/最晚取书日期
		/// </summary>
		internal DateTime rgdate;
		/// <summary>
		/// 是否已续借
		/// </summary>
		private bool delayed;
		/// <summary>
		/// 书籍是否已删除
		/// </summary>
		private bool deleted;
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
		/// 是否已续借
		/// </summary>
		public bool Delayed
		{
			get
			{
				return delayed;
			}

			internal set
			{
				delayed = value;
			}
		}
		/// <summary>
		/// 指示书籍是否已被删除
		/// </summary>
		public bool Deleted
		{
			get
			{
				return deleted;
			}

			internal set
			{
				deleted = value;
			}
		}



		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_bookisbn">书号isbn</param>
		/// <param name="_bookname">书名</param>
		/// <param name="_bsdate">借/预约日期</param>
		/// <param name="_rgdate">应还日期</param>
		/// <param name="_delayed">是否已续借</param>
		/// <param name="_deleted">是否已删除</param>
		internal ClassBookAndDate(string _bookisbn, string _bookname, DateTime _bsdate, DateTime _rgdate, bool _delayed = false, bool _deleted = false)
		{
			Bookisbn = _bookisbn;
			Bookname = _bookname;
			bsdate = _bsdate;
			rgdate = _rgdate;
			Delayed = _delayed;
			deleted = _deleted;
		}
		/// <summary>
		/// 从文件读入
		/// </summary>
		/// <param name="sr">读入文件流</param>
		internal ClassBookAndDate(StreamReader sr)
		{
			Bookisbn = sr.ReadLine();
			Bookname = sr.ReadLine();
			bsdate = DateTime.Parse(sr.ReadLine());
			rgdate = DateTime.Parse(sr.ReadLine());
			Delayed = Convert.ToBoolean(sr.ReadLine());
			Deleted = Convert.ToBoolean(sr.ReadLine());

		}
		/// <summary>
		/// 写入到文件
		/// </summary>
		/// <param name="sw">写入文件流</param>
		internal void WriteToFile(StreamWriter sw)
		{
			sw.WriteLine(Bookisbn);
			sw.WriteLine(Bookname);
			sw.WriteLine(bsdate.ToString());
			sw.WriteLine(rgdate.ToString());
			sw.WriteLine(Delayed);
			sw.WriteLine(Deleted);
		}
	}
	/// <summary>
	/// 用户类
	/// </summary>
	public class ClassUser
	{
		private readonly TimeSpan defaultdate = new TimeSpan(30, 0, 0, 0, 0);
		private readonly TimeSpan defaultdelay = new TimeSpan(15, 0, 0, 0, 0);
		private const int maxscheduleamount = 5;
		private const int maxcredit = 100;

		#region PrivateProperty
		/// <summary>
		/// 用户信息
		/// 
		/// 文件储存格式：
		/// 在data\UserList.lbs里面按序储存 id name password school type
		/// 
		/// 在data\usersdetail\“name.lbs”里面 储存：
		/// 当前信用 最大借书数量 当前最大可借数量 当前借书数量
		/// 然后是当前借的书 一行四个串 bookisbn bsdate rgdate delayed
		/// 
		/// 然后是当前已预约书数量
		/// 然后是当前预约的书 一行四个串 bookisbn bsdate rgdate delayed
		/// 
		/// 在加载用户信息时遍历生成消息队列
		/// 
		/// </summary>
		private string username;
		private string userid;
		private string password;
		private string school;
		private USERTYPE usertype;
		private int currentscheduleamount;//当前已预约书数量
		private int maxborrowableamount;//最大借书数量
		private int currentborrowedamount;//当前借书数量
		private int currentmaxborrowableamount;//当前最大可借数量
		private int credit;///信用
						   ///满分100
						   ///每逾期3天还书信用减1
						   ///借书数量是信用百分比乘最大借书数量向上取整
						   ///交钱恢复信用一元一点信用
		private List<ClassBookAndDate> borrowedbook = new List<ClassBookAndDate>();
		private List<ClassBookAndDate> schedulebook = new List<ClassBookAndDate>();
		private DateTime registerDate = new DateTime();


		#endregion

		#region PublicGetPropertyMethod
		/// <summary>
		/// 用户名
		/// </summary>
		public string Username
		{
			get
			{
				return username;
			}

			internal set
			{
				username = value;
			}
		}
		/// <summary>
		/// 用户id
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
		/// 用户密码
		/// </summary>
		public string Password
		{
			get
			{
				return password;
			}

			internal set
			{
				password = value;
			}
		}
		/// <summary>
		/// 学院
		/// </summary>
		public string School
		{
			get
			{
				return school;
			}

			internal set
			{
				school = value;
			}
		}
		/// <summary>
		/// 用户种类 0学生1老师2访客
		/// </summary>
		public USERTYPE Usertype
		{
			get
			{
				return usertype;
			}

			internal set
			{
				usertype = value;
			}
		}
		/// <summary>
		/// 当前预约书籍数量
		/// </summary>
		public int Currentscheduleamount
		{
			get
			{
				return currentscheduleamount;
			}

			internal set
			{
				currentscheduleamount = value;
			}
		}
		/// <summary>
		/// 最大可借数量，依据用户种类而定
		/// </summary>
		public int Maxborrowableamount
		{
			get
			{
				return maxborrowableamount;
			}

			internal set
			{
				maxborrowableamount = value;
			}
		}
		/// <summary>
		/// 当前借书数量
		/// </summary>
		public int Currentborrowedamount
		{
			get
			{
				return currentborrowedamount;
			}

			internal set
			{
				currentborrowedamount = value;
			}
		}
		/// <summary>
		/// 当前最大借书数量，最大借书数量乘以信用百分比
		/// </summary>
		public int Currentmaxborrowableamount
		{
			get
			{
				return currentmaxborrowableamount;
			}

			internal set
			{
				currentmaxborrowableamount = value;
			}
		}
		/// <summary>
		/// 信用
		/// </summary>
		public int Credit
		{
			get
			{
				return credit;
			}

			internal set
			{
				if(value > 100) credit = 100;
				else credit = value;
			}
		}
		/// <summary>
		/// 注册日期
		/// </summary>
		public string RegisterDate
		{
			get
			{
				var a = registerDate.Year.ToString("D4");
				var b = registerDate.Month.ToString("D2");
				var c = registerDate.Day.ToString("D2");
				return a + "-" + b + "-" + c;
			}

		}

		/// <summary>
		/// 返回
		/// </summary>
		/// <returns></returns>
		public IReadOnlyList<ClassBookAndDate> GetBorrowedBook() { return borrowedbook.AsReadOnly(); }

		#endregion

		#region PrivateMethod

		private void UpdateCurrentMaxBorrowableAmount()
		{
			Currentmaxborrowableamount = (int)Math.Ceiling(Maxborrowableamount * (Credit < 0 ? 0 : Credit) / 100.0);
		}
		private void UpdateBorrowHistory(string _bookisbn, string _bookname, DateTime _borrowdate, DateTime _returndate)
		{
			string oldpath = ClassBackEnd.UserHistoryDictory + Userid + ".his";
			string newpath = ClassBackEnd.UserHistoryDictory + Userid + ".tmphis";

			FileStream fso = null; GZipStream zipo = null; StreamReader sro = null;
			FileStream fsn = null; GZipStream zipn = null; StreamWriter swn = null;
			try
			{
				fso = new FileStream(oldpath, FileMode.OpenOrCreate);
				zipo = new GZipStream(fso, CompressionMode.Decompress);
				sro = new StreamReader(zipo);

				fsn = new FileStream(newpath, FileMode.Create);
				zipn = new GZipStream(fsn, CompressionMode.Compress);
				swn = new StreamWriter(zipn);

				if(sro.EndOfStream)//源文件无内容
				{
					swn.WriteLine(1.ToString());
					ClassBorrowHistory atmp = new ClassBorrowHistory(_bookname, _bookisbn, _borrowdate, _returndate);
					atmp.SaveToFile(swn);
				}
				else
				{
					int t = Convert.ToInt32(sro.ReadLine());
					swn.WriteLine((t + 1).ToString());

					while(t-- > 0)
					{
						ClassBorrowHistory tmp = new ClassBorrowHistory(sro);
						tmp.SaveToFile(swn);
					}
					ClassBorrowHistory atmp = new ClassBorrowHistory(_bookname, _bookisbn, _borrowdate, _returndate);
					atmp.SaveToFile(swn);
				}

			}
			//catch(Exception e) { return ; }
			finally
			{
				if(sro != null) sro.Close(); if(zipo != null) zipo.Close(); if(fso != null) fso.Close();
				if(swn != null) swn.Close(); if(zipn != null) zipn.Close(); if(fsn != null) fsn.Close();
			}

			File.Delete(oldpath);
			File.Move(newpath, oldpath);

			return;
		}
		private void RefreshCreditFile(string s)
		{
			FileStream fs = null; StreamWriter sw = null;
			try
			{
				fs = new FileStream(ClassBackEnd.UserCerditDictory + Userid + @".cre", FileMode.Append);
				sw = new StreamWriter(fs);
				sw.WriteLine(s);
				return;
			}
			catch(Exception e) { return; }
			finally
			{
				if(sw != null) sw.Close();
				if(fs != null) fs.Close();
			}
		}
		#endregion

		#region PublicMethod
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_username">用户名</param>
		/// <param name="_userid">用户学号</param>
		/// <param name="_password">用户密码</param>
		/// <param name="_school">用户学院，可以为空</param>
		/// <param name="_usertype">用户类别，默认Guest</param>
		internal ClassUser(string _username, string _userid, string _password, string _school, USERTYPE _usertype)
		{
			Username = _username;
			Userid = _userid;
			Password = _password;
			School = _school;
			Usertype = _usertype;
			Credit = 100;
			Currentborrowedamount = 0;
			Currentscheduleamount = 0;

			FileStream fs = null; StreamReader sr = null;
			try
			{
				fs = new FileStream(@"data\time.lbs", FileMode.OpenOrCreate);
				sr = new StreamReader(fs);
				ClassTime.ReadFromFile(sr);
			}
			catch(Exception)
			{
				return;
			}
			finally
			{
				if(sr != null) sr.Close();
				if(fs != null) fs.Close();
			}

			registerDate = ClassTime.systemTime;
			if(usertype == USERTYPE.Guest) Currentmaxborrowableamount = Maxborrowableamount = 0;
			else if(usertype == USERTYPE.Student) Currentmaxborrowableamount = Maxborrowableamount = 10;
			else if(usertype == USERTYPE.Lecturer) Currentmaxborrowableamount = Maxborrowableamount = 20;

			if(!File.Exists(ClassBackEnd.UserCerditDictory + Userid + @".cre"))
			{
				(File.Create(ClassBackEnd.UserCerditDictory + Userid + @".cre")).Close();
			}
		}
		/// <summary>
		/// 从文件添加用户类的详细信息
		/// </summary>
		/// <param name="path">文件路径</param>
		/// <returns>成功返回1出现异常返回0</returns>
		internal bool ReadDetailInformation(string path)
		{
			borrowedbook.Clear();
			schedulebook.Clear();

			path = path + Userid + ".lbs";
			FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
			try
			{
				fs = new FileStream(path, FileMode.Open);
				zip = new GZipStream(fs, CompressionMode.Decompress);
				sr = new StreamReader(zip);
				Currentscheduleamount = Convert.ToInt32(sr.ReadLine());
				Maxborrowableamount = Convert.ToInt32(sr.ReadLine());
				Currentborrowedamount = Convert.ToInt32(sr.ReadLine());
				Currentmaxborrowableamount = Convert.ToInt32(sr.ReadLine());
				Credit = Convert.ToInt32(sr.ReadLine());

				int a, b, c;
				a = Convert.ToInt32(sr.ReadLine());
				b = Convert.ToInt32(sr.ReadLine());
				c = Convert.ToInt32(sr.ReadLine());
				registerDate = new DateTime(a, b, c);

				int t1; t1 = Convert.ToInt32(sr.ReadLine());
				while(t1-- > 0)
				{
					borrowedbook.Add(new ClassBookAndDate(sr));
				}

				t1 = Convert.ToInt32(sr.ReadLine());
				while(t1-- > 0)
				{
					schedulebook.Add(new ClassBookAndDate(sr));
					if(schedulebook.Last().Deleted == true)
					{
						var tmp = ClassTime.systemTime;
						if(schedulebook.Last().rgdate + TimeSpan.FromDays(5.0) < tmp)
						{
							schedulebook.Remove(schedulebook.Last());
						}
					}
				}
				return true;
			}
			catch(Exception)
			{
				return false;
			}
			finally
			{
				if(sr != null) sr.Close();
				if(zip != null) zip.Close();
				if(fs != null) fs.Close();
			}
		}
		internal bool SaveDetailInformation(string path)
		{
			path = path + Userid + ".lbs";
			FileStream fs = null; GZipStream zip = null; StreamWriter sw = null;
			try
			{
				fs = new FileStream(path, FileMode.Create, FileAccess.Write);
				zip = new GZipStream(fs, CompressionMode.Compress);
				sw = new StreamWriter(zip);
				sw.WriteLine(Currentscheduleamount);
				sw.WriteLine(Maxborrowableamount);
				sw.WriteLine(Currentborrowedamount);
				sw.WriteLine(Currentmaxborrowableamount);
				sw.WriteLine(Credit);

				sw.WriteLine(registerDate.Year);
				sw.WriteLine(registerDate.Month);
				sw.WriteLine(registerDate.Day);

				sw.WriteLine(borrowedbook.Count());
				for(int i = 0;i < borrowedbook.Count();i++)
				{
					borrowedbook[i].WriteToFile(sw);
				}

				sw.WriteLine(schedulebook.Count);
				for(int i = 0;i < schedulebook.Count;i++)
				{
					schedulebook[i].WriteToFile(sw);
				}
				return true;
			}
			catch(Exception)
			{
				return false;
			}
			finally
			{
				if(sw != null) sw.Close();
				if(zip != null) zip.Close();
				if(fs != null) fs.Close();
			}
		}
		internal ClassUser(string id)
		{
			userid = id;

			string path = ClassBackEnd.UserDetailDictory + id + ".lbs";
			FileStream fs = null; GZipStream zip = null; StreamReader sr = null;
			try
			{
				fs = new FileStream(path, FileMode.Open);
				zip = new GZipStream(fs, CompressionMode.Decompress);
				sr = new StreamReader(zip);
				Currentscheduleamount = Convert.ToInt32(sr.ReadLine());
				Maxborrowableamount = Convert.ToInt32(sr.ReadLine());
				Currentborrowedamount = Convert.ToInt32(sr.ReadLine());
				Currentmaxborrowableamount = Convert.ToInt32(sr.ReadLine());
				Credit = Convert.ToInt32(sr.ReadLine());

				int a, b, c;
				a = Convert.ToInt32(sr.ReadLine());
				b = Convert.ToInt32(sr.ReadLine());
				c = Convert.ToInt32(sr.ReadLine());
				registerDate = new DateTime(a, b, c);

				int t1; t1 = Convert.ToInt32(sr.ReadLine());
				while(t1-- > 0)
				{
					borrowedbook.Add(new ClassBookAndDate(sr));
				}

				t1 = Convert.ToInt32(sr.ReadLine());
				while(t1-- > 0)
				{
					schedulebook.Add(new ClassBookAndDate(sr));
					//if(schedulebook.Last().Deleted == true)
					//{
					//	var tmp = ClassTime.systemTime;
					//	if(schedulebook.Last().rgdate + TimeSpan.FromDays(5.0) < tmp)
					//	{
					//		schedulebook.Remove(schedulebook.Last());
					//	}
					//}
				}
			}
			catch(Exception)
			{

			}
			finally
			{
				if(sr != null) sr.Close();
				if(zip != null) zip.Close();
				if(fs != null) fs.Close();
			}
		}
		/// <summary>
		/// 借书函数，判断是否达到借书上限，增加借书数量，将书添加到借书列表。注意并不能检查书的余量
		/// </summary>
		/// <param name="bookisbn">书号带扩展</param>
		/// <param name="bookname">书名</param>
		/// <returns>借书成功返回1，失败(已达借书上限)返回0</returns>
		internal bool BorrowBook(string bookisbn, string bookname)
		{
			if(Currentborrowedamount < Currentmaxborrowableamount)
			{
				Currentborrowedamount++;

				borrowedbook.Add(new ClassBookAndDate(bookisbn, bookname, ClassTime.systemTime, ClassTime.systemTime.Add(defaultdate)));

				//移除预约列表里面的书
				for(int i = 0;i < schedulebook.Count;i++)
				{
					if(bookisbn.Contains(schedulebook[i].Bookisbn))
					{
						schedulebook.RemoveAt(i);
						Currentscheduleamount--;
						break;
					}
				}
				return true;
			}
			else return false;
		}
		/// <summary>
		/// 借书的逆过程
		/// </summary>
		internal void CancelBorrowBook()
		{
			Currentborrowedamount--;
			borrowedbook.RemoveAt(borrowedbook.Count - 1);
		}
		/// <summary>
		/// 预约函数
		/// 判断是否达到预约书上限，增加预约书数量，将书添加到预约书列表
		/// 添加预约成功通知。注意并不能检查书的余量
		/// </summary>
		/// <param name="bookisbn">书号</param>
		/// <param name="bookname">书名</param>
		/// <returns>预约成功返回1，失败(已达上限)返回0</returns>
		internal bool ScheduleBook(string bookisbn, string bookname)
		{
			if(Currentscheduleamount < maxscheduleamount)
			{
				Currentscheduleamount++;

				schedulebook.Add(new ClassBookAndDate(bookisbn, bookname, ClassTime.systemTime, ClassTime.systemTime));

				return true;
			}
			else return false;
		}
		/// <summary>
		/// 还书函数，在已借列表里面搜索，找到后检查是否逾期，更新信用信息，添加消息队列
		/// </summary>
		/// <param name="bookisbn">书号</param>
		/// <param name="bookname">书名</param>
		/// <returns>还书成功返回1，失败(未借)返回0</returns>
		internal bool ReturnBook(string bookisbn, string bookname)
		{
			for(int i = 0;i < borrowedbook.Count;i++)
			{
				if(borrowedbook[i].Bookisbn.Contains(bookisbn))
				{
					var a = ClassTime.systemTime;
					var b = borrowedbook[i].rgdate;

					//处理日期问题，信用按天计算就改成TotalDays
					var c = Convert.ToInt32(Math.Floor((a - b).TotalDays));

					var d = borrowedbook[i].bsdate;
					if(c > 0)
					{
						Credit = Credit - c;
						UpdateCurrentMaxBorrowableAmount();
						RefreshCreditFile("用户于" + borrowedbook[i].Bsdate + "借阅了书籍《" + borrowedbook[i].Bookname + "》(" + borrowedbook[i].Bookisbn + ")，于" + a.ToShortDateString() + "归还了书籍。扣除信用" + c + "。\n");
					}

					Currentborrowedamount--;
					borrowedbook.RemoveAt(i);

					UpdateBorrowHistory(bookisbn, bookname, d, a);

					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// 取消预约书
		/// </summary>
		/// <param name="bookisbn">书号</param>
		/// <param name="bookname">书名</param>
		/// <returns>取消成功返回true，失败(未预约此书)返回0</returns>
		internal bool CancelScheduleBook(string bookisbn, string bookname)
		{
			for(int i = 0;i < schedulebook.Count;i++)
			{
				if(schedulebook[i].Bookisbn == bookisbn)
				{
					Currentscheduleamount--;
					schedulebook.RemoveAt(i);
					return true;
				}
			}
			return false;
		}
		/// <summary>
		/// 取预约书，实际跟借书一样
		/// </summary>
		/// <param name="bookisbn">书号</param>
		/// <param name="bookname">书名</param>
		/// <returns>成功返回1，失败(已达借阅上限)返回0</returns>
		internal bool GetScheduleBook(string bookisbn, string bookname)
		{
			return BorrowBook(bookisbn, bookname);
		}
		/// <summary>
		/// 续借书，更新应还日期
		/// </summary>
		/// <param name="bookisbn">书号</param>
		/// <param name="bookname">书名</param>
		/// <returns>返回值1表示成功，2表示已续借过，3表示已过期，4表示离应还日期5天以上，0表示没找到书</returns>
		internal int RenewBook(string bookisbn, string bookname)
		{
			for(int i = 0;i < borrowedbook.Count;i++)
			{
				if(borrowedbook[i].Bookisbn.Contains(bookisbn))
				{
					if(borrowedbook[i].Delayed == true) return 2;//已续借过，不能续借
					var a = ClassTime.systemTime;
					var b = borrowedbook[i].rgdate;
					var c = Convert.ToInt32(Math.Floor((b - a).TotalDays));
					if(c < 0) return 3;//过了应还日期不能续借
					if(c > 5) return 4;//应还日期5天以上不能续借

					borrowedbook[i].Delayed = true;
					borrowedbook[i].rgdate += defaultdelay;
					return 1;
				}
			}
			return 0;//没找到书，续借失败
		}
		/// <summary>
		/// 充值信用，超过100就算100
		/// </summary>
		/// <param name="money">充值量</param>
		/// <returns>返回最终信用</returns>
		internal int Charge(int money)
		{
			if(money < 0) return Credit;
			if(Credit + money > 100)
			{
				Credit = 100;
			}
			else Credit += money;

			RefreshCreditFile("用户于" + ClassTime.SystemTime + "充值信用" + money + "，当前信用" + Credit.ToString() + "。\n");

			UpdateCurrentMaxBorrowableAmount();

			return Credit;
		}
		/// <summary>
		/// 返回是否借过这本书
		/// </summary>
		/// <param name="bookisbn">书籍编号，不带扩展</param>
		/// <returns>是/否</returns>
		internal bool HasBorrowed(string bookisbn)
		{
			foreach(var t in borrowedbook)
			{
				if(t.Bookisbn.Contains(bookisbn)) return true;
			}
			return false;
		}
		/// <summary>
		/// 返回是否预约这本书
		/// </summary>
		/// <param name="bookisbn">书籍编号，不带扩展</param>
		/// <returns>是/否</returns>
		internal bool HasScheduled(string bookisbn)
		{
			foreach(var t in schedulebook)
			{
				if(t.Bookisbn == bookisbn) return true;
			}
			return false;
		}
		/// <summary>
		/// 进入用户界面时更新消息列表
		/// </summary>
		/// <returns>消息列表的只读拷贝</returns>
		internal void LoadMesssageList(ref List<string> mes)
		{
			if(mes.Any()) mes.Clear();

			foreach(ClassBookAndDate bk in borrowedbook)
			{
				TimeSpan ts = bk.rgdate - ClassTime.systemTime;
				if(ts < TimeSpan.FromDays(5.0) && ts > TimeSpan.Zero)
				{
					mes.Add("您借的书籍《" + bk.Bookname + "》将于" + bk.Rgdate + "到期，请尽快归还！");
				}
				else if(ts < TimeSpan.Zero)
				{
					mes.Add("您借的书籍《" + bk.Bookname + "》已过期，请尽快归还！");
				}
			}
			foreach(ClassBookAndDate bk in schedulebook)
			{
				if(bk.Delayed == true)
				{
					mes.Add("您预约的书籍《" + bk.Bookname + "》已经到馆，请尽快借阅！");
				}
				if(bk.Deleted == true)
				{
					mes.Add("您预约的书籍《" + bk.Bookname + "》已被管理员删除！");
				}
			}
		}
		/// <summary>
		/// 加载已借以及已预约书籍
		/// </summary>
		/// <param name="bk">书籍引用</param>
		/// <param name="borrowedonly">为true只加载已借书籍，默认false</param>
		internal void LoadBSBooks(ref List<ClassBorrowedBook> bk, bool borrowedonly = false)
		{
			if(bk.Any()) bk.Clear();

			foreach(ClassBookAndDate cba in borrowedbook)
			{
				bk.Add(new ClassBorrowedBook(cba, true));
			}
			if(!borrowedonly)
			{
				foreach(ClassBookAndDate cba in schedulebook)
				{
					if(cba.Deleted == false)
						bk.Add(new ClassBorrowedBook(cba, false));
				}
			}
		}
		/// <summary>
		/// 预约书籍到馆，更改状态为待取书
		/// </summary>
		/// <param name="bookisbn">书籍编号，带扩展</param>
		internal void bookget(string bookisbn)
		{
			foreach(ClassBookAndDate bad in schedulebook)
			{
				if(bad.Bookisbn == bookisbn)
				{
					bad.Delayed = true;
					return;
				}
			}
		}
		internal void deletebook(string bookisbn)
		{
			foreach(ClassBookAndDate bad in schedulebook)
			{
				if(bad.Bookisbn == bookisbn)
				{
					bad.Deleted = true;
					return;
				}
			}
		}
		internal void MaintainSheduleBook(string bookisbn)
		{
			foreach(ClassBookAndDate cbad in schedulebook)
			{
				if(bookisbn.Contains(cbad.Bookisbn))
					cbad.Delayed = false;
			}
		}
		#endregion

	}
}
