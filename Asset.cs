using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class Asset
    {
        public string ModelName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public Office Office { get; set; }
        public object Brand { get; internal set; }

        public Asset(string modelName, DateTime purchaseDate, decimal price, Office office)
        {
            ModelName = modelName;
            PurchaseDate = purchaseDate;
            Price = price;
            Office = office;
        }
    }
}
