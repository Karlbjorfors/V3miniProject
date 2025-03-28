using System;
using System.Collections.Generic;
using System.Linq;

namespace V3miniProject
{
    public class AssetDisplay
    {
        public void DisplayAssets(List<Asset> sortedAssets)
        {
            var groupedAssets = sortedAssets.GroupBy(a => ((dynamic)a).Office.OfficeName);

            foreach (var group in groupedAssets)
            {
                Console.WriteLine($"Office: {group.Key}");
                foreach (var asset in group)
                {
                    var priceInOfficeCurrency = CurrencyConverter.ConvertToCurrency(asset.Price, asset.Office.Currency);
                    var color = GetColorCode(asset.PurchaseDate);
                    Console.WriteLine($"{color}Model: {asset.ModelName}, Purchase Date: {asset.PurchaseDate.ToShortDateString()}, Price in {asset.Office.Currency}: {priceInOfficeCurrency}{ResetColor()}");
                }
                Console.WriteLine();
            }
        }

        private string GetColorCode(DateTime purchaseDate)
        {
            var timeToEndOfLife = purchaseDate.AddYears(3) - DateTime.Now;
            if (timeToEndOfLife <= TimeSpan.FromDays(90))
            {
                return "\u001b[31m"; // Red
            }
            else if (timeToEndOfLife <= TimeSpan.FromDays(180))
            {
                return "\u001b[33m"; // Yellow
            }
            else
            {
                return "\u001b[32m"; // Green
            }
        }

        private string ResetColor()
        {
            return "\u001b[0m"; // Reset color
        }
    }
}
