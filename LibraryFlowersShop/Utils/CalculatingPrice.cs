using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFlowersShop.Utils
{
    public static class CalculatingPrice
    {
        public static double Calculating()
        {
            double price = 0;
            foreach (var flower in Basket.Flowers)
            {
                price += flower?.Price ?? 0.0;
            }
            return price;
        }
    }
}
