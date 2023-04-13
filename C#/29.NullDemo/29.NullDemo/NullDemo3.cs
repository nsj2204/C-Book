using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.NullDemo
{
    class NullDemo3
    {
        static void Main(string[] args)
        {
            // ?? 연산자 (Null 변합 연산자(Null Coalescing Operator))
            double? d = null;
            Console.WriteLine(d);

            Console.WriteLine(d?.ToString());

            double? e = 1.0;

            Console.WriteLine(e?.ToString());
            Console.WriteLine(e?.ToString("#.00"));

            int? len;
            string message;

            message = null;
            len = message?.Length;
            Console.WriteLine(len);

            message = "안녕";
            len = message?.Length;
            Console.WriteLine(len);


            // ?. 연산자: 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
            List<string> list = null;
            int? numberOflist;

            // [1] 리스트가 null이면 null 반환
            numberOflist = list?.Count;
            Console.WriteLine(numberOflist);

            list = new List<string>();
            list.Add("안녕하세요."); list.Add("반갑습니다.");

            // [2] 리스트가 null이 아니므로 Count 속성의 값인 2 반환
            numberOflist = list?.Count; //2
            Console.WriteLine(numberOflist);

        }
    }
}
