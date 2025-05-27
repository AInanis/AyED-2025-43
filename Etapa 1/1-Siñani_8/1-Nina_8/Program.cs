using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime tu edad");
            int edad, Año;
            Año = 2025;
            edad = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; edad > 0; i++)
            {
                Console.WriteLine("Tu en " + Año + " tenias " + edad);
                Año = Año - 1;
                edad = edad - 1;

            }
            Console.ReadKey();
        }
    }
}
