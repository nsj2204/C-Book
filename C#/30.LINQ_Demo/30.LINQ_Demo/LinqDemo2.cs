using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.LINQ_Demo
{
    class LinqDemo2
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 100);
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Where(n => n % 2 == 0));
            Console.WriteLine(numbers.Where(n => n % 2 == 0).Sum());
            Console.WriteLine(numbers.OrderByDescending(n => n));
            Console.WriteLine(numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Take(3));
            Console.WriteLine(numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Skip(3).Take(3));

            var q = from n in numbers
                    where n % 2 == 0
                    select n;
            Console.WriteLine(q);
        }
    }
}
