using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
    public partial class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        partial void Imprimir();//sólo puede ser void y no puede tener modificadores de acceso

        public void MiMetodo()
        {
            Console.WriteLine("Llamada a método parcial: ");
            Imprimir();//si no tiene implementación el compilador eliminará el método
        }


    }
}
