using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Escriba el número del cual desea conocer su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El factorial(no recursivo) es: {FactorialNoRecursivo(numero)}");
            sw.Start();
            Console.WriteLine($"El factorial(recursivo) es: {FactorialRecursivo(numero)}");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.ReadLine();
        }
        private static int FactorialNoRecursivo(int n)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            sw.Stop();
            Console.WriteLine("Tiempo no recursivo: "+sw.Elapsed);
            return factorial;
        }

        private static int FactorialRecursivo(int n)
        {
            Stopwatch sw = new Stopwatch();
            int factorial;
            if (n == 1) return 1;
            factorial = n * FactorialRecursivo(n - 1);

            return factorial;
        }
    }
}
