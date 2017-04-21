using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona p = new Persona();
            //Persona p2 = new Persona();

            //List<Persona> personas = new List<Persona>
            //{
            //    new Persona(),
            //    new Persona()
            //};
            Console.WriteLine("Digite el primer número");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo número");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de sumar es: {Operaciones.Sumar(x, y)}");
            Console.WriteLine($"El resultado de restar es: {Operaciones.Restar(x, y)}");
            Console.WriteLine($"El resultado de multiplicar es: {Operaciones.Multiplicar(x, y)}");
            Console.WriteLine($"El resultado de dividir es: {Operaciones.Dividir(x, y)}");
            //Console.WriteLine($"Cantidad de instancias de Persona: {personas[1].ImprimeContador()}");
            Console.WriteLine($"Cantidad de instancias de Persona: {Persona.ImprimeContadorEstatico()}");//llama al constructor estático
            

            Console.ReadLine();
        }
    }
}
