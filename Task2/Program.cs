﻿using System;

namespace Task2
{
    class Program
    {
        static string ExMes = "You have to enter a number! \nTry again..\n";
        static string MenuMes = "\nPress [Y] to continue or any key to exit.";
        static string Greetings = "This program calculates the condition of the [Task 2] using the entered floating point parameters";
        static string Condition1 = "\nEnter two floating point numbers of the 1st rectangle [basic] (e.g. 4,2)";
        static string Condition2 = "\nEnter two floating point numbers of the 2nd rectangle [you want to fit] (e.g. 4,2)";
        static string Success = "\nSuccess :)";
        static string Fail = "\nFail :(";

        static double AxisX()
        {
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out double num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static double AxisY()
        {
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out double num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static bool Calculate(double a, double b, double c, double d)
        {
            if (c < a && d < b)
            {
                Console.WriteLine(Success);
                return true;
            }
            else
            {
                Console.WriteLine(Fail);
                return false;
            }
            
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Greetings);
                Console.WriteLine(Condition1);
                double firstX = AxisX();
                double firstY = AxisY();
                Console.WriteLine(Condition2);
                double secondX = AxisX();
                double secondY = AxisY();
                Calculate(firstX, firstY, secondX, secondY);

                Console.WriteLine(MenuMes);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key != ConsoleKey.Y) return;
                Console.Clear();
            }

        }
    }
}
