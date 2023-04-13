using System;

namespace _25.StringFunction
{
    class StringToCharArray
    {
        static void Main()
        {
            String s = "안녕하세요.";
            char[] ch = s.ToCharArray();

            for(int i =0; i<ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

           
        }
    }
}
