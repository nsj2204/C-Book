
// Garbage Colletor가 개체 소멸을 자동으로 해주기 때문에 직접 접근할 일은 없음

using System;

namespace _36.DestructorDemo
{
    class Car
    {
        private string _name;
        public Car() : this("기본 자동차") { }
        public Car(string name)
        {
            _name = name;
            Console.WriteLine($"[1] {this._name} 생성, 조립, 시동");
        }
        public void Go() => Console.WriteLine($"[2] {this._name} 달리다.");
        ~Car()
        {
            Console.WriteLine($"[3] {this._name} 소멸");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Go();
            Car car2 = new Car("캠핑카");
            car2.Go();
        }
    }
}
