using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grado;
            Console.WriteLine("decime un grado en celsius");
            grado = Convert.ToInt32(Console.ReadLine());
            if (grado <= 0)
            {
                Console.WriteLine("Se va a congelar");
            }
            else if (grado >= 100)
            {
                Console.WriteLine("se va a hervir");
            }
              else
            {
                Console.WriteLine("Esta en estado liquido ");
            }
              
            Console.ReadKey();


        }
    }
}
