using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIBRARY
{
	/// <summary>
	/// 协议类型字段
	/// </summary>
	public enum RequestMode
	{
		UserLogin = 0,
		UserRegist,
		UserSearchBook,

		UserBookDetailLoad,
		UserBookStateLoad,
		UserBookCommentLoad,
		UserBorrowBook,
		UserCommentBook,
		UserDelComment,
		UserOrderBook,

		UserInfoLoad,
		UserInfoChange,
		UserNotificationLoad,
		UserBorrowedBook,
		UserBorrowHis,
		UserBadRecord,

		UserAbookLoad,
		UserReturnBook,
		UserDelayBook,


		UserBookLoad,
		PicReceive,
		PicSend,
		UserCancelScheduleBook,

		AdminSearchUser,
		AdminGetUserDetail,
		AdminSetUserPassword,
		AdminChargeUser,
        AdminAddBook,
		AdminLoadABookHis,
        AdminSendImageAck,
	}
	public class FileProtocol
	{
		private RequestMode mode;
		private int port;
		private string filename;
		private ClassUserBasicInfo userinfo;
		private ClassUserBasicInfo newUserInfo;
		private int retval;
		private string searchwords;
		private int searchcat;
		private int curnum;
		private int endnum;
		private int amo;
		private ClassBook[] resbook;
		private ClassBook nowBook;

		private ClassABook nowABook;
		private ClassABook[] eachBookState;

		private ClassComment nowComment;
		private ClassComment[] comments;

		private ClassUser user;
		private ClassAdmin admin;
		private ClassUserBasicInfo[] adminSearchUser;
		private int chargeNum;
		private ClassBookHis[] bookHis;
		private ClassBookHis[] schedule;


		public FileProtocol(RequestMode mode, int port)
		{
			this.mode = mode;
			this.port = port;
		}

		public RequestMode Mode
		{
			get { return mode; }
		}

		public int Port
		{
			get { return port; }
		}

		public ClassUserBasicInfo Userinfo
		{
			get
			{
				return userinfo;
			}

			set
			{
				userinfo = value;
			}
		}

		public int Retval
		{
			get
			{
				return retval;
			}

			set
			{
				retval = value;
			}
		}

		public string Searchwords
		{
			get
			{
				return searchwords;
			}

			set
			{
				searchwords = value;
			}
		}

		public int Searchcat
		{
			get
			{
				return searchcat;
			}

			set
			{
				searchcat = value;
			}
		}

		public int Curnum
		{
			get
			{
				return curnum;
			}

			set
			{
				curnum = value;
			}
		}

		public int Endnum
		{
			get
			{
				return endnum;
			}

			set
			{
				endnum = value;
			}
		}

		public ClassBook[] Resbook
		{
			get
			{
				return resbook;
			}

			set
			{
				resbook = value;
			}
		}

		public int Amo
		{
			get
			{
				return amo;
			}

			set
			{
				amo = value;
			}
		}

		public ClassBook NowBook
		{
			get
			{
				return nowBook;
			}

			set
			{
				nowBook = value;
			}
		}

		public ClassABook[] EachBookState
		{
			get
			{
				return eachBookState;
			}

			set
			{
				eachBookState = value;
			}
		}

		public string Filename
		{
			get
			{
				return filename;
			}

			set
			{
				filename = value;
			}
		}

		public ClassComment NowComment
		{
			get
			{
				return nowComment;
			}

			set
			{
				nowComment = value;
			}
		}

		public ClassComment[] Comments
		{
			get
			{
				return comments;
			}

			set
			{
				comments = value;
			}
		}

		public ClassABook NowABook
		{
			get
			{
				return nowABook;
			}

			set
			{
				nowABook = value;
			}
		}

		public ClassUser User
		{
			get
			{
				return user;
			}
			set
			{
				user = value;
			}
		}
		public ClassUserBasicInfo NewUserInfo
		{
			get
			{
				return newUserInfo;
			}
			set
			{
				newUserInfo = value;
			}
		}

		internal ClassAdmin Admin
		{
			get
			{
				return admin;
			}

			set
			{
				admin = value;
			}
		}

		public ClassUserBasicInfo[] AdminSearchUser
		{
			get
			{
				return adminSearchUser;
			}

			set
			{
				adminSearchUser = value;
			}
		}

		public int ChargeNum
		{
			get
			{
				return chargeNum;
			}

			set
			{
				chargeNum = value;
			}
		}

		public ClassBookHis[] BookHis
		{
			get
			{
				return bookHis;
			}

			set
			{
				bookHis = value;
			}
		}

		public ClassBookHis[] Schedule
		{
			get
			{
				return schedule;
			}

			set
			{
				schedule = value;
			}
		}

		private string Escape(string ins)
		{
			string restring = ins;
			if (restring.Contains("&") || restring.Contains("<") || restring.Contains(">") || restring.Contains("\"") || restring.Contains("\'"))
			{
				restring = restring.Replace("&", "&amp;");
				restring = restring.Replace("<", "&lt;");
				restring = restring.Replace(">", "&gt;");
				restring = restring.Replace("\"", "&quot;");
				restring = restring.Replace("\'", "&apos;");
			}
			return restring;
		}
		
		public override string ToString()
		{
			switch (mode)
			{
				case RequestMode.UserLogin:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userBasic userId=\"{2}\" userPassword=\"{3}\" /></protocol>",
							mode, port, this.Userinfo.UserId, this.Userinfo.UserPassword);
					}
				case RequestMode.UserRegist:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userBasic userId=\"{2}\" userName=\"{3}\" userPassword=\"{4}\" userSchool=\"{5}\" userType=\"{6}\"/></protocol>", mode, port, Userinfo.UserId, Escape(Userinfo.UserName), Userinfo.UserPassword, Escape(Userinfo.UserSchool), Userinfo.UserType);
					}
				case RequestMode.UserSearchBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><usersearchbook searchwords=\"{2}\" searchcat=\"{3}\" curnum=\"{4}\" endnum=\"{5}\" /></protocol>", mode, port, Escape(searchwords), searchcat, curnum, endnum);

					}
				case RequestMode.UserBookLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userBasic userid=\"{2}\" /><book bookisbn=\"{3}\" /></protocol>", mode, port, Userinfo.UserId, NowBook.BookIsbn);
					}
				case RequestMode.UserBookStateLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userBasic userid=\"{2}\" /><book bookisbn=\"{3}\" /></protocol>", mode, port, Userinfo.UserId, NowBook.BookIsbn);
					}
				case RequestMode.UserBookCommentLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><commentload bookisbn=\"{2}\" curnum=\"{3}\" /></protocol>", mode, port, NowBook.BookIsbn, curnum);
					}
				case RequestMode.UserBookDetailLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><book bookisbn=\"{2}\" /></protocol>", mode, port, NowBook.BookIsbn);
					}
				case RequestMode.PicSend:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><book bookisbn=\"{2}\" /></protocol>", mode, port, NowBook.BookIsbn);
					}
				case RequestMode.UserBorrowBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><book bookisbn=\"{2}\" /><userbasic userid=\"{3}\" userpassword=\"{4}\" /></protocol>", mode, port, NowBook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserCommentBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><comment text=\"{2}\" userid=\"{3}\" bookisbn=\"{4}\" /></protocol>", mode, port, Escape(NowComment.Text), NowComment.UserId, NowComment.CommentIsbn);
					}
				case RequestMode.UserDelComment:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><comment commentisbn=\"{2}\" /></protocol>", mode, port, NowComment.CommentIsbn);
					}
				case RequestMode.UserOrderBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><book bookisbn=\"{2}\" /><userbasic userid=\"{3}\" userpassword=\"{4}\" /></protocol>", mode, port, NowBook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserInfoLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userbasic userid=\"{2}\" userpassword=\"{3}\" /></protocol>", mode, port, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserInfoChange:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userOld userid=\"{2}\" userpassword=\"{3}\" /><userNew userid=\"{4}\" userpassword=\"{5}\" userschool=\"{6}\" username=\"{7}\" /></protocol>", mode, port, userinfo.UserId, userinfo.UserPassword, userinfo.UserId, NewUserInfo.UserPassword, Escape(NewUserInfo.UserSchool), Escape(NewUserInfo.UserName));
					}
				case RequestMode.UserNotificationLoad:
					break;
				case RequestMode.UserBorrowedBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userbasic userid=\"{2}\" userpassword=\"{3}\" /></protocol>", mode, port, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserBorrowHis:
					break;
				case RequestMode.UserBadRecord:
					break;
				case RequestMode.UserAbookLoad:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\" /></protocol>", mode, port, nowABook.BookIsbn);
					}
				case RequestMode.UserReturnBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\" /><userbasic userid=\"{3}\" userpassword=\"{4}\" /></protocol>", mode, port, NowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserDelayBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\" /><userbasic userid=\"{3}\" userpassword=\"{4}\" /></protocol>", mode, port, NowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.UserCancelScheduleBook:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><book bookisbn=\"{2}\" /><userbasic userid=\"{3}\" userpassword=\"{4}\" /></protocol>", mode, port, NowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
					}
				case RequestMode.AdminSearchUser:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><adminsearchuser searchwords=\"{2}\" curnum=\"{3}\" endnum=\"{4}\" /><admin adminid=\"{5}\" adminpassword=\"{6}\" /></protocol>", mode, port, Escape(searchwords), curnum, endnum, admin.Id, admin.Password);
					}
				case RequestMode.AdminGetUserDetail:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><admingetuserdetail userid=\"{2}\" /><admin adminid=\"{3}\" adminpassword=\"{4}\" /></protocol>", mode, port, userinfo.UserId, admin.Id, admin.Password);
					}
				case RequestMode.AdminSetUserPassword:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><adminsetuserpassword userid=\"{2}\" newpassword=\"{3}\" /><admin adminid=\"{4}\" adminpassword=\"{5}\" /></protocol>", mode, port, userinfo.UserId,userinfo.UserPassword, admin.Id, admin.Password);
					}
				case RequestMode.AdminChargeUser:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><adminchargeuser userid=\"{2}\" amount=\"{3}\" /><admin adminid=\"{4}\" adminpassword=\"{5}\" /></protocol>", mode, port, userinfo.UserId, chargeNum, admin.Id, admin.Password);
					}
				case RequestMode.AdminLoadABookHis:
					{
						return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\" /><admin adminid=\"{3}\" adminpassword=\"{4}\" /></protocol>", mode, port, nowABook.BookIsbn,admin.Id,admin.Password);
					}
				case RequestMode.AdminAddBook:
					{
						string ret = String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" />", mode, port);
						ret += String.Format("<admin adminid=\"{0}\" adminpassword=\"{1}\" />", admin.Id, admin.Password);
						ret += String.Format("<book bookname=\"{0}\" bookisbn=\"{1}\" bookamount=\"{2}\" publishtime=\"{3}\" booklabel1=\"{4}\" booklabel2=\"{5}\" booklabel3=\"{6}\" publisher=\"{7}\" author=\"{8}\" introduction=\"{9}\" />", Escape(nowBook.BookName), nowBook.BookIsbn, nowBook.BookAmount, nowBook.BookPublishTime, Escape(nowBook.BookLable1), Escape(nowBook.BookLable2), Escape(nowBook.BookLable3), Escape(nowBook.BookPublisher), Escape(nowBook.BookAuthor), Escape(nowBook.BookIntroduction));
						ret += "</protocol>";
						return ret;
					}
				default:
					break;
			}
			return "";

		}
	}
}
