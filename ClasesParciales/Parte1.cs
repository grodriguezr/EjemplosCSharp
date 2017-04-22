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

    }
}
