using System;

namespace Task8_2
{
    class Program
    {
        static string ExMes = "You have to enter a number! \nTry again..\n";
        static string Greetings = "This program reproduces the fibonacci sequence according to the entered parameters\n";
        static string Result = "Result:";
        static string MenuMes = "\nPress any key to continue or [Esc] to exit.";

        static uint RangeFirst()
        {
            uint num;
            while (true)
            {
                Console.WriteLine("Specify a range of numbers [e.g. 1, 100]\nEnter the first number of range:");
                if (UInt32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static uint RangeLast()
        {
            uint num;
            while (true)
            {
                Console.WriteLine("Enter the last number of range");
                if (UInt32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static uint Length()
        {
            uint num;
            while (true)
            {
                Console.WriteLine("\nEnter the lenght of numbers [e.g. 3 = 144, 233, 377 etc.]");
                if (UInt32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }

        static void Render(uint minVal, uint maxVal, uint lenght)
        {
            uint currentValue = 1;
            uint prevVauel = 0;
            uint tempValue;

            while (true)
            {
                tempValue = prevVauel;
                prevVauel = currentValue;
                currentValue += tempValue;

                if (currentValue >= minVal && currentValue <= maxVal)
                {
                    Console.WriteLine(currentValue);
                    continue;
                }
                
                if (currentValue.ToString().Length == lenght)
                {
                    Console.WriteLine(currentValue);
                    continue;
                }
                
                if (currentValue > maxVal && currentValue.ToString().Length > lenght)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Greetings);

                uint rangeFirst = RangeFirst();
                uint rangeLast = RangeLast();
                uint lenght = Length();

                Console.WriteLine($"\n{Result}\n");
                Render(rangeFirst, rangeLast, lenght);

                Console.WriteLine(MenuMes);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape) return;
                Console.Clear();
            }
        }
    }
}
