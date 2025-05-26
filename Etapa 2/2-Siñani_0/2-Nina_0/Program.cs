using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int invitados, prome = 0 ;
            Console.WriteLine("Cuantos invitados hay");
            invitados = Convert.ToInt32(Console.ReadLine());
            int[] comi = new int[invitados];

            for (int i = 0; i < invitados; i++)
            {
                Console.WriteLine("¿Cuanta comida va a comer el invitado ");
                comi[i] = int.Parse(Console.ReadLine());
                prome = prome + comi[i];
            }

            Console.WriteLine("El promedio de comida por invitado es " +(prome / invitados ));
            Console.ReadKey();

        }
    }
}
