using System;
using static System.Console;


namespace _12.Bit연산자
{
    class ShiftLeft
    {
        static void Main(string[] args)
        {
            WriteLine("C# 시프트 연산자");

            byte x = 0b0000_0011;

            WriteLine($"{nameof(x), 8} : {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");
            WriteLine($"x = x << 1 : {Convert.ToString(x << 1, 2).PadLeft(8, '0')} -> {x << 1, 3} = 2 * (2)");
            WriteLine($"x = x << 2 : {Convert.ToString(x << 2, 2).PadLeft(8, '0')} -> {x << 2, 3} = 2 * (2 * 2)");
            WriteLine($"x = x << 3 : {Convert.ToString(x << 3, 2).PadLeft(8, '0')} -> {x << 3, 3} = 2 * (2 * 2 * 2)");


            x = 0b0001_1000;
            WriteLine($"{nameof(x), 10} : {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 2}");
            WriteLine($"x = x >> 1 : {Convert.ToString(x >> 1, 2).PadLeft(8, '0')} -> {x >> 1, 3} = {x} / (2)");
            WriteLine($"x = x >> 2 : {Convert.ToString(x >> 2, 2).PadLeft(8, '0')} -> {x >> 2, 3} = {x} / (2 * 2)");
            WriteLine($"x = x >> 3 : {Convert.ToString(x >> 3, 2).PadLeft(8, '0')} -> {x >> 3, 3} = {x} / (2 * 2 * 2)");
        }
    }
}
