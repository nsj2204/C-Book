using System;

class ReadLineDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("이름:______\b\b\b\b\b\b");
        string name = Console.ReadLine();  // <- 이 시점에서 대기하는 효과
        Console.WriteLine($"{name}님 안녕하세요");


        int x = Console.Read();

        Console.WriteLine(x); // 아스키 코드(ASCII)

        Console.WriteLine(Convert.ToChar(x)); // 실제문자

        // GetType() 메서드: 해당 변수의 Type을 출력해 줌


        Console.WriteLine("정수: ");
        string num = Console.ReadLine(); // "1234"

        int number = Convert.ToInt32(num); // 1234
        Console.WriteLine(number + number);


        int binNum = 10; // -> 0000 1010
        String bin1 = Convert.ToString(binNum, 2);
        Console.WriteLine(bin1);
        String bin2 = Convert.ToString(binNum, 2).PadLeft(8, '0');
        Console.WriteLine(bin2);
        String bin3 = Convert.ToString(binNum, 2).PadLeft(8, '_');
        Console.WriteLine(bin3);

        int intNum = Convert.ToInt32("00001010", 2);
        Console.WriteLine(intNum);


        int b1 = 0b0010;
        Console.WriteLine(b1);
        int b2 = 0B1010;
        Console.WriteLine(b2);


        var c = 'C';// [?] var 키워드: 암시적으로 형식화된 로컬 변수
        Console.WriteLine(c.GetType());

        String s = default; // 기본형으로 초기화
        Console.WriteLine(s);


    }

}