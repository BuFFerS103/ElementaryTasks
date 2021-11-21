using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Sequence
    {
        private readonly uint _lenght;
        private readonly uint _minSquare;
        private readonly uint[] _values;

        public Sequence(uint lenght, uint minSquare)
        {
            _lenght = lenght;
            _minSquare = minSquare;
            _values = new uint[_lenght];

            uint minValue = (uint)Math.Ceiling(Math.Sqrt(_minSquare));

            _values[0] = minValue;

            for (uint i = 1; i < _lenght; i++)
            {
                _values[i] = minValue + i;
            }
        }

        public override string ToString()
        {
            return String.Join(", ", _values);
        } 

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
