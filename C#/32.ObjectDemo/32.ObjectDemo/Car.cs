using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.ObjectDemo
{
    public class Car
    {
        public void Go() => Console.WriteLine("Run...");

        public override string ToString() => "My Car";


        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Go();
            Car car2 = new Car();
            car2.Go();
            var car3 = new Car();
            car3.Go();

            Car car = new Car();
            Console.WriteLine(car);
            Console.WriteLine(car.ToString());


        }
    }
}
