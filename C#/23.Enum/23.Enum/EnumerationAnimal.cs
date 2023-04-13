using System;

enum Animal { Mouse, Cow = 5, Tiger };
enum Animal2 { Mouse, Cow, Tiger };

namespace _23.Enum
{
    class EnumerationAnimal
    {
        static void Main()
        {
            Animal tiger = Animal.Tiger;
            Console.WriteLine((int)tiger);
            Animal2 animal = Animal2.Mouse;
            Console.WriteLine(animal);
        }
        
    }
}

