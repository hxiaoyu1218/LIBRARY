using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{

    public class ClassUser
    {
        private ClassUserBasicInfo userBasic;
        private List<ClassABook> borrowedBooks;
        private List<ClassABook> scheduledBooks;
        private List<ClassABook> borrowHis;
        private List<string> informations;

        public ClassUser(ClassUserBasicInfo userBasic)
        {
            this.userBasic = userBasic;
        }
        public ClassUser(string userId)
        {
            this.userBasic = new ClassUserBasicInfo(userId);
        }

        public ClassUserBasicInfo UserBasic
        {
            get
            {
                return userBasic;
            }

            set
            {
                userBasic = value;
            }
        }

        public List<ClassABook> BorrowedBooks
        {
            get
            {
                return borrowedBooks;
            }

            set
            {
                borrowedBooks = value;
            }
        }

        public List<ClassABook> ScheduledBooks
        {
            get
            {
                return scheduledBooks;
            }

            set
            {
                scheduledBooks = value;
            }
        }

        public List<ClassABook> BorrowHis
        {
            get
            {
                return borrowHis;
            }

            set
            {
                borrowHis = value;
            }
        }

        public List<string> Informations
        {
            get
            {
                return informations;
            }

            set
            {
                informations = value;
            }
        }

    }
}
