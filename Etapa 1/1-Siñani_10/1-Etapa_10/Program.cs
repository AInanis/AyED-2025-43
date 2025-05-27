using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Etapa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = 101;
            for (int I = 0; num > 0; I++ )
            {
                num = num - 1;
                Console.WriteLine("El numero es " + num);
                if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (num % 5 == 0)
                    Console.WriteLine("Buzz");
                if (num % 3 == 0 && num % 5 == 0)
                    Console.WriteLine("FiZZBuzz");
            }

            Console.ReadKey();
        }
    }
}
