using System;
using static System.Console;

namespace _45.InterFaceDemo
{
    public interface ICarStandard
    {
        void Left();
    }
    public abstract class KS
    {
        public abstract void Back();
        public void fly() => WriteLine("날다"); // 추상클래스는 실제 메서드 설정 가능 / 인터페이스는 불가능
    }
    public partial class MyCar : KS
    {
        public override void Back() => WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => WriteLine("우회전");
    }

    public sealed class Car : MyCar, ICarStandard // 인터페이스는 다중상속 가능
    {
        public void Left() => WriteLine("좌회전");
        public void Run() => WriteLine("직진");
    }

    //class SpyCar : Car { }

    public class InterfaceDescription
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run(); car.Right(); car.Back(); car.Left(); car.fly();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}
