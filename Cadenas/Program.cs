using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola mundo!!!";
            char caracter = cadena[3];
            char[] trimChars = { ' ', 'e', 's' };
            char[] separator = { ' ' };

            Console.WriteLine(caracter);

            Console.WriteLine("Escriba un texto");
            string miTexto = Console.ReadLine();
            Console.WriteLine($"Usted ha escrito {miTexto.Length} caracteres");

            Console.WriteLine($"En mayúsculas: {miTexto.ToUpper()}");
            Console.WriteLine($"En minúsculas: {miTexto.ToLower()}");
            //miTexto = miTexto.Trim(trimChars);
            Console.WriteLine($"Usando Trim(): {miTexto.Trim(trimChars)}");
            Console.WriteLine($"Usando PadLeft(): {miTexto.PadLeft(10)}");//hace que un string tenga un tamaño deseado añadiendo espacios en blanco
            Console.WriteLine($"Usando PadLeft(-): {miTexto.PadLeft(10, '-')}");//hace que un string tenga un tamaño deseado añadiendo '-'
            string[] miTextoSplit = miTexto.Split(separator);//convierte un string en un array dividiéndolo en la parte dada, en este caso: ' '
            foreach (string word in miTextoSplit)
            {
                Console.WriteLine(word);
            }

            int valor = 2;
            CambiaValor(ref valor);//la función altera el valor de la variable directamente ya que se pasa por referencia
            Console.WriteLine(valor);




            //Console.WriteLine("Ingrese número entero ");
            //int miNumero = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese string ");
            //string miCadena = Console.ReadLine();

            //Console.WriteLine($"El número es {miNumero} y la cadena es: {miCadena}");
            Console.ReadLine();
        }
        private static int CambiaValor(ref int valor)
        {
            valor *= valor;
            return valor;
        }
    }
}
