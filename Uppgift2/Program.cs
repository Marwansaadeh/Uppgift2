using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt R = new Receipt();
            List<Product> products = new List<Product>{

               // new Product {ProductName="marwan", Price=15.5m, ProductCount =5, ProductId=1},
               //new Product {ProductName="tarek", Price=16.5m, ProductCount =8, ProductId=2},

            };

            Product x = new Product();
            x.ProductId = 1;
            x.ProductName = "Marwan";
            x.Price = 5;
            x.ProductCount = 5;
           

            R.ProductReceipt = products;
            R.AddToList(x);

            Product Y = new Product();
            Y.ProductId = 1;
            Y.ProductName = "Marwan";
            Y.Price = 5;
            Y.ProductCount = 5;


            R.ProductReceipt = products;
            R.AddToList(Y);

            

            Product c = new Product();
            c.ProductId = 1;
            c.ProductName = "Marwan";
            c.Price = 5;
            c.ProductCount = 1;
            R.ReturnProduct(c);

            Product y = new Product();
            y.ProductId = 2;
            y.ProductName = "Tarek";
            y.Price = 5;
            y.ProductCount = 8;
            R.ProductReceipt = products;
            R.AddToList(y);

            //R.CurrentProducts();
            //R.ProductReceipt = products;

            R.date = DateTime.Now.Date;
            R.KvittoNumber = 1;
            R.SetTotalPayment();
            
            Console.WriteLine(R.ShowPaymentDetails());
            
            Console.ReadLine();
        }
    }
}
