using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.While
{
    class ForEach
    {
        static void Main(string[] args)
        {
            string[] names = { "C#", "ASP.NET" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            string str = "ABC123";
            foreach(char c in str)
            {
                Console.WriteLine(c);
            }
        }
    }
}
