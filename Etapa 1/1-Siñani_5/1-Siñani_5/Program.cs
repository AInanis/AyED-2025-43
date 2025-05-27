using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Siñani_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string comi, refugio, bate;
            Console.WriteLine("¿Tienes comida?");
            comi = (Console.ReadLine().ToUpper());
            Console.WriteLine("¿Tienes un refugio?");
            refugio = (Console.ReadLine().ToUpper());
            Console.WriteLine("¿Tienes un bate?");
            bate = (Console.ReadLine().ToUpper());

            if (comi == "SI" && refugio == "SI" && bate == "SI")
                Console.WriteLine("Tu vas a sobrevivir");
            else
                Console.WriteLine("Tu no vas a lograr sobrevivir");

            Console.ReadKey();
        }
    }
}
