﻿using System;


namespace _12.Bit연산자
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            int number = 3;

            string result = (number % 2 == 0) ? "짝수" : "홀수";

            Console.WriteLine($"{number}는 {result}입니다.");

        }
    }
}
