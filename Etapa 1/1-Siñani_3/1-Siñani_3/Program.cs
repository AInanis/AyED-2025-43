using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Siñani_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Decime un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("este numero es par");
            }
            else if (num == 0)
            {
                Console.WriteLine("El numero 0 es par");
            }
            else

            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
