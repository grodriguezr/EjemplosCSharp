using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ColeccionesIndexers
{
    public class Animals : CollectionBase//colecciones fuertemente tipadas
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }
        public Animal this[int animalIndex]//indexer
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
