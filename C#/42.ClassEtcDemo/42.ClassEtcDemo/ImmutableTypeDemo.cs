using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassEtcDemo
{
    public class Circle
    {
        public int Radius { get; private set; } = 0;
        public Circle(int radius) => Radius = radius;
        public Circle MakeNew(int radius) => new Circle(radius);
    }

    class ImmutableTypeDemo
    {
        static void Main(string[] args)
        {
            //[1] 생성자를 통해서 반지름이 10인 circle 개체 생성
            Circle circle = new Circle(10);
            System.Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

            //[2] 메서드를 통해서 반지름이 20인 Circle 개체 새롭게 생성
            circle = circle.MakeNew(20);
            System.Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");
        }
    }
}
