using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.ObjectDemo
{
    public class ClassOne
    {
        public static void Hi() => Console.WriteLine("Hi");

        static void Main(string[] args)
        {
            ClassOne.Hi();
            ClassTwo two = new ClassTwo();
            two.Hi();

        }
    }


}
