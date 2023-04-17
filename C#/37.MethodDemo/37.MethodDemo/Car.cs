
using System;

namespace _37.MethodDemo
{
    class Car
    {
        public void Map(ref string title)
        {
            title = "참조변경";
            Console.WriteLine($"[2] {title}");
        }

        public void Map2(out string title2)
        {
            title2 = "참조반환";
        }

        public void Map3(params string[] title3)
        {
            foreach (var t in title3)
            {
                Console.WriteLine(t);
            }
        }
    }
}
