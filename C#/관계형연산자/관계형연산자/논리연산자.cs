// 논리 연산자
// && 연산자(AND) : 둘 다 참일떄에만 참, 즉, 하나라도 거짓이면 거짓
// || 연산자(OR) : 하나라도 참이면 참, 즉, 둘 다 거짓일때에만 거짓
// ! 연산자(NOT) : 참이면 거짓으로, 거짓이면 참으로
using System;

namespace 관계형연산자
{
    class 논리연산자
    {
        static void Main(string[] args)
        {
            int i = 3;
            int j = 5;
            bool r = false;

            r = (i == 3) && (j != 3);
            Console.WriteLine(r);
            
            r = (i != 3) && (j == 3);
            Console.WriteLine(r);

            r = (i >= 5);
            Console.WriteLine("{0}", !r);

        }
    }
}
