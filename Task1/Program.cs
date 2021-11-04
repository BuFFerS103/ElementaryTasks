using System;

namespace Chess
{
    class Program
    {
        static string ExMes = "You have to enter a number! \nTry again..\n";
        static string MenuMes = "\nPress any key to continue or [Esc] to exit.";
        static string Greetings = "This program renders a chess board according to the entered parameters\n";

        static uint AxisX()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of rows [X axis]:");
                if (UInt32.TryParse(Console.ReadLine(), out uint num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static uint AxisY()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of columns [Y axis]:");
                if (UInt32.TryParse(Console.ReadLine(), out uint num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static void Render(uint x, uint y)
        {
            char idle = ' ';
            char filled = '#';
            Console.WriteLine();
            for (uint i = 0; i < y; i++)
            {
                for (uint j = 1; j < x; j++)
                {
                    if ((i+j)%2 == 0) Console.Write(idle);
                    else Console.Write(filled);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Greetings);
            while (true)
            {
                uint x = AxisX();
                uint y = AxisY();
                Render(x, y); 
                Console.WriteLine(MenuMes);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape) return;
                Console.Clear();
            }
        }
    }
}
