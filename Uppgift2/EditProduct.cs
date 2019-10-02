using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class EditProduct
    {
        public static void EditProductMethod(Product editproduct)
        {
            string path = "..\\..\\ProductFile\\Products.txt";

            List<Product> product = FileManager.ReadllAllProductst();



            using (StreamWriter sw = new StreamWriter(path, true))

            {
                foreach (var item in product)
                {
                    if (item.ProductId == editproduct.ProductId)
                    {
                        item.ProductName = editproduct.ProductName;
                        item.Price = editproduct.Price;
                        item.CampgainPrice = editproduct.CampgainPrice;
                        item.StartCampgainDate = editproduct.StartCampgainDate;
                        item.EndCampgainDate = editproduct.EndCampgainDate;
                        item.Max = editproduct.Max;
                    }


                }


            }
            File.Delete(path);
            FileManager.Productstoadd(product);
        }
    }
}
