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
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userBasic userId=\"{2}\" userName=\"{3}\" userPassword=\"{4}\" userSchool=\"{5}\" userType=\"{6}\"/></protocol>", mode, port, Userinfo.UserId, Userinfo.UserName, Userinfo.UserPassword, Userinfo.UserSchool, Userinfo.UserType);
                    }
                case RequestMode.UserSearchBook:
                    {
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><usersearchbook searchwords=\"{2}\" searchcat=\"{3}\" curnum=\"{4}\" endnum=\"{5}\" /></protocol>", mode, port, searchwords, searchcat, curnum, endnum);

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
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><comment text=\"{2}\" userid=\"{3}\" bookisbn=\"{4}\" /></protocol>", mode, port, NowComment.Text, NowComment.UserId, NowComment.CommentIsbn);
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
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><userOld userid=\"{2}\" userpassword=\"{3}\" /><userNew userid=\"{4}\" userpassword=\"{5}\" userschool=\"{6}\" username=\"{7}\" /></protocol>", mode, port, userinfo.UserId, userinfo.UserPassword, userinfo.UserId, NewUserInfo.UserPassword, NewUserInfo.UserSchool, NewUserInfo.UserName);
                    }
                case RequestMode.UserNotificationLoad:
                    break;
                case RequestMode.UserBorrowedBook:
                    break;
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
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\"  /><userbasic userid=\"{3}\" userpassword=\"{4}\"></protocol>", mode, port, nowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
                    }
                case RequestMode.UserDelayBook:
                    {
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\"  /><userbasic userid=\"{3}\" userpassword=\"{4}\"></protocol>", mode, port, nowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
                    }
                case RequestMode.UserCancelScheduleBook:
                    {
                        return String.Format("<protocol><file mode=\"{0}\" port=\"{1}\" /><abook bookisbn=\"{2}\"  /><userbasic userid=\"{3}\" userpassword=\"{4}\"></protocol>", mode, port, nowABook.BookIsbn, userinfo.UserId, userinfo.UserPassword);
                    }
                default:

                    break;
            }
            return "";

        }
    }
}
