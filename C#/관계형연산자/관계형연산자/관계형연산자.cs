// 관계형(비교) 연산자 :
// >, <, >=, <=, ==(같은지), !=
using System;

namespace 관계형연산자
{
    class 관계형연산자
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 5;
            bool r = false;

            Console.WriteLine(firstNum > secondNum);

            r = (firstNum <= secondNum);
            Console.WriteLine(r);

            r = (firstNum == secondNum);
            Console.WriteLine(r);

            r = (firstNum != secondNum);
            Console.WriteLine(r);
        }
    }
}
