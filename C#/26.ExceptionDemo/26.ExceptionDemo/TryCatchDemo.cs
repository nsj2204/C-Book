﻿using System;
using static System.Console;


namespace _26.ExceptionDemo
{
    class TryCatchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                int now = DateTime.Now.Second;
                Console.WriteLine($"[0] 현재 초: {now}");

                int result = 2 / (now % 2);
                Console.WriteLine("[1] 홀수 초에서는 정상 처리");
            }
            catch
            {
                Console.WriteLine("[2] 짝수 초에서는 런타임 에러 발생");
            }
        }
    }
}
