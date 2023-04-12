using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ForSumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int sum = 0;

            for(var i=1; i<=n; i++)
            {
                if(i%2 == 0)
                {
                    sum += i;
                }
                Console.WriteLine($"1부터 {n}까지 짝수의 합: {sum}");
            }

        }
    }
}
