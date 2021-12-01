using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
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
                    Messages.PrintContinueRequest();
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key != ConsoleKey.Enter)
                    {
                        return 0;
                    }
                    Console.WriteLine();
                }
            } while (true);  //TODO avoid!
        }   
    }
}
