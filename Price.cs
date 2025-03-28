using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class Price
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        public Price(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
