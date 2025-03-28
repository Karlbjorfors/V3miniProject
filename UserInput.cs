using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class UserInput
    {
        public static void AddAssetsFromUserInput(AssetTracker tracker, AssetManager assetManager)
        {
            while (true)
            {
                Console.WriteLine("Enter asset type (Smartphone/Computer) or 'q' to quit:");
                string assetType = Console.ReadLine();
                if (assetType.ToLower() == "q")
                {
                    break;
                }

                if (assetType != "Smartphone" && assetType != "Computer")
                {
                    Console.WriteLine("Invalid asset type. Please enter 'Smartphone' or 'Computer'.");
                    continue;
                }

                Console.WriteLine("Enter brand:");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter model:");
                string model = Console.ReadLine();

                string officeName;
                Office office;
                while (true)
                {
                    Console.WriteLine("Enter office (New York Office/Stockholm Office/Berlin Office):");
                    officeName = Console.ReadLine();
                    office = officeName switch
                    {
                        "New York Office" => new Office("New York Office", "USD"),
                        "Stockholm Office" => new Office("Stockholm Office", "SEK"),
                        "Berlin Office" => new Office("Berlin Office", "EUR"),
                        _ => null
                    };
                    if (office != null)
                        break;
                    Console.WriteLine("Invalid office name. Please enter 'New York Office', 'Stockholm Office', or 'Berlin Office'.");
                }

                decimal price;
                while (true)
                {
                    Console.WriteLine($"Enter price in {office.Currency}:");
                    if (decimal.TryParse(Console.ReadLine(), out price))
                        break;
                    Console.WriteLine("Invalid price. Please enter a valid decimal number.");
                }

                DateTime purchaseDate;
                while (true)
                {
                    Console.WriteLine("Enter purchase date (yyyy-mm-dd):");
                    if (DateTime.TryParse(Console.ReadLine(), out purchaseDate))
                        break;
                    Console.WriteLine("Invalid date format. Please enter a valid date in yyyy-mm-dd format.");
                }

                AssetType type = assetType switch
                {
                    "Smartphone" => AssetType.Smartphone,
                    "Computer" => AssetType.Computer,
                    _ => throw new ArgumentException("Invalid asset type")
                };

                Currency currency = office.Currency switch
                {
                    "USD" => Currency.USD,
                    "SEK" => Currency.SEK,
                    "EUR" => Currency.EUR,
                    _ => throw new ArgumentException("Invalid currency")
                };

                assetManager.AddAssets(tracker, price, currency, (DateTime.Now - purchaseDate).Days / 30, brand, model, office, type);
            }

            DisplayAssets(tracker);
        }

        private static void DisplayAssets(AssetTracker tracker)
        {
            var assets = tracker.GetAssets();
            Console.WriteLine("List of all assets:");
            foreach (var asset in assets)
            {
                Console.WriteLine($"Type: {asset.GetType().Name}, Brand: {asset.Brand}, Model: {asset.ModelName}, Price: {asset.Price}, Purchase Date: {asset.PurchaseDate.ToShortDateString()}, Office: {asset.Office.OfficeName}");
            }
        }
    }
}
