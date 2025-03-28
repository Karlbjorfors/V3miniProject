using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class Smartphone : Asset
    {
        public Smartphone(Price price, DateTime purchaseDate, string brand, string model, Office office)
       : base($"{brand} {model}", purchaseDate, price.Amount, office) { }       
    }
}
