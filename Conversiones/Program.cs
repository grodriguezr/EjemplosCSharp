using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConversionImplicita();
            //ConversionExplicita();
            ConversionExplicitaComandos();
        }
        private static void ConversionImplicita()
        {
            ushort varibaleDestino;
            char variableFuente = 'a';
            varibaleDestino = variableFuente;
            Console.WriteLine($"variableFuente valor: {variableFuente}");
            Console.WriteLine($"variableDestino valor: {varibaleDestino}");
            Console.ReadLine();
        }
        private static void ConversionExplicita()
        {
            byte varibaleDestino;
            short variableFuente = 7;
            //short variableFuente = 281;//este desborda la conversión
            //varibaleDestino = (byte)variableFuente;
            varibaleDestino = checked ((byte)variableFuente);//usado para prevenir errores de desbordamiento de datos en conversiones explícitas

            Console.WriteLine($"variableFuente valor: {variableFuente}");
            Console.WriteLine($"variableDestino valor: {varibaleDestino}");
            Console.ReadLine();
        }

        private static void ConversionExplicitaComandos()
        {
            Console.WriteLine("Digite un número double");
            double miDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(miDouble);
            Console.ReadLine();
        }
    }
}
