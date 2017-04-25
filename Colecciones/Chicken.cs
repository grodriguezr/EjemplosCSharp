using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesIndexers
{
    class Chicken : Animal
    {
        public void LayEgg() => Console.WriteLine($"{name} ha puesto un huevo");
        public Chicken(string newName) : base(newName) { }
    }
}
