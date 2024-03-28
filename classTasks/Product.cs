using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classTasks
{
    internal class Product
    {
        public int id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int inCome;
        public int Count;
        public Product(int id, string brandName, string model, int price, int cost, int inCome, int count)
        {
            this.id = id;
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            this.inCome = inCome;
            Count = count;
            if(Count <0 )
            {
                Count =0;
            }
        }
        public void getInfo()
            {
            Console.WriteLine($"{BrandName},{Model},{Price},{Cost},{Count}");
        }
    }
}
