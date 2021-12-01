using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Messages
    {
        private const string Greetings = "Choose the number of the task (1-8)";
        public static void PrintGreetings()
        {
            Console.WriteLine(Greetings);
        }

        private const string ContinueRequest = "Press [Enter] to choose another task or any key to exit";
        public static void PrintContinueRequest()
        {
            Console.WriteLine(ContinueRequest);
        }

        private const string BoundsOfTasks = "You have to choose the task from 1 to 8";
        public static void PrintBoundsOfTasks()
        {
            Console.WriteLine(BoundsOfTasks);
        }
    }
}
