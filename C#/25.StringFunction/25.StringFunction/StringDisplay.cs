using System;

namespace _25.StringFunction
{
    class StringDisplay
    {
        static void Main()
        {
            var displayName = "";
            var firstName = "길동";
            var lastName = "홍";

            // 더하기 연산자
            displayName = "이름: " + lastName + firstName;
            Console.WriteLine(displayName);

            // string.Format()
            displayName = string.Format("이름: {0}{1}", lastName, firstName);
            Console.WriteLine(displayName);

            // 문자열 보간법
            displayName = $"이름: { lastName}{ firstName}";
            Console.WriteLine(displayName);
        }
    }
}
