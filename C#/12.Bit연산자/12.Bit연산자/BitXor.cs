// ^ 연산자: 비트 XOR 연산자(서로 다르면 1)
using System;
using static System.Console;


namespace _12.Bit연산자
{
    class BitXor
    {
        static void Main(string[] args)
        {
            byte x = 0b1010;
            byte y = 0b1100;
            

            WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
            WriteLine($"& {Convert.ToString(y, 2)} -> {y}");
            WriteLine($"-----");
            WriteLine($"  {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} -> {x ^ y, 2}");

        }
    }
}
