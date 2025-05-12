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

            int num;
            Console.WriteLine("Decime un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 && num != 0)
            {
                Console.WriteLine("El numero " + num + " es par");
            }
            else if (num % 2 == 1 && num != 0)
            {
                Console.WriteLine("El numero " + num + " es impar");
            }
            else
            {
                Console.WriteLine("tu numero 0,es par");
            }
                Console.ReadKey();


        }
    }
}
