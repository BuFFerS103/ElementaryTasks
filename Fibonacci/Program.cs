using System;

namespace Fibonacci
{
    class Program
    {
        static string ExMes = "You have to enter a number! \nTry again..\n";

        static int RangeStart()
        {
            int num;
            while (true)
            {
                Console.WriteLine("");
                if (Int32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static int RangeFinish()
        {
            int num;
            while (true)
            {
                Console.WriteLine("");
                if (Int32.TryParse(Console.ReadLine(), out num)) return num;
                else Console.WriteLine(ExMes);
            }
        }
        static void RangeCalculation(int start, int finish)
        {
            int result = 0;
            int curr = start;
            int tmp;

            for (int i = 0; curr <= finish; i++)
            {
                Console.WriteLine(curr);
                tmp = result;
                result = curr;
                curr += tmp;
            }
        }


        static void Main(string[] args)
        {
            int a = 20;
            int b = 100;
            RangeCalculation(a,b);
        }
    }
}
