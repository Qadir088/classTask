using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Koton", "shoes", 100, 100, 5,0);
            product.getInfo();
        }
    }
}
