using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ClaseBasica
    {
        public int i = 0;
       
    }
    public struct Punto
    {
        public int x, y;
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
        }

    }

    public class Punto2
    {
        public int x, y;
        public Punto2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Program pr = new Program();
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            object Objeto = new ClaseBasica();
            ClaseBasica a;
            a = (ClaseBasica)Objeto;
            Console.WriteLine(a.i);
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);

            //var watch2 = System.Diagnostics.Stopwatch.StartNew();
            ClaseBasica b = new ClaseBasica();
            Console.WriteLine(b.i);
            //Console.WriteLine(watch2.Elapsed);
            Punto punto = new Punto(5, 3);
            pr.SumaCoordenadas(punto, 5);//esto se pierde ya que no se referencia a los valores reales de losobjetos sino a unas copias

            Punto2 punto2 = new Punto2(5, 3);
            pr.SumaCoordenadas(punto2, 5);//se modifica el valor real del objeto



            Console.WriteLine("Struct: " + punto);//tipos por valor
            Console.WriteLine("Clase: " + punto2);//tipos por referencia

            //Console.ReadKey();
            Console.ReadLine();

        }
        public void SumaCoordenadas(Punto p, int incremento)
        {
            p.x += incremento;
            p.y += incremento;
        }
        public void SumaCoordenadas(Punto2 p, int incremento)
        {
            p.x += incremento;
            p.y += incremento;
        }
    }
}
