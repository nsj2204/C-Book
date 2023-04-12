using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.While
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i;
                i++;
            } while (i <= 5);
            Console.WriteLine($"합계: {sum}");

            sum = 0;
            i = 1;
            do
            {
                if(i % 3 == 0 && i % 4 == 0)
                {
                    sum += i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine($"합계: {sum}");
        }
    }
}
