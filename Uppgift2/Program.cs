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
            //Receipt R = new Receipt();
            //List<Product> products = new List<Product>{

            //   // new Product {ProductName="marwan", Price=15.5m, ProductCount =5, ProductId=1},
            //   //new Product {ProductName="tarek", Price=16.5m, ProductCount =8, ProductId=2},

            //};

            MainMenu.PrintStartMenu();
            BuyVoid.PaymentProcess();
            //AddProductsVoid.AddProduct();





            //Product y = new Product();
            //y.ProductId = 2;
            //y.ProductName = "Tarek";
            //y.Price = 5;
            //y.Max = 5;
            //y.ProductCount = 3;
            //R.ProductReceipt = products;

            //R.AddTest(y);


            //Console.WriteLine(R.ShowPaymentDetails());

            //Console.ReadLine();
        }
    }
}
