using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static Dictionary<int, Action<string[]>> ProgramNumber;

        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            int taskNumber;

            ProgramNumber = new Dictionary<int, Action<string[]>>
            {
                {4, new Action<string[]>(Task4.Program.Main)},
                 {7, new Action<string[]>(Task7.Program.Main)},
            };

            do
            {
                Console.Clear();
                Messages.PrintGreetings();
                taskNumber = Controller.SetValue();
                if (taskNumber > 0 && taskNumber < 9)
                {
                    ProgramNumber[taskNumber].Invoke(args);
                }
                else
                {
                    Messages.PrintBoundsOfTasks();
                }

                Messages.PrintContinueRequest();                                 //Missing first sign
                input = Console.ReadKey();
            } while (input.Key == ConsoleKey.Enter);

        }
    }
}
