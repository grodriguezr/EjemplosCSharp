using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class MyBase { }
    internal class MyCLass : MyBase { }
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyComplexClass : MyCLass, IMyInterface { }
    //Interfaces a implementar explícitamente
    #region Interfaces
    public interface IInterface1
    {
        void Imprimir();
    }
    public interface IInterface2
    {
        void Imprimir();
    }
    #endregion



    class Program : IInterface1, IInterface2
    {
        static void Main(string[] args)
        {
            MyComplexClass MyObj = new MyComplexClass();
            Console.WriteLine(MyObj.ToString());


            IMiInterfaz prueba1 = new ClaseUno();
            IMiInterfaz prueba2 = new ClaseDos();
            IMiInterfaz prueba3 = new ClaseTres();
            IMiNuevaInterfaz prueba4 = new ClaseTres();

            ClaseUno miClase = new ClaseUno();
            ClaseDos miClase2 = new ClaseDos();
            IMiInterfaz miInterfaz;
            miInterfaz = miClase;
            Console.WriteLine("Llamado por polimorfismo de interfaces: ");
            miInterfaz.ImprimeMensaje();
            miInterfaz = miClase2;
            miInterfaz.ImprimeMensaje();
            Console.WriteLine();





            prueba4.NuevaImpresion();

            

            ClaseUno cu = new ClaseUno();
            cu.ImprimeMensaje();
            MiMetodo(cu);

            ClaseDos cd = new ClaseDos();
            cd.ImprimeMensaje();
            MiMetodo(cd);


            Program pr = new Program();

            IInterface1 i1 = pr;
            IInterface2 i2 = pr;

            Console.WriteLine("Implementación explícita:");
            i1.Imprimir();
            i2.Imprimir();



            Console.ReadLine();
        }
        private static void MiMetodo(IMiInterfaz m)
        {
            Console.WriteLine("Llamada dentro de método");
            m.ImprimeMensaje();
        }

        void IInterface1.Imprimir()
        {
            Console.WriteLine("IInterface1 explícitamente implementada");
        }

        void IInterface2.Imprimir()
        {
            Console.WriteLine("IInterface2 explícitamente implementada");
        }

        
    }
}
