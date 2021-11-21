using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 0xffffff;
            uint m = 122;

            Sequence sequence = new Sequence(n, m);
            sequence.Print();
        }
    }
}
