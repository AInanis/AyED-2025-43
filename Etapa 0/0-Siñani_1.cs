using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.WriteLine("Como te llamas");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola " + nombre + " tu edad es " + edad);

            Console.ReadKey();
        }
    }
}
