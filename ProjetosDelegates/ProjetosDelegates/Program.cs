using ProjetosDelegates;
using System.Collections.Generic;
using System.Linq;

namespace exercicio
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            //List<string> list2 = list.Select(x => x.name.ToUpper()).ToList();
           // list2.ForEach(x => Console.WriteLine(x.ToString()));

            var result = list.Where(x => x.name.ToCharArray().Equals("T")).Select(x => x.price + 10000);

            list.ForEach(x => Console.WriteLine(x));
        }
        static string NameUpper(Product P)
        {
            return P.name.ToUpper();
        }
    }
}