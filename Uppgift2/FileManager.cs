using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class FileManager
    {

        string date = DateTime.Now.ToString("yyyyMMdd");

        public static void SaveReceipt(Receipt R)
        {
            string date = DateTime.Now.ToString("yyyyMMdd");


            string path = $@"..\..\Kvitto_{date}.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine(R.ShowPaymentDetails());

                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))

                {
                    sw.WriteLine(R.ShowPaymentDetails());


                }

            }
        }


        public static List<Product> ReadllAllProductst()
        {
            List<Product> products = new List<Product>();
            string path = "..\\..\\ProductFile\\Products.txt";
            if (!File.Exists(path))
            {
                Productstoadd(products);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";

                while (true)
                {
                    if (File.Exists(path))
                    {
                        Product product = new Product();
                        product.ProductId = Convert.ToInt32(line = sr.ReadLine());
                        product.ProductName = (line = sr.ReadLine());
                        if (line == null)
                        {
                            break;
                        }
                        product.Price = Convert.ToDecimal((line = sr.ReadLine()));

                        product.Pricetype = (Product.PriceType)Enum.Parse(typeof(Product.PriceType), line = sr.ReadLine(), true);

                        product.CampgainPrice = Convert.ToDecimal((line = sr.ReadLine()));
                        product.StartCampgainDate = Convert.ToDateTime((line = sr.ReadLine()));
                        product.EndCampgainDate = Convert.ToDateTime((line = sr.ReadLine()));
                        product.Max= Convert.ToDecimal((line = sr.ReadLine()));

                        products.Add(product);

                    }

                }

                return products;
            }

        }
        public static List<string> ReadReceipt(DateTime date)
        {
            List<string> receipts = new List<string>();
            string item = date.ToString("yyyyMMdd");

            string path = $@"..\..\Kvitto_{item}.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";

                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null)
                    {

                        break;

                    }

                    if (line.Contains("kivttonumber"))
                    {

                        receipts.Add(line);
                    }

                    if (line.Contains("Total") && !line.Contains("TotalItems"))
                    {

                        receipts.Add(line);

                    }
                    if (line == null)
                    {

                        continue;
                    }

                }
                return receipts;

            }

        }

        public static void Productstoadd(List<Product> productstoadd)
        {

            string path = "..\\..\\ProductFile\\Products.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in productstoadd)
                    {
                        
                        sw.WriteLine((Int32)item.ProductId);
                        sw.WriteLine(item.ProductName);
                        sw.WriteLine((decimal)item.Price);
                        sw.WriteLine(item.Pricetype);
                        sw.WriteLine(item.CampgainPrice);
                        sw.WriteLine(item.StartCampgainDate);
                        sw.WriteLine(item.EndCampgainDate);
                        sw.WriteLine(item.Max);


                    }

                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))

                {
                    foreach (var item in productstoadd)
                    {

                        sw.WriteLine((Int32)item.ProductId);
                        sw.WriteLine(item.ProductName);
                        sw.WriteLine((decimal)item.Price);
                        sw.WriteLine(item.Pricetype);
                        sw.WriteLine(item.CampgainPrice);
                        sw.WriteLine(item.StartCampgainDate);
                        sw.WriteLine(item.EndCampgainDate);
                        sw.WriteLine(item.Max);



                    }

                }

            }
        }



    }

}


    

