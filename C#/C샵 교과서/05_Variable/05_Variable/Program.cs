using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //[?] 변수(Variable): 프로그램에서 사용할 데이터를 저장해 놓는 그릇

            int number; // [1] 정수형 변수 선언하기
            number = 1234; // [2] 변수에 값 대입(할당)하기
            Console.WriteLine("{0}", number); // [3] 변수의 값을 화면에 출력하기 (참조)

            // 리터럴
            Console.WriteLine(1234);    // [1] 1234 :정수 리터럴
            Console.WriteLine(3.14F);   // [2] 3.14 :실수 리터럴
            Console.WriteLine('A');     // [3] A :문자 리터럴
            Console.WriteLine("HELLO"); // [4] HELLO :문자열 리터럴

            int num = 7; // [1] 변수 선언과 동시에 초기화
            Console.WriteLine("{0}", num);

            Console.WriteLine(1_234);

            //[?] 상수(Constant): 변하지 않는 변수, 읽기 전용 변수
            const int Max = 100; // 정수 형식의 상수 선언과 동시에 초기화
            Console.WriteLine(Max);


        }
    }
}
