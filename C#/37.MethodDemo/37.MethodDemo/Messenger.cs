using System;

namespace _37.MethodDemo
{

    class Messenger
    {
        public void PrintMessage(string message, string prefix = "", string suffix = "")
        {
            Console.WriteLine($"{prefix}{message}{suffix}");
        }

        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.PrintMessage("My");
            messenger.PrintMessage(prefix: "Oh", message: "My");
            messenger.PrintMessage(prefix: "Oh", message: "My", suffix: "God");
            messenger.PrintMessage("My", "Oh", "God");
            messenger.PrintMessage("Oh ", "My ", "God ");
        }
    }
}
