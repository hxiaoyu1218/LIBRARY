using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
    public class ClassComment
    {
        private string commentIsbn;
        private string userId;
        private DateTime commentTime;
        private string text;

        public string CommentIsbn
        {
            get
            {
                return commentIsbn;
            }

            set
            {
                commentIsbn = value;
            }
        }

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

        public DateTime CommentTime
        {
            get
            {
                return commentTime;
            }

            set
            {
                commentTime = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public ClassComment()
        {

        }
    }
}