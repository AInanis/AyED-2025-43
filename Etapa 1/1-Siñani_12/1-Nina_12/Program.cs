using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            Console.WriteLine("Diga que SI para salir del programa");
            do
            {
                Console.WriteLine("¿Desea salir del programa?");
                res = Console.ReadLine();

            }
            while (res != "SI");

            Console.ReadKey();
        }
    }
}
