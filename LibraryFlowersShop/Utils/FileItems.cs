using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFlowersShop.Utils
{
    public static class FileItems
    {
        public static List<Flower> Read(string path)
        {
            List<Flower> flowers = new List<Flower>();
            string name = "";
            double price = 0;
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (line != "")
                {
                    if (!double.TryParse(line, out price))
                        name = line;
                }
                else
                    flowers.Add(new Flower(price,name));
            }
            return flowers;
        }
    }
}
