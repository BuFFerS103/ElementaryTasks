using System;
using System.Collections.Generic;

namespace Task8
{
    class Program
    {
        static List<uint> numbers = new List<uint>() { };  ///false
        static string ExMes = "You have to enter a number! \nTry again..\n";

        static int RangeFirst()
        {
            int num;
            while (true)
            {
                Console.WriteLine("");
                if (Int32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static int RangeLast()
        {
            int num;
            while (true)
            {
                Console.WriteLine("");
                if (Int32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static int Length()
        {
            int num;
            while (true)
            {
                Console.WriteLine("");
                if (Int32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }

        static void BuildData()
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
            uint a = 20;
            uint b = 100;
            uint c = 3;
           
            BuildData();
            RangeRender(a, b);
            Console.WriteLine("***");
            LengthRender(c);
        }
    }
}
