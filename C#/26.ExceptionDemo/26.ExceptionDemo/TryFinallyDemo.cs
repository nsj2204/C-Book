using System;
using static System.Console;


namespace _26.ExceptionDemo
{
    class TryFinallyDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] 시작");

            try
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();
            }
            finally
            {
                Console.WriteLine("[3] 종료");
            }
        }
    }
}
