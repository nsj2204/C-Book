namespace _35.ConstructorDemo
{
    public class Car
    {
        private readonly string name;
        public Car() : this("기본자동차")
        {
            // 기본 생성자, 생성자 메서드
            System.Console.WriteLine("[1] 자동차 개체를 생성합니다. 조립, 시동걸기");
            name = "기본 자동차";
        }
        public Car(string name) =>
        
            this.name = name; // this.필드 = 매개 변수
        
        public void Go() => System.Console.WriteLine($"[2] {name}가 달리다.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); 
            car.Go();
            new Car().Go();

            Car my = new Car("좋은 자동차"); 
            my.Go();
            new Car("좋은 자동차").Go();
        }
    }
}
