using System;
using static System.Console;


namespace _26.ExceptionDemo
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch (Exception ex)
            {
                WriteLine("에러가 발생했습니다.");
                WriteLine(ex.Message);
            }

            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch (Exception ex)
            {
                WriteLine("에러가 발생했습니다.");
                WriteLine(ex);
            }
        }
    }
}
