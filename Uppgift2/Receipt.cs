using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Receipt
    {
        public List<Product> ProductReceipt { get; set; }

        public DateTime date = DateTime.Now;

        public int KvittoNumber;
        public decimal TotalPayment { get; private set; }

        public void SetTotalPayment()
        {         
            foreach (var item in ProductReceipt)
            {
                TotalPayment += item.ProductTotalCost;
            }
           
        }

        public decimal? Rabbat()
        {
            if (TotalPayment > 1000 && TotalPayment <= 2000)
            {
                return (TotalPayment * 0.9m) - TotalPayment;

            }
            else if (TotalPayment > 2000)
            {
                return (TotalPayment * 0.8m) - TotalPayment;

            }
            else
            {
                return null;
            }

        }

        public string ShowPaymentDetails()
        {
            StringBuilder details = new StringBuilder();
            foreach (var item in ProductReceipt)
            {
                    item.SetProductTotalCost();
                
                details.Append($"{item.ProductName} * {item.ProductCount} = {item.ProductTotalCost}\n");
               
            }

            if (Rabbat() != null)
            {
                details.Append($"\nRabbat:{Rabbat().ToString()}");
                if (this.TotalPayment > 1000 && this.TotalPayment <= 2000) { details.Append($"\nTotal:{this.TotalPayment + Rabbat()}").ToString(); }
                else if (this.TotalPayment > 2000) { details.Append($"\nTotal:{this.TotalPayment + Rabbat()}").ToString(); }
            }
            SetTotalPayment();
            details.Append($"Total: {this.TotalPayment.ToString()}");

            return $"Kvitto {this.date}\nkivttonumber:{KvittoNumber}\n{details}\n";

        }

        public bool IsProductExsist(Product P)
        {
            Product ProductisExisit = ProductReceipt.FirstOrDefault(x => x.ProductId == P.ProductId);
            if (ProductisExisit!=null) return true;
            else return false;
        }

        //public void AddToList(Product G)
        //{

        //    if (ProductReceipt == null)
        //    {

        //        ProductReceipt.Add(G);
        //    }
        //    else if (IsProductExsist(G))
        //    {
        //        foreach (var item in ProductReceipt)
        //        {
        //            if (item.ProductId == G.ProductId)
        //            {
        //                item.ProductCount += G.ProductCount;
        //            }

        //        }
        //    }
        //    else { ProductReceipt.Add(G); }

          
        //}

        public void ReturnProduct(Product G)
        {

            
             if (IsProductExsist(G))
            {
                
               
                foreach (var item in ProductReceipt)
                {
                    if (G.ProductCount >= item.ProductCount)
                    {
                        ProductReceipt.Remove(item);
                        break;
                     }
                   else if (item.ProductId == G.ProductId && G.ProductCount<item.ProductCount)
                    {

                        item.ProductCount = item.ProductCount - G.ProductCount;
                    }
                   

                }


            }
           


        }
      public void AddTest(Product G)
        {
             if (IsProductExsist(G) &&G.IsLessThanMax()!=0)
            {
                foreach (var item in ProductReceipt)
                {
                    if (item.ProductId == G.ProductId)
                    {
                        decimal value = item.ProductCount += G.ProductCount;
                        if (value<G.Max)
                        {
                            item.ProductCount = value;
                        }
                        else
                        {
                            item.ProductCount = value-G.ProductCount;
                        }
                    }

                }
            }

            else if(G.IsLessThanMax() != 0 && !IsProductExsist(G))
            {
                ProductReceipt.Add(G);
            }
            
        }

    }
}
