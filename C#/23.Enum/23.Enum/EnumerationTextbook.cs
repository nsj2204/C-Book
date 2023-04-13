using System;

namespace _23.Enum
{
    class EnumerationTextbook
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{nameof(ConsoleColor.Yellow)} & {nameof(ConsoleColor.White)}");
            Console.ResetColor();
        
        }

        // 열거형(Enumberation) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의



           /* switch (ConsoleColor)
            {
                case ConsoleColor.Black:
                    break;
                case ConsoleColor.DarkBlue:
                    break;
                case ConsoleColor.DarkGreen:
                    break;
                case ConsoleColor.DarkCyan:
                    break;
                case ConsoleColor.DarkRed:
                    break;
                case ConsoleColor.DarkMagenta:
                    break;
                case ConsoleColor.DarkYellow:
                    break;
                case ConsoleColor.Gray:
                    break;
                case ConsoleColor.DarkGray:
                    break;
                case ConsoleColor.Blue:
                    break;
                case ConsoleColor.Green:
                    break;
                case ConsoleColor.Cyan:
                    break;
                case ConsoleColor.Red:
                    break;
                case ConsoleColor.Magenta:
                    break;
                case ConsoleColor.Yellow:
                    break;
                case ConsoleColor.White:
                    break;
                default:
                    break;
            }*/

    }
}

