using System;

enum Color
{
    Red = 10,
    Green,
    Blue =20
}

namespace _14.Switch
{
    class SwitchDescription
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요.");
            int answer = Convert.ToInt32(Console.ReadLine());

            //선택문
            switch (answer)
            {
                case 1:
                    Console.WriteLine("1을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2을 선택했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("그냥 찍으셨군요.");
                    break;
            }


            Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            string weather = Console.ReadLine();

            //선택문
            switch (weather)
            {
                case "맑음":
                    Console.WriteLine("오늘 날씨는 맑군요.");
                    break;
                case "흐림":
                    Console.WriteLine("오늘 날씨는 흐리군요.");
                    break;
                case "비":
                    Console.WriteLine("오늘 날씨는 비가 오는군요.");
                    break;
                default:
                    Console.WriteLine("혹시 눈이 내리나요.");
                    break;
            }


            var color = Color.Green;

            switch (color)
            {
                case Color.Red:
                case Color.Green:
                    Console.WriteLine("R 또는 G");
                    break;
                case Color.Blue:
                    break;
                default:
                    break;
            }


        }
    }
}
