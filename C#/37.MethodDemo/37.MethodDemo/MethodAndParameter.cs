using System;

namespace _37.MethodDemo
{

    class MethodAndParameter
    {
        static void Main(string[] args)
        {
            string title = "참조";  Console.WriteLine($"[1] {title}");
            var car = new Car();  car.Map(ref title);
            Console.WriteLine($"[3] {title}");

            string title2;
            var car2 = new Car(); 
            car2.Map2(out title2);
            Console.WriteLine($"[3] {title2}");

            var car3 = new Car();
            car3.Map3("홍길동", "백두산");
        }
    }
}
