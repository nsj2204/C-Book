// 속성: 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버


namespace _38.PropertyDemo
{
    class Car5
    {
        public string Name { get; set; } = "My Car";
    }

    class prgram5
    {
        static void Main(string[] args)
        {
            Car5 car = new Car5() { Name = null };
            System.Console.WriteLine(car.Name);

            System.Console.WriteLine(car?.Name);
            System.Console.WriteLine(car?.Name ?? "대포차");
        }

    }

}
