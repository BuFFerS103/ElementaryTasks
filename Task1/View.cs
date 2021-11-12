using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class View
    {
        public const string Greetings = "This program renders a chess board" +
            " according to the entered parameters\n";
        public const string ErrorMessage = "You have to enter a positive number! \nTry again..\n";
        public const string MenuMessage = "\nPress [Enter] to continue or any key to exit.";
        public const string InstructionMessage = "Enter the number of rows and columns";
        public const string RowsMessage = "Rows [X axis]:";
        public const string ColumnsMessage = "Columns [Y axis]:";
        public const string ContinueRequest = "\nPress [Enter] to repeat or any key to exit.";

        public static void PrintGreetings() => Console.WriteLine(Greetings);
        public static void PrintErrorMessage() => Console.WriteLine(ErrorMessage);
        public static void PrintMenuMessage() => Console.WriteLine(MenuMessage);
        public static void PrintInstructionMessage() => Console.WriteLine(InstructionMessage);
        public static void PrintRowsMessage() => Console.WriteLine(RowsMessage);
        public static void PrintColumnsMessage() => Console.WriteLine(ColumnsMessage);
        public static void PrintContinueRequest() => Console.WriteLine(ContinueRequest);

        public static void DisplayChessBoard(char[] array, uint rows, uint colums)
        {
            for (int i = 0; i < array.Length; i++)  //TODO rows?
            {
                if (i % colums == 0 && i != 0)
                {
                    Console.Write($"\n");
                }
                Console.Write(array[i]);
            }
        }
    }
}
