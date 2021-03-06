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
            int current = 0;
            for (int i = current; i < maxValue; i++)
            {
                int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                current = previous + previous2;

                fibonacciNumbers.Add(current);
            }
            return fibonacciNumbers;
        }
    }
}
