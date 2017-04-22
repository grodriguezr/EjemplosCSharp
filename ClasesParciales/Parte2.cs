using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
    public partial class Rectangulo
    {
        public double Area()
        {
            return this.Base * this.Altura;
        }
        public double Perimetro()
        {
            return (2 * this.Base + 2 * this.Altura);
        }
    }
}
