using System;
using System.Collections.Generic;

namespace Task8
{
    class Program
    {
        static List<uint> numbers = new List<uint>() { };  
        static string ExMes = "You have to enter a number! \nTry again..\n";
        static string Greetings = "This program reproduces the fibonacci sequence according to the entered parameters\n";
        static string Result = "Result:";

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

        static void Render()
        {
            uint result = 0;
            uint curr = 1;
            uint tmp;

            for (int i = 0; i < ushort.MaxValue; i++)
            {
                tmp = result;
                result = curr;
                curr += tmp;
                numbers.Add(curr);
            }
        }

        static void LengthRender(uint lenght)
        {
            foreach (uint item in numbers)
            {
                if (item.ToString().Length == lenght)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void RangeRender(uint start, uint finish)
        {
            foreach (int item in numbers)
            {
                if (item >= start && item < finish)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Greetings);

            uint rangeFirst = RangeFirst();
            uint rangeLast = RangeLast();
            uint lenght = Length();

            Console.WriteLine($"\n{Result}\n");
            Render();
            RangeRender(rangeFirst, rangeLast);
            Console.WriteLine("\n***");
            LengthRender(lenght);
        }
    }
}
