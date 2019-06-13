using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguagesFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products) { 
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByPrice(
            this IEnumerable<Product> productEum, decimal minumumPrice)
        {
            foreach (Product prod in productEum)
            {
                if ((prod?.Price ?? 0) >= minumumPrice)
                {
                    yield return prod;
                }
            }
        }
    }
}
