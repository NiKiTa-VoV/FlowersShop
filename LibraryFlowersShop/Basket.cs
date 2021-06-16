using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFlowersShop
{
    public static class Basket
    {
        public static List<Flower> Flowers { get; set; } = new List<Flower>();
        public static double AllPrice { get; set; }
        public static double Price { get; set; }
    }
}
