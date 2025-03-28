using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class CurrencyConverter
    {
        private static readonly Dictionary<string, decimal> ConversionRates = new()
    {
       { "USD", 1 },
       { "GBP", 0.72m },
       { "SEK", 8.41m },
       { "EUR", 0.85m }
    };
        public static decimal ConvertToCurrency(decimal amountInUSD, string currency)
        {
            if (ConversionRates.TryGetValue(currency, out var rate))
            {
                return amountInUSD * rate;
            }
            throw new ArgumentException($"Currency '{currency}' not supported");
        }
    }
}
