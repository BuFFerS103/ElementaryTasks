using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    class Runner
    {
        public static void Run()
        {
            bool proceed;
            do
            {
                Communication.PrintGreetings();
                int startValue = 1;

                Communication.PrintInstructionMessageRange();
                int minValue = Controller.SetValue();
                int maxValue = Controller.SetValue();

                Communication.PrintInstructionMessageLenght();
                int lenght = Controller.SetValue();

                List<int> fibonacciNumbers = new List<int> { startValue, startValue };

                fibonacciNumbers = Builder.BuildSequenceWithBounds(fibonacciNumbers, maxValue);

                Display.DisplaySequenceWithBounds(fibonacciNumbers, minValue, maxValue);
                Communication.PrintSeparationLine();
                Display.LengthRender(fibonacciNumbers, lenght);

                proceed = Controller.ContinueRequest();
            } while (proceed);
        }
    }
}
