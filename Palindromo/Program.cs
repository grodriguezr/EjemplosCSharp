using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba la frase");
            string frasePalindromo = Console.ReadLine();
            string auxiliar = "";
            for (int i = 0; i < frasePalindromo.Length; i++)
            {
                if(frasePalindromo[i] != ' ')
                {
                    auxiliar += frasePalindromo[i];
                }
            }
            int tamano = auxiliar.Length % 2 == 0 ? auxiliar.Length / 2 : 
                (auxiliar.Length - 1) / 2;
            int flag = 0;
            for(int i = 0; i < tamano; i++)
            {
                if(auxiliar[i] != auxiliar[auxiliar.Length - 1 - i])
                {
                    flag = 1;
                    break;
                }
            }
            Console.WriteLine($"La frase {(flag == 1 ? "no" : "")} es palindromo");
            Console.ReadLine();
        }
    }
}