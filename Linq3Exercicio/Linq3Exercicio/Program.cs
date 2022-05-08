using System.Collections.Generic;
using System;
using Linq3Exercicio.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Ex01Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            // c:\temp\in.txt
            Console.WriteLine("Entre com o caminho do arquivo: ");

            string path = Console.ReadLine();

            List<Product> List = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream) { 
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                List.Add(new Product(name, price));
                }
            }

            var avg = List.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média: "+ avg.ToString("F2",CultureInfo.InvariantCulture));

            var r1 = List.Where( p=> p.Price<avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (var item in r1)
            {
                Console.WriteLine(item );
            }

        }
    }
}