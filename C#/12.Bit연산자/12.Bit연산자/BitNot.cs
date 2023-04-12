using System;
using static System.Console;


namespace _12.Bit연산자
{
    class BitNot
    {
        static void Main(string[] args)
        {
            byte x = 0b00001010;
            

            WriteLine($"~ {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");
            WriteLine($"--------");
            WriteLine($"  {Convert.ToString((byte)~x, 2).PadLeft(8, '0')} -> {~x, 3}");

        }
    }
}
