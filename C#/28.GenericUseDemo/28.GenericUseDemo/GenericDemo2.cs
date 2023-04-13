using System;
using System.Collections.Generic;
using System.Linq;

namespace _28.GenericUseDemo
{
    class GenericDemo2
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            Enumerable.Range(1, 10);
            
            for(int i=0; i<= 10; i++)
            {
                Console.WriteLine(numbers);
            }

            Enumerable.Repeat(1, 10);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numbers);
            }

            numbers.AddRange(Enumerable.Range(1, 10));
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
