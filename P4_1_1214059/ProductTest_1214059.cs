using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214059
{
    internal class ProductTest_1214059
    {
        static void Main(string[] args)
        {
            /* Product_1214059 myProduct = new Product_1214059();

            myProduct.MyType = "DVD";
            
            Console.WriteLine(myProduct.MyType); */

            Book_1214059 product1 = new Book_1214059("Book", "C# Object Oriented Solution", "300");
            DVD_1214059 product2 = new DVD_1214059("Hulk", "110");

            // Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
