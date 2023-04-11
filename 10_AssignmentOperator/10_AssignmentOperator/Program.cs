using System;

namespace _10_AssignmentOperator
{
    class AssignmentOperator
    {
        static void Main(string[] args)
        {
            // [?] 할당(대입) 연산자: 변수에 특정 값으로 초기화하면 자동 유추에 의해서 형식이 결정됨
            var name = "Java";
            var version = 14;
            Console.WriteLine(name + " " + version);

            var i = 100;
            var j = 200;
            Console.WriteLine("처음: " + i + ", " + j);

            // 변수값 서로 바꾸기
            var temp = i;
            i = j;
            j = temp;
            Console.WriteLine("변경: " + i + ", " + j);

            // [?] 정수형 변수의 값을 1씩 증가
            int num = 10;
            num += 1; // 1 증가
            Console.WriteLine(num);
            num -= 1; // 1 감소
            Console.WriteLine(num);

            int x = 3;
            int y = 3;

            x = x + 2; //기본형
            y += 2;    //축약형
            Console.WriteLine(x + ", " + y);

            int a = 3;
            int b = 5;
            b += a; // 누적: 변수 b에 a변수의 값을 누적
            Console.WriteLine(b);
            b -= a;
            Console.WriteLine(b);

            int numb = 100;
            // numb = numb+1;
            // numb += 1;
            ++numb;
            Console.WriteLine(numb);


            int numm = -100;
            // numm = numm-1;
            // numm -= 1;
            --numm;
            Console.WriteLine(numm);

            // 전위(prefix) 증감 연산자: 우선순위가 높음
            int q = 3;
            int w = ++q;
            Console.WriteLine(w); //4

            // 후위(postfix) 증감 연산자: 우선순위가 낮음
            int v = 3;
            int z = v++;
            Console.WriteLine(z); //3
            Console.WriteLine(v); //4

            // 연습문제: 증가, 감소 연산자 사용하기
            int number1 = 3;
            int number2 = 5;

            int result1 = 0;
            int result2 = 0;

            number1--; // 2
            result1 = ++number1; // 3

            ++number2; // 6
            result2 = number2--; // 6

            Console.WriteLine(result1); // 3
            Console.WriteLine(result2); // 6
        }
    }
}
