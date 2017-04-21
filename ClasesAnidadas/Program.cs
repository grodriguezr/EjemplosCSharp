using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAnidadas
{
    public class ClassA
    {
        private int state = -1;
        public int State
        {
            get { return state; }
        }
        public class ClassB//la clase tiene acceso a los miembros privados y protegidos de su clase contenedora
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ClassA myObject = new ClassA();
            Console.WriteLine($"MyObject.State = {myObject.State}");
            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");
            Console.ReadLine();
        }
    }
}
