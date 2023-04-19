using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassEtcDemo
{
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => System.Console.WriteLine($"{Name}: {Age}");
    }

    class PartialClassDemo2
    {
        static void Main()
        {
            Person person = new Person();

            person.Name = "C#";
            person.Age = 20;

            person.Print();
        }
    }
}
