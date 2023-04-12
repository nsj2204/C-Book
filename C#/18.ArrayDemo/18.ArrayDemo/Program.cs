using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String arr = "C#8";
            Console.WriteLine(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);


            int[] numbers = new int[3] { 10, 20, 30};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[,] numberss = { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < numberss.GetLength(0); i++)
            {
                for(int j = 0; j < numberss.GetLength(1); j++)
                {
                    Console.Write($"{numberss[i,j]}\t");
                }
                Console.WriteLine();
            }

            String[] names = { "C#", "Windows Forms", "ASP.NET" };
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
