using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Primos
    {
        private long min;
        private long max;
        public Primos() : this(2, 100) { }
        public Primos(long minimum, long maximum)
        {
            if(minimum < 2) { min = 2; }
            else { min = minimum; }
            max = maximum;
        }
        public IEnumerator GetEnumerator()
        {
            for(long possiblePrime =  min; possiblePrime <= max; possiblePrime++)
            {
                bool isPrime = true;
                for (long possibleFactor = 2; possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime)); possibleFactor++)
                {
                    long remainderAfterDivision = possiblePrime % possibleFactor;
                    if(remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) { yield return possiblePrime; }
            }
        }
    }
}
