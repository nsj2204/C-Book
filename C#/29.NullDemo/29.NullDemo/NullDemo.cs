using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.NullDemo
{
    class NullDemo
    {
        static void Main(string[] args)
        {
            Nullable<bool> bln = null;
            Console.WriteLine(bln.HasValue);

            bln = true;
            Console.WriteLine(bln.HasValue);

            string s = null;
            // int i = null;  -> error
            Nullable<int> ii = null;
            int? iii = null;
            Nullable<double> dd = null;
            int? ddd = null;

        }
    }
}
