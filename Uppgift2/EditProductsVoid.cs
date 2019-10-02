using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class EditProductsVoid
    {
        public static void EditProducts()
        {
            while (true)
            {
                Console.WriteLine("Write a Productname to edite a");


                Product product;

                bool check = true;
                do
                {
                    List<Product> allaproducts = FileManager.ReadllAllProductst();

                    int id = 0;

                    Console.WriteLine("Äng ProduktNamn");
                    Product input = new Product();
                    input.ProductId = id;
                    input.ProductName = Console.ReadLine();

                    id = allaproducts.Find(p => p.ProductName == input.ProductName).ProductId;

                    product = new Product();
                    product.ProductId = id;
                    int x = allaproducts.Count(p => p.ProductName == input.ProductName);

                    if (x == 1)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false; Console.WriteLine("name not exsist");
                    };
                } while (check == false);

                Console.WriteLine("Skriv a new product name");

                product.ProductName = Console.ReadLine();

                Console.WriteLine("Skriv ProduktPrice");

                product.Price = Convert.ToDecimal(Console.ReadLine());



                Console.WriteLine("If the product has compain price add it");

                product.CampgainPrice = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("start date");

                product.StartCampgainDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("end date");

                product.EndCampgainDate = DateTime.Parse(Console.ReadLine());

                EditProduct.EditProductMethod(product);
                Console.WriteLine("Vill du justera en ny produkt, j eller n ?");
                string answer = Console.ReadLine();
                if (answer == "j")
                {
                    break;
                }

            }

        }

    }
}
