using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IMiInterfaz prueba1 = new ClaseUno();
            IMiInterfaz prueba2 = new ClaseDos();
            IMiInterfaz prueba3 = new ClaseTres();
            IMiNuevaInterfaz prueba4 = new ClaseTres();

            ClaseUno miClase = new ClaseUno();
            ClaseDos miClase2 = new ClaseDos();
            IMiInterfaz miInterfaz;
            miInterfaz = miClase;
            Console.WriteLine($"Llamado por polimorfismo de interfaces: ");
            miInterfaz.ImprimeMensaje();
            miInterfaz = miClase2;
            miInterfaz.ImprimeMensaje();
            Console.WriteLine();





            prueba4.NuevaImpresion();

            

            ClaseUno cu = new ClaseUno();
            cu.ImprimeMensaje();
            MiMetodo(cu);

            ClaseDos cd = new ClaseDos();
            cd.ImprimeMensaje();
            MiMetodo(cd);

            Console.ReadLine();
        }
        private static void MiMetodo(IMiInterfaz m)
        {
            Console.WriteLine("Llamada dentro de método");
            m.ImprimeMensaje();
        }
    }
}
