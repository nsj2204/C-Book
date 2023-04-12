using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.BreakDemo
{
    class BreakDemo
    {
        static void Main(string[] args)
        {
            // break문 : for, while, do 구문을 빠져나가는 역할
            for(int i=0; i<100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write($"{(i+1)}번 반복\t");
            }
            Console.WriteLine();

            // 무한 루프
            int j = 0;
            while (true)
            {
                if (j == 5)
                {
                    break;
                }
                Console.Write($"{(j+1)}번 반복\t");
                j++;
            }
            Console.WriteLine();
        }
    }
}
