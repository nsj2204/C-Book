

// 필드(Field): 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇
using System;

namespace _34.FieldDemo
{
    public class Person
    {
        private string name = "남승진";
        private const int m_age = 21; // 필드 == 멤버 변수, 전역 변수
        private readonly string _NickName = "Promotion";
        private string[] _websites = { "제라진", "솔루션" };

        public Person()
        {
            _NickName = "Promotion";
        }


        public void ShowProfile() => 
            Console.WriteLine($"{name} - {string.Join(",", _websites)}");
    }

    public class Car
    {
        private string color = "Red";
        public string GetColor()
        {
            return this.color;
        }
    }

    public class Say
    {
        private string message = "반갑습니다."; // 필드
        public void Hi()
        {
            Console.WriteLine(this.message);
        }
    }


    public class Program
    {
        public static string message = "안녕하세요."; // 필드, 전역 변수
        public static void Hi() => Console.WriteLine(message);

        static void Main(string[] args)
        {
            int number = 1_234; // 변수, 지역 변수
            Console.WriteLine(number);
            Console.WriteLine(message);
            Hi();

            Say say = new Say(); say.Hi();

            Car car = new Car();
            Console.WriteLine(car.GetColor());

            Person my = new Person();
            my.ShowProfile();

        }
    }
}
