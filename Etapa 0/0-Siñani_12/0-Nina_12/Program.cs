using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Decime 3 letras");
            letra = Console.ReadLine();
            Console.WriteLine("El orden invertido es " + letra[2] + letra[1] + letra[0]);
            Console.ReadKey();
        }
    }
}
