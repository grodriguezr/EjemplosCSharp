using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesComplejas
{
    enum orientacion : byte
    {
        norte = 1,
        sur = 2,
        este = 3,
        oeste = 4
    }
    class Estructura
    {
        static void Main(string[] args)
        {
            Cliente miCliente;
            miCliente.nombre = "Gustavo";
            miCliente.apellido = "Rodríguez";
            Ruta miRuta;
            int miDireccion = -1;
            double miDistancia;
            Console.WriteLine("1) Norte\n2) Sur\n3) Este\n4) Oeste");
            do
            {
                Console.WriteLine("Elija una dirección:");
                miDireccion = Convert.ToInt32(Console.ReadLine());
            } while (miDireccion < 1 || miDireccion > 4);
            Console.WriteLine("Escriba una distancia:");
            miDistancia = Convert.ToDouble(Console.ReadLine());
            miRuta.direccion = (orientacion)miDireccion;
            miRuta.distancia = miDistancia;
            Console.WriteLine($"miRuta especifica una dirección de {miRuta.direccion} y una distancia de {miRuta.distancia}");
            Console.WriteLine(miCliente.NombreCompleto());

            Console.ReadLine();
            
        }
    }
    struct Ruta
    {
        public orientacion direccion;
        public double distancia;
    }
    struct Cliente
    {
        public string nombre;
        public string apellido;
        public string NombreCompleto() => nombre + " " + apellido;
    }
}
