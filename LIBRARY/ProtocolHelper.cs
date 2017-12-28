using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LIBRARY
{
    class ProtocolHelper
    {
        private XmlNode fileNode;
        private XmlNode root;

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
                case RequestMode.UserBookLoad:
                    break;
                case RequestMode.UserBookStateLoad:
                    break;
                case RequestMode.UserBookCommentLoad:
                    break;
                case RequestMode.UserBorrowBook:
                    break;
                case RequestMode.UserCommentBook:
                    break;
                case RequestMode.UserDelComment:
                    break;
                case RequestMode.UserOrderBook:
                    break;
                case RequestMode.UserInfoLoad:
                    break;
                case RequestMode.UserInfoChange:
                    break;
                case RequestMode.UserNotificationLoad:
                    break;
                case RequestMode.UserBorrowedBook:
                    break;
                case RequestMode.UserBorrowHis:
                    break;
                case RequestMode.UserBadRecord:
                    break;
                case RequestMode.UserAbookLoad:
                    break;
                case RequestMode.UserReturnBook:
                    break;
                case RequestMode.UserDelayBook:
                    break;
                default:
                    break;
            }


            return pro;
        }
    }
}
