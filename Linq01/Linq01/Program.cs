using System.Linq;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
             // especificar a datasource
             int[] numbers = new int[] { 1, 2, 3, 4 };
            //definir a consulta
            var result = numbers.Where(x => x %2 ==0).Select(x => x*10);
            // executar a consulta
             foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}