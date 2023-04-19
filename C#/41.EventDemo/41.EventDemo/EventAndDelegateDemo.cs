using System;

namespace EventAndDelegeteDemo
{
    // 이벤트 구독자(Subscriber)
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;
            car.FuelEmptyReached -= Car_FuelEmptyReached;
            car.FuelEmptyReached += () =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("연료 부족!!!");
                Console.ResetColor();
            };
            car.Go();
            // car.OnFuelEmptyReached();
            car.Go();
        }

        // 이벤트 처리기(핸들러): Handler
        private static void Car_FuelEmptyReached() =>
            Console.WriteLine("연료 부족");
        
    }

}