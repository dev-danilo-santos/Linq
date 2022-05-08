using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosDelegates
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name=name;
            this.price=price;
        }

        public override string ToString()
        {
            return name + " " + price;
        }
    }
   
}
