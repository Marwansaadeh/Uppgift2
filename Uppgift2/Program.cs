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

           
            



            

            
            Product y = new Product();
            y.ProductId = 2;
            y.ProductName = "Tarek";
            y.Price = 5;
            y.Max = 5;
            y.ProductCount = 3;
            R.ProductReceipt = products;

            R.AddTest(y);

            Product m = new Product();
            m.ProductId = 2;
            m.ProductName = "Tarek";
            m.Price = 5;
            m.Max = 5;
            m.ProductCount = 2;
            R.ProductReceipt = products;
            R.AddTest(m);
            R.ReturnProduct(m);

            Product x = new Product();
            x.ProductId = 1;
            x.ProductName = "Marwan";
            x.Price = 5;
            x.ProductCount = 1;
            x.Max = 2;
            R.ProductReceipt = products;
            R.AddTest(x);

            Product xx = new Product();
            xx.ProductId = 4;
            xx.ProductName = "Marwan";
            xx.Price = 5;
            xx.ProductCount = 1;
            xx.Max = 6;
            R.ProductReceipt = products;
            R.AddTest(xx);

            Product gg = new Product();
            gg.ProductId = 4;
            gg.ProductName = "Marwan";
            gg.Price = 5;
            gg.ProductCount = 3;
            gg.Max = 6;
            R.ProductReceipt = products;
            R.AddTest(gg);


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
