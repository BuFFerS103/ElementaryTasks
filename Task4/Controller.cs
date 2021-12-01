using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Controller
    {
        private bool _proceed;

        public void Run()   
        {
            do
            {
                Parser parser = new Parser();
                parser.ReadFile();
                parser.ChangeFile();
                parser.DisplayFile();
                parser.Dispose();
                GC.Collect(); 
                _proceed = ContinueRequest();
            } while (_proceed);
        }

        public static string SetValues()
        {
            return Console.ReadLine();
        }   //TODO to separate class?

        public static bool ContinueRequest()
        {
            Messages.PrintContinueRequest();
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            bool proceed = keyInfo.Key == ConsoleKey.Enter;
            Console.Clear();
            return proceed;
        }
    }
}
