using System;


namespace _24.ClassDemo
{

    class RandomDemo
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(1,6));

            string s = "Foo";
            Console.WriteLine(s is string);
            int i = 1_234;
            Console.WriteLine(i is string);

            object x = 1234;
            string S = x as string;
            Console.WriteLine(S);
            
            x = "1234";
            S = x as string;
            Console.WriteLine(S);

        }
    }
}
