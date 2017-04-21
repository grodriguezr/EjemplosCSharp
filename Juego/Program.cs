using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba la cantidad de jugadores: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            string[] jugadores = new string[cantidad];
            for (int h = 0; h < cantidad; h++)
            {
                Console.WriteLine($"Escriba el nombre del jugador {h + 1}");
                jugadores[h] = Console.ReadLine();
            }
            Console.WriteLine("Los Jugadores son: ");
            for (int h = 0; h < jugadores.Length; h++)
            {
                Console.WriteLine(jugadores[h]);
            }

            Console.WriteLine("Escriba la cantidad de saltos: ");
            int saltos = Convert.ToInt32(Console.ReadLine());

            Jugar(jugadores, saltos);


            

            //Console.Clear();



            //Console.WriteLine("Numeros:");
            //ArregloString();
            Console.ReadLine();


        }
        private static string[] EliminaJugadores(string[] jugadores)
        {
            return jugadores;
        }

        private static void Jugar(string[] jugadores, int saltos)
        {
            int veces = jugadores.Length;
            int i = 1;
            while(i < jugadores.Length)
            {
                int j = 0;
                while (j < saltos)
                {
                    if(j == (saltos - 1))
                    {
                        jugadores[j] = null;
                    }else if(jugadores[j] == null)
                    {
                        if(j == (jugadores.Length - 1))
                        {

                        }
                    }
                }


                i++;
            }

            for (int s = 0; s < jugadores.Length; s++)
            {
                Console.WriteLine(jugadores[s]);
            }
        }









        


        private static void ArregloString()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 1, j=0;
            
            while(i <= 10)
            {
                if (numeros[j] == 0)
                {
                    if (j == numeros.Length - 1)
                    {
                        j = 0;
                        continue;
                    }
                    else
                    {
                        j++;
                        continue;
                    }
                }
                else if (j == numeros.Length - 1)
                {
                    Console.WriteLine("Final del array: " + numeros[j]);
                    j = 0;
                }
                else
                {
                    Console.WriteLine("Normal: " + numeros[j]);
                    j++;
                }

                i++;
            }
                

        }

    }
}
