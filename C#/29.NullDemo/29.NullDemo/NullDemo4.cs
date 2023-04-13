using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.NullDemo
{
    class NullDemo4
    {
        static void Main(string[] args)
        {
            // ?? 연산자 (Null 변합 연산자(Null Coalescing Operator)) : 컬렉션이 null이 아니면 해당 값 반환, null이면 뒤에 지정한 값 반환
            // ?. 연산자 (Null 조건부 연산자) : 컬렉션이 null이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환

            int num;
            List<string> list;

            list = null;
            num = list?.Count ?? 0;
            Console.WriteLine(num);

            list = new List<string>(); list.Add("또 만나요.");
            num = list?.Count ?? 0;
            Console.WriteLine(num);

        }
    }
}
