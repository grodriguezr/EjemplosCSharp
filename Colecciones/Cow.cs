using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesIndexers
{
    class Cow : Animal
    {
        public void Milk() => Console.WriteLine($"{name} fue ordeñada.");
        public Cow(string newName) : base(newName) { }
    }
}
