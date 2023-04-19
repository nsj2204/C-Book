#define RELEASE
using System;
using System.Diagnostics;
using System.Reflection;

namespace _46.AttributeDemo
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("럭셔리!!");
    }
    // [LuxuryAttribtue ]
    [Luxury]
    class Car
    {
        //[Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요.")]
        //public void Manual() => Console.WriteLine("수동 운전");
        public void Auto() => Console.WriteLine("자동 운전");
        [Conditional("DEBUG")] public void Test() => Console.WriteLine("테스트 운전");
        [Conditional("RELEASE")] public void Test2() => Console.WriteLine("테스트 운전2");
    }

    class AttributeDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Test(); car.Test2();
            car.Auto(); // car.Manual
            car.Auto();
            // 리플렉션
            var carType = (new Car());
            Type myCar = carType.GetType(); 
            MethodInfo info = myCar.GetMethod("Auto"); 
            info.Invoke(carType, null);
        }
    }
}
