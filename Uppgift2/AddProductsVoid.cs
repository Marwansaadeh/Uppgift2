using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class AddProductsVoid
    {
        public static void AddProduct()
        {
            while (true)
            {


                List<Product> products = new List<Product>();
                Product product= new Product();
                Console.WriteLine("lägg en ny produkt");
                Console.WriteLine("Skriva produkt ID");
                bool check = true;
                bool ch = true;
                do
                {

                    int Id;

                    ch = int.TryParse(Console.ReadLine(), out Id);

                    product.ProductId = Id;

                    List<Product> allaproducts = FileManager.ReadllAllProductst();

                    int x = allaproducts.Count(p => p.ProductId == product.ProductId);
                    if (x == 1)
                    {
                        check = false;
                        Console.WriteLine("ID finns redan, skriva ny Id för att lägga till en ny produkt");
                    }
                    else check = true;

                    if (ch == false)
                    {
                        Console.WriteLine("Please write an integer");

                    }
                } while (check == false || ch == false);

                Console.WriteLine("Äng ProduktNamn");

                product.ProductName = Console.ReadLine();

                Console.WriteLine("Skriv ProduktPrice");

                product.Price = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Välj pricetype 1 eller 2");

                Console.WriteLine("1: " + Product.PriceType.perkilo);
                Console.WriteLine("2: " + Product.PriceType.perstyck);

                byte userchoice = Convert.ToByte(Console.ReadLine());
                if (userchoice == 1) { product.Pricetype = Product.PriceType.perkilo; }
                else product.Pricetype = Product.PriceType.perstyck;

                Console.WriteLine("Skriv CampainPrise");

                product.CampgainPrice = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("start date");

                product.StartCampgainDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("end date");

                product.EndCampgainDate = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("Skriv ProductMax Number");

                product.Max = Convert.ToDecimal(Console.ReadLine());

                products.Add(product);

                FileManager.Productstoadd(products);
                Console.WriteLine("Vill du avsluta lägga till produkter, j eller n ?");
                string answer = Console.ReadLine();
                if (answer == "j")
                {
                    break;
                }

            }


        }

    }

}
