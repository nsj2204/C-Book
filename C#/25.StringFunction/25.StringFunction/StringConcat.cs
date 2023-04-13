using System;

namespace _25.StringFunction
{
    class StringConcat
    {
        static void Main(string[] args)
        {
            String s1 = "안녕"+"하세요.";
            String s2 = String.Concat("반갑", "습니다.");

            Console.WriteLine($"{s1} {s2}");

           
        }
    }
}
