using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
//Files and classes are in the same namespace
/*
1.	Asset: Base class for assets.
2.	Smartphone: Derived class for smartphones.
3.	Computer: Derived class for computers.
4.	Office: Represents an office with a name and currency.
5.	CurrencyConverter: Handles currency conversion.
6.	Price: Represents the price of an asset.
7.	AssetTracker: Manages the collection of assets.
8.	AssetManager: Handles the addition of assets.
9.	AssetSorter: Handles the sorting of assets.
10.	AssetDisplay: Handles the display of assets.
11.	AssetsData: Main entry point that integrates all components.
12.	UserInput: Handles user input for adding assets.
 */
public enum Currency
{
    USD,
    GBP,
    SEK,
    EUR
}
