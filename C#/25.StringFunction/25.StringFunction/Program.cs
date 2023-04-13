using System;

namespace _25.StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello World";

            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            Console.WriteLine(
                message.Replace("hello", "안녕하세요.").Replace("World", "세계"));
        }
    }
}
