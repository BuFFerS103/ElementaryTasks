using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    class Builder
    {
        public static List<int> BuildSequenceWithBounds(List<int> fibonacciNumbers, int maxValue)
        {
            var current = 0;

            while (current < maxValue)
            {
                int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                current = previous + previous2;

                fibonacciNumbers.Add(current);          //if???   for???
            }
            fibonacciNumbers.RemoveAt(fibonacciNumbers.Count - 1);

            return fibonacciNumbers;
        }
    }
}
