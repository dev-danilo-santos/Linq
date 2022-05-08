using Linq2.Entities;
using System.Linq;

namespace Course
{
    class Program
    {
        static void print<T> (string message, IEnumerable<T> cll)
        {
            Console.WriteLine (message);
            foreach (T obj in cll)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine ();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1,"Tools",2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);
            
            List<Product> products = new List<Product>();

            products.Add(new Product(1,"Computer", 1100, c2));
            products.Add(new Product(2, "Hammer", 90, c1));
            products.Add(new Product(3, "TV", 1700, c3));
            products.Add(new Product(4, "Notebook", 1300, c2));
            products.Add(new Product(5, "Saw", 80, c1));
            products.Add(new Product(6, "Tablet", 700, c2));
            products.Add(new Product(7, "Camera", 700, c3));
            products.Add(new Product(8, "Printer", 350, c3));
            products.Add(new Product(9, "MacBook", 1800, c2));
            products.Add(new Product(10, "Sound Bar", 700, c3));
            products.Add(new Product(11, "Level", 70, c1));

            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            //print("Tier 1 e preço menor que 900", r1);

            //var r2 = products.Where(x => x.Category.Name.Equals("Tools")).Select(x => x.Name);
            //print("Nomes dos dos produtos que são ferramentas: ",r2);

            //var r3 = products.Where(x => x.Name[0] == 'C')
            //.Select(x => new {x.Name, x.Price, NomeCategoria = x.Category.Name});
            //print("Nomes que começam com a letra C", r3);

            //var r4 = products.Where(x => x.Category.Tier ==1).OrderBy( x => x.Price).ThenBy(x => x.Name) ;
            //print("Ordenado por preço, e depois por nome, produtos do Tier 1: ",r4);

            //var r5 = r4.Skip(2).Take(4);
            //print(" Skip 2 e skip 4,  Ordenado por preço, e depois por nome, produtos do Tier 1: ", r5);

            //var r6 = products.First();
            //Console.WriteLine ("first de products: "+ r6);

            //var r10 = products.Max(x => x.Price);
            //Console.WriteLine("Max price : "+ r10);

            //var r11 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            //Console.WriteLine("Categoria 1 soma de preços "+ r11 );

            //var r12 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            //Console.WriteLine("Categoria 1 media de preços "+ r1);


            var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900.00
                     select p;
            print("tier 1 preço <= 900", r1);

            //
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;

            print("Categoria tools, e nome", r2  );

            //

            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new {p.Name , p.Price , CategoryName = p.Category.Name};
            print("Protutos que começam com C", r3 );
            //

            var r4 = from p in products
                     where p.Category.Tier==1
                     orderby p.Name
                     orderby p.Price
                     select p;
            print("ordenando produtos do tier 1", r4 );
            //

            var r5 =
                from p in products
                group p by p.Category;
            foreach (var item in r5)
            {
                foreach (var i2 in item)
                {
                    Console.WriteLine(i2);
                }
            }

        }
    }
}