using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x; // javaScript의 var 키워드 
            x = 1_234;
            Console.WriteLine($"{x} - {x.GetType()}");

            x = "Dynamic Type!";
            Console.WriteLine($"{x} - {x.GetType()}");

            string ss = "Hello";
            Console.WriteLine(ss);

            var vs = "Hello";
            Console.WriteLine(vs.Length);

            dynamic ds = "Hello";
            Console.WriteLine(ds.Length);
        }
    }
}
