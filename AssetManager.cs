using System;
using System.Collections.Generic;

namespace V3miniProject
{
    public class AssetManager
    {
        private static readonly Office usaOffice = new Office("New York Office", "USD");
        private static readonly Office swedenOffice = new Office("Stockholm Office", "SEK");
        private static readonly Office germanyOffice = new Office("Berlin Office", "EUR");

        private void AddSmartphones(AssetTracker tracker)
        {
            tracker.AddAsset(new Smartphone(new Price(200, Currency.USD), DateTime.Now.AddMonths(-32), "Motorola", "X3", usaOffice));
            tracker.AddAsset(new Smartphone(new Price(400, Currency.USD), DateTime.Now.AddMonths(-31), "Motorola", "X3", usaOffice));
            tracker.AddAsset(new Smartphone(new Price(400, Currency.USD), DateTime.Now.AddMonths(-26), "Motorola", "X2", usaOffice));
            tracker.AddAsset(new Smartphone(new Price(4500, Currency.SEK), DateTime.Now.AddMonths(-30), "Samsung", "Galaxy 10", swedenOffice));
            tracker.AddAsset(new Smartphone(new Price(4500, Currency.SEK), DateTime.Now.AddMonths(-29), "Samsung", "Galaxy 10", swedenOffice));
            tracker.AddAsset(new Smartphone(new Price(3000, Currency.SEK), DateTime.Now.AddMonths(-32), "Sony", "XPeria 7", swedenOffice));
            tracker.AddAsset(new Smartphone(new Price(3000, Currency.SEK), DateTime.Now.AddMonths(-31), "Sony", "XPeria 7", swedenOffice));
            tracker.AddAsset(new Smartphone(new Price(220, Currency.EUR), DateTime.Now.AddMonths(-24), "Siemens", "Brick", germanyOffice));
        }

        private void AddComputers(AssetTracker tracker)
        {
            tracker.AddAsset(new Computer(new Price(100, Currency.USD), DateTime.Now.AddMonths(-38), "Dell", "Desktop 900", usaOffice));
            tracker.AddAsset(new Computer(new Price(100, Currency.USD), DateTime.Now.AddMonths(-37), "Dell", "Desktop 900", usaOffice));
            tracker.AddAsset(new Computer(new Price(300, Currency.USD), DateTime.Now.AddMonths(-35), "Lenovo", "X100", usaOffice));
            tracker.AddAsset(new Computer(new Price(300, Currency.USD), DateTime.Now.AddMonths(-32), "Lenovo", "X200", usaOffice));
            tracker.AddAsset(new Computer(new Price(500, Currency.USD), DateTime.Now.AddMonths(-27), "Lenovo", "X300", usaOffice));
            tracker.AddAsset(new Computer(new Price(1500, Currency.SEK), DateTime.Now.AddMonths(-29), "Dell", "Optiplex 100", swedenOffice));
            tracker.AddAsset(new Computer(new Price(1400, Currency.SEK), DateTime.Now.AddMonths(-28), "Dell", "Optiplex 200", swedenOffice));
            tracker.AddAsset(new Computer(new Price(1300, Currency.SEK), DateTime.Now.AddMonths(-27), "Dell", "Optiplex 300", swedenOffice));
            tracker.AddAsset(new Computer(new Price(1600, Currency.EUR), DateTime.Now.AddMonths(-22), "Asus", "ROG 600", germanyOffice));
            tracker.AddAsset(new Computer(new Price(1200, Currency.EUR), DateTime.Now.AddMonths(-32), "Asus", "ROG 500", germanyOffice));
            tracker.AddAsset(new Computer(new Price(1200, Currency.EUR), DateTime.Now.AddMonths(-33), "Asus", "ROG 500", germanyOffice));
            tracker.AddAsset(new Computer(new Price(1300, Currency.EUR), DateTime.Now.AddMonths(-34), "Asus", "ROG 500", germanyOffice));
        }

        private void AddAsset(AssetTracker tracker, decimal price, Currency currency, int monthsAgo, string brand, string model, Office office, AssetType assetType)
        {
            Asset asset = assetType switch
            {
                AssetType.Smartphone => new Smartphone(new Price(price, currency), DateTime.Now.AddMonths(-monthsAgo), brand, model, office),
                AssetType.Computer => new Computer(new Price(price, currency), DateTime.Now.AddMonths(-monthsAgo), brand, model, office),
                _ => throw new ArgumentException("Invalid asset type")
            };
            tracker.AddAsset(asset);
        }

        internal void AddAssets(AssetTracker tracker, decimal price, Currency currency, int monthsAgo, string? brand, string? model, Office office, AssetType type)
        {
            AddAsset(tracker, price, currency, monthsAgo, brand, model, office, type);
        }
    }

    public enum AssetType
    {
        Smartphone,
        Computer
    }
}