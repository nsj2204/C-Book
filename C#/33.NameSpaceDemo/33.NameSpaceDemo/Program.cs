using System;


namespace MyNamespace
{

    public class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("네임스페이스");
            Foo.Car car1 = new Foo.Car(); car1.Go();
            var car2 = new Bar.Car(); car2.Go();
        }
    }
}