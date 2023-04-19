using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassEtcDemo
{
    public class Car
    {
        public string Name { get; private set; }

        public Car(string name) => Name = name;

        //[!] 변환연산자 구현
        public static implicit operator Car(string name) => new Car(name); // 생성자에게 재전송
    }

    class OperatorOverload
    {
        static void Main(string[] args)
        {
            Car car = "생성자에 직접 문자열을 전달함";
            System.Console.WriteLine(car.Name);
        }
    }
}
