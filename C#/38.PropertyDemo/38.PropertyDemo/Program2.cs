// 속성: 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버

namespace _38.PropertyDemo
{
    class Car2
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Car2 car = new Car2();
            car.Name = "My Car";
            System.Console.WriteLine(car.Name);
        }
    }
}
