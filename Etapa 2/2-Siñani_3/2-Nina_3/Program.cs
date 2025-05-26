using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int participantes;
            Console.WriteLine("¿Cuantos participantes hay?");
            participantes = int.Parse(Console.ReadLine());

            int [] puntaje = new int[participantes];
            for (int i = 0; i < participantes; i++)
            {
                Console.WriteLine("Que puntaje tiene el jugador " + (i + 1));
                puntaje[i] = int.Parse(Console.ReadLine());
                 
            }
            int t;
            for (int i = 0; i < participantes - 1; i++)
            {
                for (int j = 0 ; j < participantes - i - 1; j++)
                {
                    if (puntaje[j + 1] > puntaje[j])
                    {
                        t = puntaje[j + 1];
                        puntaje[j + 1] = puntaje[j];
                        puntaje[j] = t;
                    }
                }
            }
            Console.WriteLine("Ordenados :");
            for (int f = 0;f < participantes;f++)
            {
                Console.WriteLine("Los puntajes son " + puntaje[f] );
            }
            Console.ReadKey();
        }
    }
}
