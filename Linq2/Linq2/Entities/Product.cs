using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, double price, Category category)
        {
            Id=id;
            Name=name;
            Price=price;
            Category=category;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("F2")}, {Category.Name}";
        }
    }
}
