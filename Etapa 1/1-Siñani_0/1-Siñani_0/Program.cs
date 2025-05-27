using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Siñani_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Cuantos años tienes?");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
            Console.ReadKey();
        }


    }
}
