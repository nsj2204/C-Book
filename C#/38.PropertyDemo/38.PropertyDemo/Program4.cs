// 속성: 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버

namespace _38.PropertyDemo
{
    class Car4
    {
        public string Name { get; private set; } = "My Car";
    }

    class Program4
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine((new Car4()).Name);

            Car4 car = new Car4();
            // car.Name = "Your Car"; Setter가 private일 때는 불가능
            System.Console.WriteLine($"{nameof(car.Name)}:{car.Name}");
        }
    }
}
