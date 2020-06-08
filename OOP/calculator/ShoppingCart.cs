using System;
using System.Collections.Generic;

namespace calculator
{
    public class Product
    {
        string name;
        public int Price;
    }
    // Assume this is the class provided that we can not edit.
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
    }
    // This is the wrapper for our extension
    // Note the static keyword
    public static class MyExtensionMethods
    {
        // Note how the parameters for the new function is previous class
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total;
        }

        // This method is added to everything that uses the CanRun interface though!
        /*
        public static double MarathonDistance(this CanRun creature)
        {
            creature.Run();
            Console.WriteLine("I'm running a marathon now!");
            return 26.2;
        }
        */
    }
}
