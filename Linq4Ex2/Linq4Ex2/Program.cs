using System.Globalization;
using Linq4Ex2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // c:\temp\in.txt
            Console.WriteLine("Entre com o caminho do arquivo: ");

            string path = Console.ReadLine();

            List<Employee> List = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double Salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    List.Add(new Employee(name, email,Salary));
                }
            }

            Console.WriteLine("Entre com o valor filtro: ");
            double filtro = double.Parse(Console.ReadLine());

            var emails = List.Where(x => x.Salary > filtro).Select( x => x.Email);
            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }

            var soma = List.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);
            Console.WriteLine("Soma dos salários de pessoas que começam com 'M'" +soma);


        }
    }
}