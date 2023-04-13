using System;

namespace _25.StringFunction
{
    class StringEquals
    {
        static void Main()
        {
            string userName = "RedPlus";
            string userNameInput = "redplus";

            // [1] == 연산자 사용
            if(userName.ToLower() == userNameInput)
            {
                Console.WriteLine("같습니다.");
            }
            
            // [2] string.Equals 메서드 사용
            if(string.Equals(userName, userNameInput,
                StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("같습니다.");
            }

        }
    }
}
