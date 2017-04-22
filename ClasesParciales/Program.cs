using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            
            Console.WriteLine("Escriba la base del rectángulo: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la altura del rectángulo: ");
            a = Convert.ToDouble(Console.ReadLine());

            Rectangulo miRectangulo = new Rectangulo(b, a);

            Console.WriteLine($"El área del rectángulo es: {miRectangulo.Area()}");
            Console.WriteLine($"El perímetro del rectángulo es: {miRectangulo.Perimetro()}");

            miRectangulo.MiMetodo();

            Console.ReadLine();

        }
    }
}
