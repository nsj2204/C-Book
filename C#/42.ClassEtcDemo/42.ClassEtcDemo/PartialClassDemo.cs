using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassEtcDemo
{


    class PartialClassDemo
    {
        static void Main(string[] args)
        {
            var hello = new Hello();
            hello.Hi();  // Alt + F12 로 미리보기 가능
            hello.Bye(); 
        }
    }
}
