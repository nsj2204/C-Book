using System;
using System.Collections.Generic;

namespace _48.GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "Red", "Plus" };
            Console.WriteLine(colors);

            //[?] 컬렉션 이니셜라이저를 사용하여 개체 여러 개를 초기화
            List<Person> people = new List<Person>
            {
                new Person {Name="홍길동"},
                new Person {Name="백두산"},
                new Person {Name="임꺾정"}
            };
            Console.WriteLine(people);
            foreach(var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
    }

}
