using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace LIBRARY
{
	class ProtocolHelper
	{
		private XmlNode fileNode;
		private XmlNode root;

		private DateTime getDate(string date)
		{
			DateTime res;
			if (DateTime.TryParse(date, new CultureInfo("zh-CN"), DateTimeStyles.AssumeLocal, out res))
			{
				return res;
			}
			else if (DateTime.TryParse(date, new CultureInfo("en-UK"), DateTimeStyles.AssumeLocal, out res))
			{
				return res;
			}
			else if (DateTime.TryParse(date, new CultureInfo("en-US"), DateTimeStyles.AssumeLocal, out res))
			{
				return res;
			}
			else return DateTime.Parse(date);
		}

		public ProtocolHelper(string protocol)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(protocol);
			root = doc.DocumentElement;
			fileNode = root.SelectSingleNode("file");
		}

		// 此时的protocal一定为单条完整protocal
		// 获取单条协议包含的信息
		public FileProtocol GetProtocol()
		{
			RequestMode mode = (RequestMode)Enum.Parse(typeof(RequestMode), fileNode.Attributes["mode"].Value, false);
			int port = Convert.ToInt32(fileNode.Attributes["port"].Value);
			FileProtocol pro = new FileProtocol(mode, port);

			switch (mode)
			{
				case RequestMode.UserLogin:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						//ClassUserBasicInfo user = new ClassUserBasicInfo(usernode);
						//pro.Userinfo = user;
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserRegist:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserSearchBook:
					{
						XmlNode searchnode = root.SelectSingleNode("usersearchbook");
						pro.Curnum = Convert.ToInt32(searchnode.Attributes["curnum"].Value);
						pro.Endnum = Convert.ToInt32(searchnode.Attributes["endnum"].Value);
						pro.Amo = Convert.ToInt32(searchnode.Attributes["amo"].Value);
						XmlNodeList li = root.SelectNodes("book");
						List<ClassBook> bk = new List<ClassBook>();
						foreach (XmlNode no in li)
						{
							bk.Add(new ClassBook(no.Attributes["bookname"].Value, no.Attributes["bookisbn"].Value, no.Attributes["bookauthor"].Value, no.Attributes["bookpublisher"].Value));
						}
						pro.Resbook = bk.ToArray();
						break;
					}
				case RequestMode.UserBookDetailLoad:
					{
						XmlNode bookNode = root.SelectSingleNode("book");
						pro.NowBook = new ClassBook(bookNode.Attributes["bookisbn"].Value);
						pro.NowBook.BookName = bookNode.Attributes["bookname"].Value;
						pro.NowBook.BookPublisher = bookNode.Attributes["bookpublisher"].Value;


						pro.NowBook.BookPublishTime = getDate(bookNode.Attributes["bookpublishtime"].Value);


						pro.NowBook.BookAuthor = bookNode.Attributes["bookauthor"].Value;
						pro.NowBook.BookIntroduction = bookNode.Attributes["bookintroduction"].Value;
						pro.NowBook.BookImage = bookNode.Attributes["bookpic"].Value;
						pro.NowBook.BookLable1 = bookNode.Attributes["booklable1"].Value;
						pro.NowBook.BookLable2 = bookNode.Attributes["booklable2"].Value;
						pro.NowBook.BookLable3 = bookNode.Attributes["booklable3"].Value;
						pro.NowBook.BookAmount = Convert.ToInt32(bookNode.Attributes["bookamo"].Value);

						break;
					}
				case RequestMode.UserBookStateLoad:
					{
						XmlNode bookNode = root.SelectSingleNode("book");
						int k = Convert.ToInt32(bookNode.Attributes["bookamount"].Value);
						XmlNodeList li = root.SelectNodes("bookstate");
						List<ClassABook> bk = new List<ClassABook>();
						foreach (XmlNode no in li)
						{
							ClassABook abk = new ClassABook(no.Attributes["bookisbn"].Value);
							abk.BookState = (Bookstate)Enum.Parse(typeof(Bookstate), no.Attributes["bookstate"].Value, false);

							bk.Add(abk);
						}
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						pro.EachBookState = bk.ToArray();
						break;
					}
				case RequestMode.UserBookLoad:
					{
						XmlNode bookNode = root.SelectSingleNode("book");
						pro.NowBook = new ClassBook(bookNode.Attributes["bookisbn"].Value);
						pro.NowBook.BookName = bookNode.Attributes["bookname"].Value;
						pro.NowBook.BookPublisher = bookNode.Attributes["bookpublisher"].Value;


						pro.NowBook.BookPublishTime = getDate(bookNode.Attributes["bookpublishtime"].Value);


						pro.NowBook.BookAuthor = bookNode.Attributes["bookauthor"].Value;
						pro.NowBook.BookIntroduction = bookNode.Attributes["bookintroduction"].Value;
						pro.NowBook.BookImage = bookNode.Attributes["bookpic"].Value;
						pro.NowBook.BookLable1 = bookNode.Attributes["booklable1"].Value;
						pro.NowBook.BookLable2 = bookNode.Attributes["booklable2"].Value;
						pro.NowBook.BookLable3 = bookNode.Attributes["booklable3"].Value;
						pro.NowBook.BookAmount = Convert.ToInt32(bookNode.Attributes["bookamo"].Value);

						int k = Convert.ToInt32(bookNode.Attributes["bookamo"].Value);
						XmlNodeList li = root.SelectNodes("bookstate");
						List<ClassABook> bk = new List<ClassABook>();
						foreach (XmlNode no in li)
						{
							ClassABook abk = new ClassABook(no.Attributes["bookextisbn"].Value);
							abk.BookState = (Bookstate)Enum.Parse(typeof(Bookstate), no.Attributes["bookstate"].Value, false);

							bk.Add(abk);
						}
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						pro.EachBookState = bk.ToArray();
						break;
					}
				case RequestMode.UserBookCommentLoad:
					{
						XmlNode commentSum = root.SelectSingleNode("commentsum");
						pro.Endnum = Convert.ToInt32(commentSum.Attributes["endnum"].Value);
						XmlNodeList li = root.SelectNodes("comment");
						List<ClassComment> comments = new List<ClassComment>();
						foreach (XmlNode no in li)
						{
							ClassComment cmt = new ClassComment();
							cmt.CommentIsbn = no.Attributes["commentisbn"].Value;
							cmt.Text = no.Attributes["text"].Value;
							cmt.UserId = no.Attributes["userid"].Value;

							DateTime res = DateTime.Now;

							cmt.CommentTime = getDate(no.Attributes["commenttime"].Value);
							comments.Add(cmt);
						}
						pro.Comments = comments.ToArray();
						break;
					}
				case RequestMode.UserBorrowBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserCommentBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserDelComment:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserOrderBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserInfoLoad:
					{
						XmlNode usernode = root.SelectSingleNode("userbasicinfo");
						pro.User = new ClassUser(usernode.Attributes["userid"].Value);
						pro.User.UserBasic.UserName = usernode.Attributes["username"].Value;
						pro.User.UserBasic.UserSchool = usernode.Attributes["userschool"].Value;
						pro.User.UserBasic.UserCredit = Convert.ToInt32(usernode.Attributes["usercredit"].Value);
						pro.User.UserBasic.UserCurrentBorrowedAmount = Convert.ToInt32(usernode.Attributes["usercurrentborrowedamount"].Value);
						pro.User.UserBasic.UserCurrentMaxBorrowableAmount = Convert.ToInt32(usernode.Attributes["usercurrentmaxborrowableamount"].Value);
						pro.User.UserBasic.UserCurrentScheduleAmount = Convert.ToInt32(usernode.Attributes["usercurrentscheduleamount"].Value);

						pro.User.Informations = new List<string>();
						pro.User.BorrowedBooks = new List<ClassABook>();
						pro.User.ScheduledBooks = new List<ClassABook>();
						pro.User.BorrowHis = new List<ClassABook>();

						XmlNodeList li = root.SelectNodes("eachinformation");
						foreach (XmlNode lli in li)
						{
							pro.User.Informations.Add(lli.Attributes["content"].Value);
						}

						li = root.SelectNodes("usereachborrowedbook");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);
							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);
							pro.User.BorrowedBooks.Add(tmp);
						}

						li = root.SelectNodes("usereachscheduledbook");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;
							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);
							pro.User.ScheduledBooks.Add(tmp);
						}

						li = root.SelectNodes("usereachborrowhis");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);

							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);
							pro.User.BorrowHis.Add(tmp);
						}
						break;
					}
				case RequestMode.UserInfoChange:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserNotificationLoad:
					break;
				case RequestMode.UserBorrowedBook:
					{
						XmlNode usernode = root.SelectSingleNode("userbasicinfo");
						pro.User = new ClassUser(usernode.Attributes["userid"].Value);

						pro.User.BorrowedBooks = new List<ClassABook>();

						XmlNodeList li = root.SelectNodes("usereachborrowedbook");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;


							DateTime res = DateTime.Now;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);

							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);
							tmp.BookImage = lli.Attributes["bookpic"].Value;
							pro.User.BorrowedBooks.Add(tmp);
						}
						break;
					}
				case RequestMode.UserBorrowHis:
					break;
				case RequestMode.UserBadRecord:
					break;
				case RequestMode.UserAbookLoad:
					{
						XmlNode abook = root.SelectSingleNode("abook");
						pro.NowABook = new ClassABook(abook.Attributes["bookisbn"].Value);
						pro.NowABook.BookAuthor = abook.Attributes["bookauthor"].Value;
						pro.NowABook.BookPublisher = abook.Attributes["bookpublisher"].Value;

						pro.NowABook.BorrowTime = getDate(abook.Attributes["bookborrowtime"].Value);

						pro.NowABook.ReturnTime = getDate(abook.Attributes["bookreturntime"].Value);


						pro.NowABook.BookName = abook.Attributes["bookname"].Value;
						pro.NowABook.BookImage = abook.Attributes["bookpic"].Value;
						break;
					}
				case RequestMode.UserReturnBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserDelayBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.UserCancelScheduleBook:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.AdminSearchUser:
					{
						XmlNode searchnode = root.SelectSingleNode("adminsearchuser");
						pro.Curnum = Convert.ToInt32(searchnode.Attributes["curnum"].Value);
						pro.Endnum = Convert.ToInt32(searchnode.Attributes["endnum"].Value);
						pro.Amo = Convert.ToInt32(searchnode.Attributes["amo"].Value);
						XmlNodeList li = root.SelectNodes("userbasic");
						List<ClassUserBasicInfo> users = new List<ClassUserBasicInfo>();
						foreach (XmlNode no in li)
						{
							ClassUserBasicInfo ub = new ClassUserBasicInfo(no.Attributes["userid"].Value);
							ub.UserSchool = no.Attributes["userschool"].Value;
							ub.UserName = no.Attributes["username"].Value;
							users.Add(ub);
						}
						pro.AdminSearchUser = users.ToArray();
						break;
					}
				case RequestMode.AdminGetUserDetail:
					{
						XmlNode usernode = root.SelectSingleNode("userbasicinfo");
						pro.User = new ClassUser(usernode.Attributes["userid"].Value);
						pro.User.UserBasic.UserName = usernode.Attributes["username"].Value;
						pro.User.UserBasic.UserSchool = usernode.Attributes["userschool"].Value;
						pro.User.UserBasic.UserCredit = Convert.ToInt32(usernode.Attributes["usercredit"].Value);
						pro.User.UserBasic.UserCurrentBorrowedAmount = Convert.ToInt32(usernode.Attributes["usercurrentborrowedamount"].Value);
						pro.User.UserBasic.UserCurrentMaxBorrowableAmount = Convert.ToInt32(usernode.Attributes["usercurrentmaxborrowableamount"].Value);
						pro.User.UserBasic.UserCurrentScheduleAmount = Convert.ToInt32(usernode.Attributes["usercurrentscheduleamount"].Value);
						pro.User.UserBasic.UserRegisterDate = getDate(usernode.Attributes["userregistdate"].Value);

						pro.User.BorrowedBooks = new List<ClassABook>();
						pro.User.ScheduledBooks = new List<ClassABook>();
						pro.User.BorrowHis = new List<ClassABook>();

						XmlNodeList li = root.SelectNodes("usereachborrowedbook");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);
							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);
							pro.User.BorrowedBooks.Add(tmp);
						}

						li = root.SelectNodes("usereachscheduledbook");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;
							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);
							pro.User.ScheduledBooks.Add(tmp);
						}

						li = root.SelectNodes("usereachborrowhis");
						foreach (XmlNode lli in li)
						{
							ClassABook tmp = new ClassABook(lli.Attributes["bookisbn"].Value);
							tmp.BookName = lli.Attributes["bookname"].Value;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);

							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);

							pro.User.BorrowHis.Add(tmp);
						}

						break;
					}
				case RequestMode.AdminSetUserPassword:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.AdminChargeUser:
					{
						XmlNode usernode = root.SelectSingleNode("file");
						pro.Retval = Convert.ToInt32(usernode.Attributes["retval"].Value);
						break;
					}
				case RequestMode.AdminLoadABookHis:
					{
						List<ClassBookHis> bookhis = new List<ClassBookHis>();
						XmlNodeList li = root.SelectNodes("adminloadabookhis");
						foreach (XmlNode lli in li)
						{
							ClassBookHis tmp = new ClassBookHis();
							tmp.UserId = lli.Attributes["userid"].Value;

							tmp.BorrowTime = getDate(lli.Attributes["bookborrowdate"].Value);

							tmp.ReturnTime = getDate(lli.Attributes["bookreturndate"].Value);

							bookhis.Add(tmp);
						}
						pro.BookHis = bookhis.ToArray();
						break;
					}
				default:
					break;
			}
			return pro;
		}
	}
}
