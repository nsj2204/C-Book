using System;
using System.Collections;

namespace _27.CollectionDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            //FIFO

            Console.WriteLine(queue.Dequeue()); // 100
            Console.WriteLine(queue.Dequeue()); // 200
        }
    }
}
