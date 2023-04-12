using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ForSumEven
{
    class ForEven
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for(var i=1; i<= 100; i++)
            {

                if(i % 2 == 0)
                {
                   sum += i;
                }
            }
                   Console.WriteLine($"1부터 100까지 짝수의 합: {sum}");

        }
    }
}
