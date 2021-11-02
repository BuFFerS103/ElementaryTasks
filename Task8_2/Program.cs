using System;

namespace Task8_2
{
    class Program
    {
        static void Render(uint minVal, uint maxVal, uint lenght)
        {
            uint currentVal = 1;
            uint prevVal = 0;
            uint tempVal;

            while (true)
            {
                tempVal = prevVal;
                prevVal = currentVal;
                currentVal += tempVal;

                if (currentVal >= minVal && currentVal <= maxVal)
                {
                    Console.WriteLine(currentVal);
                    continue;
                }
                
                if (currentVal.ToString().Length == lenght)
                {
                    Console.WriteLine(currentVal);
                    continue;
                }
                
                if (currentVal > maxVal && currentVal.ToString().Length > lenght)
                {
                    break;
                }
            }
        }


        static void Main(string[] args)
        {
            uint a = 1;
            uint b = 100;
            uint c = 3;
            Render(a,b,c);

        }
    }
}
