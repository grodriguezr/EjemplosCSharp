using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            //OperadoresBasicos();
            //OperadoresBooleanos();
            OperadorTernario();

            Console.ReadLine();
        }

        private static void OperadoresBasicos()
        {
            bool valor = false;

            Console.WriteLine("Ingrese v1 ");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese v2 ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            valor = v1 == v2;

            Console.WriteLine("Valor es: " + valor);
        }

        private static void OperadoresBooleanos()
        {
            Console.WriteLine("Escriba un número entero");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of the above is true? { isLessThan10 ^ isBetween0And5} ");//este es un o exclusivo

        }

        private static void OperadorTernario()
        {
            Console.WriteLine("Escriba un número entero");
            int myInt = Convert.ToInt32(Console.ReadLine());


            string numero = (myInt < 10) ? "Número es menor que 10" : "Número es mayor que  10";//sí -no

            Console.WriteLine(numero + $" y es {myInt} unidad{(myInt==1 || myInt == -1 ? "":"es")}");
        }
    }
}
