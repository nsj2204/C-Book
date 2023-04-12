using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.While
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine("카운트: {0}", i);
                i++;
            }

            int index = 5;
            while(index > 0)
            {
                Console.WriteLine($"안녕하세요. {index}");
                index--;
            }
        }
    }
}
