using System;
using System.Collections.Generic;

namespace _48.GenericsDemo
{
    public class Cup<T>
    {
        public T Content { get; set; }
    }

    class program3
    {
        static void Main(string[] args)
        {
            var text = new Cup<string>();
            text.Content = "STRING";
            Console.WriteLine(text.Content);

            var number = new Cup<int>();
            number.Content = 1_234;
            Console.WriteLine(number.Content);

            var person = new Cup<Person2>();
            person.Content = new Person2 { Name = "Hong", Age = 21 };
            Console.WriteLine($"{person.Content.Name} - {person.Content.Age}");
        }
    }

    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
