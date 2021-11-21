using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    class Controller
    {
        public static int SetValue()
        {
            do
            {
                try
                {
                    int value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Communication.PrintErrorMessage();
                    Communication.PrintContinueRequest();
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key != ConsoleKey.Enter)
                    {
                        return 0;
                    }
                    Console.WriteLine();
                }
            } while (true);
        }
        public static bool ContinueRequest()
        {
            Communication.PrintContinueRequest();
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            bool proceed = keyInfo.Key == ConsoleKey.Enter;
            Console.Clear();
            return proceed;
        }
    }
}
