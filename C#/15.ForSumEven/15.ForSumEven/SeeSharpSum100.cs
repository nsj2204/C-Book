using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ForSumEven
{
    class SeeSharpSum100
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for(var i=1; i<= 100; i++)
            {
               sum += i;
            }
               Console.WriteLine($"1부터 100까지 정수의 합: {sum}");

        }
    }
}
