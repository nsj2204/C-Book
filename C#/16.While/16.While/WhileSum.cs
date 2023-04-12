using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.While
{
    class WhileSum
    {
        static void Main(string[] args)
        {
            const int N = 100;
            int sum = 0;
            int i = 1;

            while(i <= N)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"1부터 {N}까지의 합: {sum}");

            sum = 0;
            i = 1;

            while (i <= 100)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"1부터 100까지의 짝수의 합: {sum}");

        }
    }
}
