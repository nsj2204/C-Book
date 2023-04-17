// 속성: 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버

namespace _38.PropertyDemo
{
    class Car
    {
        private string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetName("My Car");
            System.Console.WriteLine(car.GetName());
        }
    }
}
