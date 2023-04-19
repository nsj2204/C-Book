using System;

namespace _51.TupleDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            //[?] 튜플 리터럴(Tuple Literal)
            var r = (12, 34, 56); // 3개의 in 형식 데이터가 r 변수에 담김
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);

            var fhd = (1920, 1080); //[1] 기본: Item1, Item2 형태
            Console.WriteLine(fhd.Item1);
            Console.WriteLine(fhd.Item2);

            var uhd = (Width: 3840, Height: 2160); // [2] 이름 지정
            Console.WriteLine(uhd.Width);
            Console.WriteLine(uhd.Height);

            (ushort Width, ushort Height) hd = (1366, 768); // [3] 이름과 형식 지정
            Console.WriteLine($"{hd.Width}, {hd.Height}, {hd.Width.GetType()}");

            var t1 = Tally1();
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);

            var t2 = Tally2();
            Console.WriteLine(t2.Sum);
            Console.WriteLine(t2.Count);


            var boy = (Name: "철수", Isstudent: true, OrderPrice: 1_000);
            Console.WriteLine($"{boy.Name}(초등학생: {boy.Isstudent}) - 주문: {boy.OrderPrice:C0}");
            Console.WriteLine($"{boy.Name.GetType()}(초등학생 {boy.Isstudent.GetType()}) - 주문: {boy.OrderPrice.GetType():C0}");

            var t = ZeroZero();
            Console.WriteLine($"1: {t.Item1}, 2: {t.Item2}");

            var tt = NameTuple();
            Console.WriteLine($"1: {tt.first}, 2: {tt.second}");

            var tally = Tally();
            Console.WriteLine(tally);
            Console.WriteLine($"1: {tally.Sum}, 2: {tally.Count}");

            var (sum, count) = Tally();
            Console.WriteLine($"sum:{sum}, count:{count}");
        }

        //[1] 튜플 리턴(Tuple Return) 형식: (int, int)
        static (int, int) Tally1()
        {
            var r = (12, 3); //[A] 튜플 리터럴에 2개의 값 담기
            return r; //[B] 튜플 리터럴 반환
        }

        //[2] 튜플 리턴에 이름 값 지정 가능
        static (int Sum, int Count) Tally2() => (45, 6);

        static (int, int) ZeroZero() => default;

        // 튜플 반환값에 first와 second 이름 지정하기
        static (int first, int second) NameTuple()
        {
            var r = (100, 200);
            return r;
        }

        static(int Sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s},{r.c}");
            return r;
        }

        //[?] 튜플 분해(Tuple Deconstruction) 또는 튜플 해체 작업
    }
}
