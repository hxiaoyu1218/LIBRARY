using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	/// <summary>
	/// 管理员类
	/// </summary>
	public class ClassAdministrator
	{
		#region PrivateProperty
		private string id;
		private string name;
		private string password;
		/// <summary>
		/// 管理员ID
		/// </summary>
		public string Id
		{
			get
			{
				return id;
			}

			internal set
			{
				id = value;
			}
		}
		/// <summary>
		/// 管理员姓名
		/// </summary>
		public string Name
		{
			get
			{
				return name;
			}

			internal set
			{
				name = value;
			}
		}
		/// <summary>
		/// 管理员密码
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
		#endregion

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="_id">id</param>
		/// <param name="_name">姓名</param>
		/// <param name="_password">密码</param>
		internal ClassAdministrator(string _id,string _name,string _password)
		{
			Id = _id;
			Name = _name;
			Password = _password;
		}
		internal ClassAdministrator(StreamReader sr)
		{
			Id = sr.ReadLine();
			Name = sr.ReadLine();
			Password = sr.ReadLine();
		}
		internal void SaveToFile(StreamWriter sw)
		{
			sw.WriteLine(Id);
			sw.WriteLine(Name);
			sw.WriteLine(Password);
		}
	}
}
