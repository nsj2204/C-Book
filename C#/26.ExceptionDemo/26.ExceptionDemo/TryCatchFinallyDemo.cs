﻿using System;
using static System.Console;


namespace _26.ExceptionDemo
{
    class TryCatchFinallyDemo
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            int r;

            try
            {
                r = x / y;
                WriteLine($"{x}/{y}={r}");
            }
            catch(Exception ex)
            {
                WriteLine($"예외 발생: {ex.Message}");
            }
            finally
            {
                WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
