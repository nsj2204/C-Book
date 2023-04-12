using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ForSumEven
{
    class For3or4
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for(var i=1; i<= 100; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    sum += i;
                }
            }
                   Console.WriteLine($"3의 배수이거나 4의 배수인 1부터 100까지 숫자의 합: {sum}");
            
            sum = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"3의 배수이고 4의 배수인 1부터 100까지 숫자의 합: {sum}");

        }
    }
}
