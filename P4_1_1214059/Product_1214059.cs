using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214059
{
    public class Product_1214059
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;

        public Product_1214059()
        {

        }

        public Product_1214059(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myType = value;
            }
        }
    }
}