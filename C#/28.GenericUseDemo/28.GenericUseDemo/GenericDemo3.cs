using System;
using System.Collections.Generic;
using System.Linq;

namespace _28.GenericUseDemo
{
    class GenericDemo3
    {
        static void Main()
        {
            Dictionary<int, string> todos = new Dictionary<int, string>();
            todos.Add(1, "C#");
            todos.Add(2, "ASP.NET");
            todos.Add(3, "...");

            Console.WriteLine(todos);

            foreach(var item in todos)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
