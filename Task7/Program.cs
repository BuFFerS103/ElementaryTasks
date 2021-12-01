using System;

namespace Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uint lenghtOfSequence = 3;      //TODO input
            uint raisedNumber = 122;

            Sequence sequence = new Sequence(lenghtOfSequence, raisedNumber);
            sequence.BuildSequence();
            sequence.Print();
        }
    }
}
