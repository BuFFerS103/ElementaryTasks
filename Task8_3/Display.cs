using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_3
{
    class Display
    {
        public static void DisplaySequenceWithBounds(List<int> fibonacciNumbers, int minValue, int maxValue)
        {
            foreach (var item in fibonacciNumbers)  
            {
                if (item > minValue && item < maxValue)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void LengthRender(List<int> fibonacciNumbers, int length)
        {
            foreach (int item in fibonacciNumbers)
            {
                if (item.ToString().Length == length)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
