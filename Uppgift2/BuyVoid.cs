using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class BuyVoid
    {
        static int ProductID = 0;
        static int Count = 0;
        public static void PaymentProcess()
        {
            Console.Clear();
            Receipt R = new Receipt();
            List<Product> products = new List<Product> { };
            List<Product> productsporchases = new List<Product> { };
            Product product = new Product();
            bool CheckProductID;
            bool ProductCount;
            int x = 0;

            string answer = "";
            while (true)
            {
                do
                {

                    Console.WriteLine("Kommandon:");
                    Console.WriteLine("<ProductID> <antal>");
                    do
                    {
                        string[] values = Console.ReadLine().Split(' ');
                        CheckProductID = int.TryParse(values[0], out ProductID);
                        ProductCount = int.TryParse(values[1], out Count);

                        if (CheckProductID == false)
                        {
                            Console.WriteLine("Write numbers");
                        }
                            
                       else if(ProductCount==false)
                        {
                            Console.WriteLine("Write numbers");
                        }
                        
                    } while (CheckProductID == false || ProductCount == false);
                    Console.Clear();
                    products = FileManager.ReadllAllProductst();
                    product.ProductId = ProductID;
                    int ch = products.Count(p => p.ProductId == product.ProductId);
                    x = ch;
                    if (ch == 0)
                    {

                        Console.WriteLine("Fel ProduktNummer");

                    }
                } while (CheckProductID == false || ProductCount == false || x == 0);

                Console.Clear();
                 
                Product product1 = products.Find(p => p.ProductId == product.ProductId);

                product1.ProduktPrice();
                product1.ProductCount = Count;
                R.ProductReceipt = productsporchases;
                if (product1.ProductCount > product1.Max)
                {
                    Console.WriteLine($"Kunden kan inte köpa mer än {product1.Max} för den här produkten, försök igen");
                }

                R.AddTest(product1);
                R.SetKvittoNumber();
                Console.WriteLine(R.ShowPaymentDetails());
               
                Console.WriteLine("Vill du avsluta j eller n");

                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "J")
                {
                    FileManager.SaveReceipt(R);

                    MainMenu.PrintStartMenu();
                    break;
                }; 

                Console.WriteLine("Vill du Return en product");

                string answer2 = Console.ReadLine();
                answer2 = answer2.ToUpper();
                if (answer2 == "J")
                {
                    int count2;
                    int ID;
                    int ch;
                    Product p = new Product();

                    do
                    {
                        

                        Console.WriteLine("Skriv produktID och hur många vill return");

                        Console.WriteLine("Kommandon:");
                        Console.WriteLine("<ProductID> <antal>");
                        string[] values = Console.ReadLine().Split(' ');
                        CheckProductID = int.TryParse(values[0], out ID);
                        p.ProductId = ID;
                        ProductCount = int.TryParse(values[1], out count2);
                        ch = productsporchases.Count(b => b.ProductId == p.ProductId);
                        
                        if (ch == 0)
                        {

                            Console.WriteLine("Fel ProduktNummer eller produktNummer finns inte");

                        }

                    } while (CheckProductID == false || ProductCount == false || ch==0);

                   
                   
                    p.ProductCount = count2;


                    R.ReturnProduct(p);
                    Console.Clear();
                    Console.WriteLine(R.ShowPaymentDetails());
                }


            }

        }
    }
}
