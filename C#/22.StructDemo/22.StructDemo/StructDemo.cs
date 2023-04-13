// [?] 구조체: 하나 이상의 변수 또는 배열을 묶어서 관리
using System;

struct Point
{
    public int x;

    public int y;

    private int z;
}

namespace _22.StructDemo
{
    class StructDemo
    {
        static void Main()
        {
            Point point;
            point.x = 100;
            point.y = 200;
            Console.WriteLine($"x: {point.x}, y: {point.y}");


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            
            Console.WriteLine(DateTime.Now - (new DateTime(2023, 1, 1)));

            TimeSpan ts = (DateTime.Now - new DateTime(2000, 1, 1));
            Console.WriteLine(Math.Ceiling(ts.TotalSeconds));
            Console.WriteLine(Math.Ceiling(ts.TotalDays));


            Console.WriteLine(Char.ToUpper('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsWhiteSpace('A'));
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsDigit('b'));
            Console.WriteLine(Char.IsLetterOrDigit(' '));

            Console.WriteLine(Guid.NewGuid().ToString());
        }
    }
}
