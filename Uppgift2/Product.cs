using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Product
    {

        public int ProductId { get; set; }
        public decimal Price { get; set; }

        public string ProductName { get; set; }

        public PriceType Pricetype { get; set; }

        public decimal CampgainPrice { get; set; }

        public DateTime StartCampgainDate { get; set; }

        public DateTime EndCampgainDate { get; set; }

        public decimal ProductTotalCost { get; private set; }

        public decimal Max { get; set; }
        public decimal ProductCount { get; set; }

        public enum PriceType
        {
            perkilo,
            perstyck,
        }

        public void ProduktPrice()
        {
            if (DateTime.Now.Date >= this.StartCampgainDate.Date && DateTime.Now.Date <= EndCampgainDate.Date
                && CampgainPrice != 0)
            {
                this.Price = CampgainPrice;
            }
            else
            {
                this.Price = this.Price;
            }

        }
        public void SetProductTotalCost()
        {
            this.ProductTotalCost = this.ProductCount * this.Price;
        }
        public decimal IsLessThanMax()
        {
            if ( this.ProductCount<=Max)
            {
                this.ProductCount += 0;
                return this.ProductCount;
            }
               
            
            else
                return 0;
        }

    }
}
