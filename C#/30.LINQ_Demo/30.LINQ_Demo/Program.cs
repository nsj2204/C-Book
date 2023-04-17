using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(numbers.Sum()); 
            Console.WriteLine(numbers.Max()); 
            Console.WriteLine(numbers.Min()); 
            Console.WriteLine(numbers.Count()); 
            Console.WriteLine(numbers.Average()); 
            Console.WriteLine(numbers.Where(n => n % 2 == 0)); 
            Console.WriteLine(numbers.Where(n => n % 2 == 0).ToList());
            Console.WriteLine(numbers.Select(x => { return x; })); 
            Console.WriteLine(numbers.Where(n=>n%2==0).Max());
            Console.WriteLine(numbers.Where(n=>n%2==0 || n % 2 == 3).Sum());
            Console.WriteLine(numbers.Where(n=>n%2==0 || n % 3 == 0).Sum());
            Console.WriteLine(numbers.Where(n=>n%2==0).Max());

            IEnumerable<int> newNumbers = numbers.Where(n => n % 2 == 0 || n % 3 == 0);
            Console.WriteLine(newNumbers);
            Console.WriteLine(newNumbers.ToList());

            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");
            Console.WriteLine(techs);

            Console.WriteLine(techs.OrderBy(t => t));
            Console.WriteLine(techs.OrderByDescending(t => t.Length > 1));
            Console.WriteLine(techs.OrderByDescending(t => t));

        }
    }
}
