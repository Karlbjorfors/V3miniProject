using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

//Step 1: Define Classes and Properties
public class Asset //Base class
{
    public string ModelName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal Price { get; set; }

    public Asset(string modelName, DateTime purchaseDate, decimal price)
    {
        ModelName = modelName;
        PurchaseDate = purchaseDate;
        Price = price;
    }
}

// Currency
public enum Currency
{
    USD,
    GBP,
    SEK,
    EUR
}
// Price class
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

//Derived class 1
public class SmartPhone : Asset
{
    public SmartPhone(Price price, DateTime purchaseDate, string brand, string model, Office office)
        : base($"{brand} {model}", purchaseDate, price.Amount)
    {
        Office = office;
        Price = price;
    }

    public Office Office { get; set; }
    public Price Price { get; set; }
}
//Derived class 2
public class Computer : Asset
{
    public Computer(Price price, DateTime purchaseDate, string brand, string model, Office office)
        : base($"{brand} {model}", purchaseDate, price.Amount)
    {
        Office = office;
        Price = price;
    }

    public Office Office { get; set; }
    public Price Price { get; set; }
}
    //Office Class
    public class Office
{
    public string OfficeName { get; set; }
    public string Currency { get; set; }
    public Office(string OfficeName, string Currency)
    {
        OfficeName = officeName;
        Currency = currency;
    }
}


//Step 2: Implement Currency Conversion
public static class CurrencyConverter
{
   private static readonly Dictionary<string, decimal> ConversionRates = new Dictionary<string, decimal>
   {
       { "USD", 1 },
       { "GBP", 0.72m },
       { "SEK", 8.41m }
   };
    public static decimal ConvertToCurrency(decimal amountInUSD, string currency)
    {
        if (ConversionRates.ContainsKey(currency))
        {
            return amountInUSD * ConversionRates[currency];
        }
        throw new ArgumentException("Currency not supported");
    }
}


//Step 3: Input and Store Data
public class Program
{
    public static void Main()
    {
        var assets = new List<Asset>
        {
            new Laptop("Dell XPS 13", new DateTime(2020, 1, 1), 1200),
            new MobilePhone("iPhone 12", new DateTime(2020, 12, 1), 1000),
            new Laptop("MacBook Pro", new DateTime(2019, 6, 15), 2500),
            new MobilePhone("Samsung Galaxy S20", new DateTime(2021, 3, 10), 900),
            new Laptop("Lenovo ThinkPad", new DateTime(2022, 5, 20), 1500)
        };
        
        var offices = new List<Office>
        {
            new Office("New York Office", "USD"),
            new Office("London Office", "GBP"),
            new Office("Stockholm Office", "SEK")
        };

        {
            var priceInOfficeCurrency = CurrencyConverter.ConvertToCurrency(asset.PriceInUSD, office.Currency);
            Console.WriteLine($"Model: {asset.ModelName}, Purchase Date: {asset.PurchaseDate}, Price in {office.Currency}: {priceInOfficeCurrency}");
        }
    }
}


//Step 4: Sorting and Color-Coding



//Step 5: Display Data



//Step 6: Integrate All Components


