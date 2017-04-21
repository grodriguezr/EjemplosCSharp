using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        delegate double ProcesoDelegado(double param1, double param2);
        static double Multiplicar(double param1, double param2) => param1 * param2;
        static double Dividir(double param1, double param2) => param1 / param2;
        static void Main(string[] args)
        {
            ProcesoDelegado proceso;
            Console.WriteLine("Escriba dos números separados por una coma:");
            string entrada = Console.ReadLine();
            int comaPos = entrada.IndexOf(',');
            double param1 = Convert.ToDouble(entrada.Substring(0, comaPos));
            double param2 = Convert.ToDouble(entrada.Substring(comaPos + 1, entrada.Length - comaPos - 1));
            Console.WriteLine($"param1: {param1}, param2: {param2}");
            Console.WriteLine("Escriba M para multiplicar o D para dividir");
            entrada = Console.ReadLine();
            if(entrada == "M")
            {
                proceso = new ProcesoDelegado(Multiplicar);
                //proceso = Multiplicar;
            }else
            {
                proceso = new ProcesoDelegado(Dividir);
                //proceso = Dividir;//otra forma válida de hacer esto
            }
            Console.WriteLine($"Resultado: {proceso(param1, param2)}");

            Console.ReadLine();

        }
    }
}
