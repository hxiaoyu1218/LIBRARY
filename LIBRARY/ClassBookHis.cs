using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    /// <summary>
	/// 书籍历史记录类
	/// </summary>
    public class ClassBookHis
    {
        private string userId;
        private ClassABook aBook;
        private DateTime borrowTime;
        private DateTime returnTime;

        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public ClassABook ABook
        {
            get
            {
                return aBook;
            }

            set
            {
                aBook = value;
            }
        }

        public DateTime BorrowTime
        {
            get
            {
                return borrowTime;
            }

            set
            {
                borrowTime = value;
            }
        }

        public DateTime ReturnTime
        {
            get
            {
                return returnTime;
            }

            set
            {
                returnTime = value;
            }
        }
    }
}
