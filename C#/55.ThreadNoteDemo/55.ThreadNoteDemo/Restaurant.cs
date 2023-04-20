// 스레드(Thread): 작업자 한 명(사람들)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _55.ThreadNoteDemo
{
    class Restaurant
    {
       public void MakeFood() // 순서대로 - 동기화 방식
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000); Console.WriteLine("달걀 3초");
            }
            Thread t1 = new Thread(new ThreadStart(Egg));

            void Soup()
            {
                Thread.Sleep(5000); Console.WriteLine("국 5초");
            }
            Thread t2 = new Thread(new ThreadStart(Soup));

            Thread t3 = new Thread(() =>
            {
                Thread.Sleep(7000); Console.WriteLine("밥 7초");
            });

            t1.Start(); t2.Start(); t3.Start(); // async
            t1.Join(); t2.Join(); t3.Join();    // await

            Console.WriteLine($"요리 종료: {(DateTime.Now - start).TotalSeconds}"); // 작업자 한 명(동기): 15초, 3명(비동기): 7초

            Console.WriteLine("식사 시작");
            //SinglePro();
            MultiPro();
            Console.WriteLine($"요리 종료: {(DateTime.Now - start).TotalSeconds}");
        }

        private void SinglePro()
        {
            for (int i = 0; i < 20_000; i++)
            {Console.WriteLine("수다"); }
        }

        private void MultiPro()
        {
            Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); }); // TPL
        }
    }

    class ThreadNote
    {
        static void Main(string[] args) => (new Restaurant()).MakeFood();
    }
}
