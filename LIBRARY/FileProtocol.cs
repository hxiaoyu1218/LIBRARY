using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClient
{
	public enum RequestMode
	{
		UserLogin=0,
		UserRegist=1,
		UserSearchBook=2,
		UserBookLoad=3,
		UserBookStateLoad=4,
		UserBookCommentLoad=5,
		UserBorrowBook=6,
		UserCommentBook=7,
		UserDelCommentBook=8,
		UserReturnBook=9,

	}
	class FileProtocol
	{
		private readonly RequestMode mode;
		private readonly int port;
		private readonly string userName;
		private readonly string userPassword;

		public FileProtocol(RequestMode mode, int port, string userName,string userPassword)
		{
			this.mode = mode;
			this.port = port;
			this.userName = userName;
			this.userPassword = userPassword;
		}

		public RequestMode Mode
		{
			get { return mode; }
		}

		public int Port
		{
			get { return port; }
		}

		public string UserName
		{
			get
			{
				return userName;
			}
		}

		public string UserPassword
		{
			get
			{
				return userPassword;
			}
		}

		public override string ToString()
		{
			return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" userName=\"{2}\" userPassword=\"{3}\" /></protocol>"
				, mode, port, UserName, UserPassword);
		}
	}
}
