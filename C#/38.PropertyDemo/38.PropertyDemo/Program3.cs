// 속성: 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버

namespace _38.PropertyDemo
{
    class Car3
    {
        public string Name { get; set; }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            Car3 car = new Car3();
            car.Name = "My Car";
            System.Console.WriteLine(car.Name);

            Car3 car2 = new Car3() { Name = "My Car" }; // Object Initializer
            System.Console.WriteLine(car2.Name);
        }
    }
}
