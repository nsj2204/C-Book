using System;

namespace _06_IntegerDemo
{
    class IntegerDemo
    {
        static void Main(string[] args)
        {
            int min = Int32.MinValue;
            int max = Int32.MaxValue;

            Console.WriteLine("int 변수의 최솟값: {0}", min);
            Console.WriteLine("int 변수의 최댓값: {0}", max);

            sbyte sb = 127;
            short st = 32767;
            int i = Int32.MaxValue;
            long l = Int64.MaxValue;

            Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);

            // 부호 없는 정수 데이터 형식: byte, ushort, uint, ulong
            // double 키워드: 실수형 데이터 형식(64비트 부동 소수점 숫자)
            // float 키워드: 실수형 데이터 형식(32비트 부동 소수점 숫자)
            float f = (float)3.14;
            Console.WriteLine(f);
            Console.WriteLine($"{float.MinValue}~{float.MaxValue}");

            // decimal 키워드: 실수형 데이터 형식(128비트 10진수)
            decimal money = 12.34m;
            Console.WriteLine(money);

            int? x = null; // type + ? = nullable형식

        }
    }
}
