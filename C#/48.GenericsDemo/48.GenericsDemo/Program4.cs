using System;
using System.Collections.Generic;

namespace _48.GenericsDemo
{
    public class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }
        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }

    }

    class program4
    {
        static void Main(string[] args)
        {
            var my = new Pair<string, bool>("나는 멋져!", true);
            Console.WriteLine($"{my.First}: {my.Second}");

            var tuple = new Pair<int, double>(1234, 3.14);
            Console.WriteLine($"{tuple.First}, {tuple.Second}");
        }
    }

}
