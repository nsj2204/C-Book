using System;

namespace _07_CharDemo
{
    class CharDemo
    {
        static void Main(string[] args)
        {
            // 숫자 이외의 데이터 형식: bool, char, string 등의 키워드로 숫자 이외의 데이터 저장
            // char 키워드: 문자 데이터 형식 변수를 선언
            // char grade = 1234; 에러
            // char grade = "AAA"; 에러
            // escape 시퀀스는 문자 하나로 표현


            // String hi = 1234; 에러
            // String hi = 'a'; 에러

            String naming = "남승진";
            Console.WriteLine("안녕하세요. {0}입니다." ,naming);

            String multiLines = @"
                안녕하세요.
                반갑습니다.
            ";

            Console.WriteLine(multiLines);

            // StringInterpolation
            // 문자열 보간법(보간된 문자열)
            Console.WriteLine("{0} {1}", "Hello", "World");
            // Tamplet 문자열
            Console.WriteLine($"{1234} is {"number"}");

            Console.WriteLine("Hello" + ", " +"World");

            // String.Format() 메서드: 문자열 연결 관련 주요 기능 제공
            String msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요");
            Console.WriteLine(msg);

            String message = "String Interpolation";
            Console.WriteLine("Message: {0}", message);
            Console.WriteLine("Message: " + message);
            Console.WriteLine(String.Format("Message: {0}", message));
            Console.WriteLine($"Message: {message}");

            // String Interpolation(문자열 보간법)
            String name = "C#";
            String version = "8.0";

            // [1] WriteLine() 메서드의 기본 제공 기능 사용
            Console.WriteLine("{0} {1}", name, version);
            // [2] String.Format() 메서드 사용
            string result = String.Format("{0} {1}", name, version);
            Console.WriteLine(result);
            // [3] 문자열 보간법(StringInterpolation) 사용
            Console.WriteLine($"{name} {version}");


            // [?] 논리 자료형: 참(True) 또는 거짓(False) 값 저장 + True/False값이 아니면 Error


            // 래퍼 형식: int, string과 같은 기본 형식을 클래스 또는 구조체로 감싼 .NET 형식
            int number1 = 1234; // int 키워드: 기본 형식
            Int32 number2 = 1234; // System.Int32 구조체: .NET 형식
            Console.WriteLine($"{number1} {number2}");
            
            string str1 = "안녕"; // string 키워드: 기본 형식
            String str2 = "안녕"; // System.String 클래스: .NET 형식
            Console.WriteLine($"{str1} {str2}");


        }
    }
}
