using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFlowersShop
{
    public class Flower
    {
        public Flower(double price, string name)
        {
            Price = price;
            Name = name;
        }
        public string Name { get; set; }
        public double Price { get; set; }



    }
}
