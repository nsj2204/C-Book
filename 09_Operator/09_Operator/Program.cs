using System;

class Operator
{
    static void Main(string[] args)
    {
        // 연산자(Operator) : 데이터와 변수를 가지고 더하기(+), 빼기(-)와 같은 연산 작업을 수행
        var num = 1000;
        var number = num + 1234;
        Console.WriteLine(number);

        // [?] 식(Expression)

        // [?] 문(Statement)
        // Console.log(3*5);

        // [?] 단항 연산자(Unary Operator): +, -
        var value = 0;
        Console.WriteLine(value);
        value = 8;
        value = +value;
        Console.WriteLine(value);
        value = -value;
        Console.WriteLine(value);

        Console.WriteLine("Hello, " + "World");
        Console.WriteLine("123" + "456");
        Console.WriteLine(123+456);
        Console.WriteLine("123"+456);

    }
}