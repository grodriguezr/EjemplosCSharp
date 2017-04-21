using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticos
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private static int contador = 0;
        //public Persona()//se llama cada vez que se crea una nueva instancia
        //{
        //    contador++;
        //}

        static Persona()//se llama una sola vez para todas las instancias creadas,no puede tener parámetros
        {
            contador++;
        }

        public int ImprimeContador()
        {
            return contador;
        }
        public static int ImprimeContadorEstatico()
        {
            return contador;
        }
    }
}
