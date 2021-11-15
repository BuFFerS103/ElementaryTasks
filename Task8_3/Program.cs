using System;
using System.Collections.Generic;

namespace Task8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 2;
            int maxValue = 100;
            var fibonacciNumbers = new List<int> { 1, 1 };
            fibonacciNumbers = Builder.BuildSequenceWithBounds(fibonacciNumbers, maxValue);
            Display.DisplaySequenceWithBounds(fibonacciNumbers, minValue, maxValue);

            //TODO build with lenght
        }
    }
}
