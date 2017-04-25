using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesIndexers
{
    class Animal
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }//verificar a quitar línea 11
        public Animal()
        {
            name = "Animal sin nombre";
        }
        public Animal(string newName)
        {
            name = newName;
        }
        public void Feed() => Console.WriteLine($"{name} ha sido alimentado/a.");
    }
}
