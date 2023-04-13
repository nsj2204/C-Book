using System;
using System.Collections;
using System.Collections.Generic;

namespace _28.GenericUseDemo
{
    class GenericDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(100);
            Console.WriteLine(stack.Pop());

            Stack<int> stack2 = new Stack<int>();
            stack2.Push(100);
            Console.WriteLine(stack2.Pop());

            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(numbers[0] + ", " + numbers[1]);

            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("green");
            colors.Insert(0, "blue");

            Console.WriteLine(colors[0] + ", " + colors[1] + ", " + colors[2]);
        }
    }
}
