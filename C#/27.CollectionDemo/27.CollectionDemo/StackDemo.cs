using System;
using System.Collections;

namespace _27.CollectionDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            // FILO

            Console.WriteLine(stack.Pop()); // 200
            Console.WriteLine(stack.Pop()); // 100
            Console.WriteLine(stack.Pop()); // Error
        }
    }
}
