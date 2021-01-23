using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shopProductInfo = new Dictionary<string, Dictionary<string, double>>();
            while (input != "Revision")
            {
                string[] arguments = input.Split(", ");
                string shop = arguments[0];
                string product = arguments[1];
                double price = double.Parse(arguments[2]);
                if (!shopProductInfo.ContainsKey(shop))
                {
                    shopProductInfo.Add(shop, new Dictionary<string, double>());
                    shopProductInfo[shop].Add(product, price);
                }
                else
                {
                    shopProductInfo[shop].Add(product, price);
                }
                input = Console.ReadLine();
            }
            foreach (var shop in shopProductInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var productPricePair in shop.Value)
                {
                    Console.WriteLine($"Product: {productPricePair.Key}, Price: {productPricePair.Value}");
                }
            }
        }
    }
}