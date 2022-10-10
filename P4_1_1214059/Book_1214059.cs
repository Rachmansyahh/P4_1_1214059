using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214059
{
    internal class Book_1214059 : Product_1214059
    {
        protected string pageCount;

        public Book_1214059(string type, string title, string pagecount) : base (type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
