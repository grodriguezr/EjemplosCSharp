using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClaseTres : IMiNuevaInterfaz
    {
        public void ImprimeMensaje()
        {
            Console.WriteLine("Metodo implementado en ClaseTres");

        }

        public void NuevaImpresion()
        {
            Console.WriteLine("Metodo nuevo implementado en ClaseTres");

        }
    }
}
