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
            uint currentVal = 1;
            uint prevVal = 0;
            uint tempVal;

            while (true)
            {
                tempVal = prevVal;
                prevVal = currentVal;
                currentVal += tempVal;

                if (currentVal >= minVal && currentVal <= maxVal)
                {
                    Console.WriteLine(currentVal);
                    continue;
                }
                
                if (currentVal.ToString().Length == lenght)
                {
                    Console.WriteLine(currentVal);
                    continue;
                }
                
                if (currentVal > maxVal && currentVal.ToString().Length > lenght)
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
