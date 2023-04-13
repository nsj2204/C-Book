using System;


namespace _24.ClassDemo
{
    struct Point { public int X; public int Y; }
    enum Animal { Mouse, Toger}

    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.X = 100; point.Y = 200;
            Int32 number = 1_234;
            Console.WriteLine(number);
            Console.WriteLine($"{point.X}, {point.Y}");

            Console.WriteLine($"{Animal.Mouse}, {(int)Animal.Toger}");
        }
    }
}
