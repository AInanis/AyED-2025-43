using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Dime un numero");
            Num = Convert.ToInt32(Console.ReadLine());

            for (int I = 0; Num > -1; I++ )
            {
                Console.WriteLine("Tu numero es " + Num);
                Num = Num - 1;
            }
            Console.ReadKey();
        }
    }
}
