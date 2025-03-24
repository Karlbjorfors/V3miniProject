using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//Step 1: Define Classes and Properties
public class Asset//Base class
{
    public string ModelName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal PriceInUSD { get; set; }

    public Asset(string ModelName, DateTime PurchaseDate, decimal PriceInUSD);
    {
        ModelName = modelName;
        PurchaseDate = purchaseDate;
        PriceInUSD = priceInUSD;
    }
}
//Derived class 1
public class Laptop : Asset
{
    public Laptop(string ModelName, DateTime PurchaseDate, decimal PriceInUSD)
        : base(ModelName, PurchaseDate, PriceInUSD) { }
}

//Derived class 2
public class MobilePhone : Asset
{
    public MobilePhone(string ModelName, DateTime PurchaseDate, decimal PriceInUSD) 
        : base(ModelName, PurchaseDate, PriceInUSD) { }
}

//Office Class
public class Office
{
    public List<Asset> Assets { get; set; }
    public string OfficeName { get; set; }
    public string Currency { get; set; }
    public Office(string OfficeName, string Currency)
    {
        OfficeName = officeName;
        Currency = currency;
        Assets = new List<Asset>();
    }
}




//Step 2: Implement Currency Conversion

//Step 3: Input and Store Data

//Step 4: Sorting and Color-Coding

//Step 5: Display Data

//Step 6: Integrate All Components