using System;
using System.Collections;

namespace _27.CollectionDemo
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(100);
            list.RemoveAt(1);
            list.Add(200);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            list.Insert(0, 50);
            Console.WriteLine(list[0] + "," + list[1] + "," + list[2]);
        }
    }
}
