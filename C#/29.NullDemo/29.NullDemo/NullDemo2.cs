using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.NullDemo
{
    class NullDemo2
    {
        static void Main(string[] args)
        {
            // ?? 연산자 (Null 변합 연산자(Null Coalescing Operator))
            string nullValue = null;
            string message = "";

            // [1] if 구문으로 null 값 비교
            nullValue = null;
            if(nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화합니다.";
            }
            Console.WriteLine(message);

            // [2] ?? 연산자로 null 값 비교
            message = "Hello";
            nullValue = null;
            message = nullValue ?? "[2] null이면 새로운 값으로 초기화합니다.";
            Console.WriteLine(message);

            nullValue = "Hello";
            message = nullValue ?? "Nothing";
            Console.WriteLine(message);

            int? value = null;
            int defaultValue = value ?? -1;
            Console.WriteLine(defaultValue);

            int? x = null;
            int y = x ?? 100;
            int z = x ?? default;
            Console.WriteLine($"y: {y}, z: {z}");
        }
    }
}
