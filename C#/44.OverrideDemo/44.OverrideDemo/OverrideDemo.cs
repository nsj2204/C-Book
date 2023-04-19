using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.OverrideDemo
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
        public virtual void Work() => Console.WriteLine("부모_프로그래머.");
    }

    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다.");
        public override void Walk() => base.Walk(); // 관대한 부모의 의견을 따르다.
        public override void Work() => Console.WriteLine("자식_프로게이머");
    }

    class OverrideDemo
    {
        static void Main(string[] args)
        {
            Child child = new Child(); 
            child.Say(); // 자식이 예의가 없는 경우 : X -> X
            child.Run(); // 자식이 예의가 있는 경우 : X -> new
            child.Walk(); // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
            child.Work(); // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
        }
    }
}
