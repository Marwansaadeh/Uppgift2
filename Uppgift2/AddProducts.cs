using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    //class AddProducts
    //{
    //    public static void AddProductsMethod(List<Product> productstoadd)
    //    {

    //        string path = "..\\..\\ProductFile\\Products.txt";

    //        if (!File.Exists(path))
    //        {
    //            using (StreamWriter sw = File.CreateText(path))
    //            {
    //                foreach (var item in productstoadd)
    //                {
    //                    sw.WriteLine((Int32)item.ProductId);
    //                    sw.WriteLine(item.ProductName);
    //                    sw.WriteLine((decimal)item.Price);
    //                    sw.WriteLine(item.Pricetype);
    //                    sw.WriteLine(item.CampgainPrice);
    //                    sw.WriteLine(item.StartCampgainDate);
    //                    sw.WriteLine(item.EndCampgainDate);
    //                    sw.WriteLine(item.Max);
    //                }

    //            }
    //        }
    //        else
    //        {
    //            using (StreamWriter sw = new StreamWriter(path, true))

    //            {
    //                foreach (var item in productstoadd)
    //                {
    //                    sw.WriteLine((Int32)item.ProductId);
    //                    sw.WriteLine(item.ProductName);
    //                    sw.WriteLine((decimal)item.Price);
    //                    sw.WriteLine(item.Pricetype);
    //                    sw.WriteLine(item.CampgainPrice);
    //                    sw.WriteLine(item.StartCampgainDate);
    //                    sw.WriteLine(item.EndCampgainDate);
    //                    sw.WriteLine(item.Max);


    //                }

    //            }

    //        }
    //    }

    //}
}
