using System;


namespace _21.Math_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1] System.Math Class
            // Static Member
            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Max(3,5));

            Console.WriteLine(Math.Abs(-10));

            // [2] System.Random Class
            // Instance Member
            Random random = new Random();
            Console.WriteLine(random.Next(1, 11));

            Random dice = new Random();
            Console.WriteLine(dice.Next(1, 7));
        }
    }
}
