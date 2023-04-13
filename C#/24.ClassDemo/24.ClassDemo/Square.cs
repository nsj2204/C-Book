using System;


namespace _24.ClassDemo
{

    class Square
    {
        public int Width;
        public int Height;
        public static String Creator; 

        static void Main(string[] args)
        {
            Square square = new Square();
            square.Width = 100;
            square.Height = 100;
            Console.WriteLine($"{square.Width}, {square.Height}");

            Square.Creator = "RedPlus";
            Square square1 = new Square();
            square1.Width = 100;
            square1.Height = 100;
        }
    }
}
