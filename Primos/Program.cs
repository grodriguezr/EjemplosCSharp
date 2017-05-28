using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Primos primesFrom2To1000 = new Primos(2, 1000);
            foreach (long i in primesFrom2To1000)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}
