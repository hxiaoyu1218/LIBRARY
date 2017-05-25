using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemBackEnd
{
	enum MESSAGEID { }
	/// <summary>
	/// 消息类 应用到用户消息队列中
	/// </summary>
//	internal class ClassMessage
//	{
//		#region PrivateProperty
//		private int id;
//		/// <summary>
//		/// 消息类别
//		/// 0 预借到货通知
//		/// 1 催还通知
//		/// 2 其他系统通知
//		/// </summary>
//		private bool readstate;//0表示未读 1表示已读
//		private string othermsg;//其余信息时字段有效
//		private string bookname;//书名
//		private string isbn;//书号
//		private DateTime date;
//		///预借时表示预约时间
//		///催还表示实际借书时间

//		private DateTime shoulddate;
//		///预借表示最晚取书日期
//		///催还表示应还日期

//		private DateTime informationdate;//通知发出日期

//		#endregion

//		#region PublicConstructor

//		/// <summary>
//		/// 构造其他通知
//		/// </summary>
//		/// <param name="_othermessage">通知内容</param>
//		/// <param name="_informationdata">通知日期</param>
//		public ClassMessage(string _othermessage, DateTime _informationdata)
//		{
//			readstate = false;
//			id = 2;//其他系统通知
//			othermsg = _othermessage;
//			informationdate = _informationdata;
//		}
//		/// <summary>
//		/// 构造预借/催还通知
//		/// </summary>
//		/// <param name="_id">0表示预借到货通知，1表示催还通知</param>
//		/// <param name="_bookname">书名</param>
//		/// <param name="_isbn">ISBN号</param>
//		/// <param name="_data">预约/借书日期</param>
//		/// <param name="_shoulddata">最晚取书/应还日期</param>
//		/// <param name="_informationdata">通知日期</param>
//		public ClassMessage(int _id,string _bookname,string _isbn,DateTime _data,DateTime _shoulddata,DateTime _informationdata)
//		{
//			readstate = false;
//			id = _id;
//			bookname = _bookname;
//			isbn = _isbn;
//			date = _data;
//			shoulddate = _shoulddata;
//			informationdate = _informationdata;
//			othermsg = "";
//		}
//		/// <summary>
//		/// 从文件读入
//		/// </summary>
//		/// <param name="sr">读入文件流</param>
//		public ClassMessage(StreamReader sr)
//		{
//			id = Convert.ToInt32(sr.ReadLine());
//			readstate = Convert.ToBoolean(sr.ReadLine());
//			if(id==2)
//			{
//				othermsg = sr.ReadLine();
//			}
//			else
//			{
//				bookname = sr.ReadLine();
//				isbn = sr.ReadLine();
//				date = DateTime.Parse(sr.ReadLine());
//				shoulddate = DateTime.Parse(sr.ReadLine());
//			}
//			informationdate = DateTime.Parse(sr.ReadLine());
//		}
//		/// <summary>
//		/// 写出到文件
//		/// </summary>
//		/// <param name="sw">写出文件流</param>
//		public void WriteToFile(StreamWriter sw)
//		{
//			sw.WriteLine(id);sw.WriteLine(readstate);
//			if(id == 2) sw.WriteLine(othermsg);
//			else
//			{
//				sw.WriteLine(bookname);
//				sw.WriteLine(isbn);
//				sw.WriteLine(date.ToString());
//				sw.WriteLine(shoulddate.ToString());
//			}
//			sw.WriteLine(informationdate.ToString());
//		}
//		#endregion

//		#region PublicGetPropertyMethod
//		/// <summary>
//		/// GetId获取消息类别
//		/// </summary>
//		/// <returns>消息类别：0 预借到货通知，1 催环通知，2 其他系统通知</returns>
//		public int GetId() { return id; }
//		/// <summary>
//		/// GetMessage 获取消息内容
//		/// </summary>
//		/// <returns>返回消息内容</returns>
//		public string GetMessage()
//		{
//			string res = "";
//			if(id == 2)
//			{
//				res += othermsg;
//				return res;
//			}
//			else if(id == 1)
//			{
//				res = "您于" + date.ToLongDateString() + "借的图书：\"" + bookname + "\"即将到期，请于" + shoulddate.ToLongDateString() + "前归还！";
//				return res;
//			}
//			else if(id == 0)
//			{
//				res = "您于" + date.ToLongDateString() + "预约的图书：\"" + bookname + "\"已经空闲，请于" + shoulddate.ToLongDateString() + "前借阅！";
//				return res;
//			}
//			else return "消息错误！";
//		}
//		/// <summary>
//		/// 获取通知时间
//		/// </summary>
//		/// <returns>返回通知时间</returns>
//		public DateTime GetInformationTime() { return informationdate; }
//		/// <summary>
//		/// GetOtherMessage获取其他消息的消息字段
//		/// </summary>
//		/// <returns>消息字段</returns>
//		public string GetOtherMsg() { return othermsg; }
//		/// <summary>
//		/// GetBookName获取书名
//		/// </summary>
//		/// <returns>书名</returns>
//		public string GetBookName() { return bookname; }
//		/// <summary>
//		/// GetISBN获取ISBN
//		/// </summary>
//		/// <returns>ISBN</returns>
//		public string GetISBN() { return isbn; }
//		/// <summary>
//		/// GetDate获取借阅/预约日期
//		/// </summary>
//		/// <returns>日期</returns>
//		public DateTime GetDate() { return date; }
//		/// <summary>
//		/// GetShouldDate获取应还/取书日期
//		/// </summary>
//		/// <returns>日期</returns>
//		public DateTime GetShouldDate() { return shoulddate; }
//		/// <summary>
//		/// GetReadState获取已读未读状态
//		/// </summary>
//		/// <returns>0表示未读 1表示已读</returns>
//		public bool GetReadState() { return readstate; }
//		/// <summary>
//		/// SetReadState设置已读未读状态
//		/// </summary>
//		/// <returns>1表示已读</returns>
//		public bool SetReadState() { readstate = true; return true; }

//		#endregion
//	}
}
