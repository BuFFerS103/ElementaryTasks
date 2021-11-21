using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    class Communication
    {
        private const string Greetings = "This program renders a Fibonacci sequence " +
            " according to the entered parameters\n";
        private const string ErrorMessage = "You have to enter a number! \nTry again..\n";
        private const string MenuMessage = "\nPress [Enter] to continue or any key to exit.";
        private const string InstructionMessageRange = "Enter the bounds of sequence";
        private const string InstructionMessageLenght = "\nEnter the lenght of numbers [e.g. 3 = 144, 233, 377 etc.]";
        private const string ContinueRequest = "\nPress [Enter] to repeat or any key to exit.";
        private const string SeparationLine = "\n*******\n";

        public static void PrintGreetings() => Console.WriteLine(Greetings);
        public static void PrintErrorMessage() => Console.WriteLine(ErrorMessage);
        public static void PrintMenuMessage() => Console.WriteLine(MenuMessage);
        public static void PrintInstructionMessageRange() => Console.WriteLine(InstructionMessageRange);
        public static void PrintInstructionMessageLenght() => Console.WriteLine(InstructionMessageLenght);
        public static void PrintContinueRequest() => Console.WriteLine(ContinueRequest);
        public static void PrintSeparationLine() => Console.WriteLine(SeparationLine);
    }
}
