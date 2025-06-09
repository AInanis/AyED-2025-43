using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidatos, multi;

            Console.WriteLine("Ingrese la cantidad de candidatos a dar el examen");
            candidatos = int.Parse(Console.ReadLine());

            int[] puntajes = new int[candidatos];

            for (int i = 0; i < candidatos; i++)
            {
                Console.WriteLine("Cual es el puntaje del candidato " + (i + 1));
                puntajes[i] = int.Parse(Console.ReadLine());
            }
            int t;
            for (int i = 0; i < candidatos; i++)
            {
                for (int j = 0; j < candidatos - i - 1; j++)
                {
                    if (puntajes[j + 1] < puntajes[j])
                    {
                        t = puntajes[j + 1];
                        puntajes[j + 1] = puntajes[j];
                        puntajes[j] = t;
                    }
                }
            }

            Console.WriteLine("Ingrese un numero entero");
            multi = int.Parse(Console.ReadLine());


            for ( int i = 0;i < candidatos;i++)
            {
                Console.WriteLine("El puntajes es " + puntajes[i]);
                if (puntajes[i] % multi == 0)
                {
                    Console.WriteLine("El valor " + puntajes[i] + " Es multiplo de " + multi);
                }
            }
            Console.ReadKey();
        }
    }
}
