// | 연산자: 비트 OR 연산자(하나라도 1이면 1)
using System;
using static System.Console;


namespace _12.Bit연산자
{
    class BitOr
    {
        static void Main(string[] args)
        {
            byte x = 0b1010;
            byte y = 0b1100;
            

            WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
            WriteLine($"& {Convert.ToString(y, 2)} -> {y}");
            WriteLine($"-----");
            WriteLine($"  {Convert.ToString(x | y, 2)} -> {x | y, 2}");

        }
    }
}
