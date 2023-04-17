using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.AlgorithmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 3, 2, 1, 5, 4 };
            Array.Sort(data);
            Console.WriteLine(data);
            Console.WriteLine(data.OrderByDescending(d => d));

            for(int i = 0; i<data.Length - 1; i++)
            {
                for(int j=i+1; j<data.Length; j++)
                {
                    if(data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            Console.WriteLine(data);

        }
    }
}
