using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.ObjectDemo
{
    public class ClassCode
    {

        static void Main(string[] args)
        {
            ClassCode classCode1 = new ClassCode();
            Console.WriteLine(classCode1.GetHashCode());

            ClassCode classCode2 = new ClassCode();
            Console.WriteLine(classCode2.GetHashCode());
        }
    }
}
