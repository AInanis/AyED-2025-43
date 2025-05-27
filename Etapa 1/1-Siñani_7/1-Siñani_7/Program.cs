using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Siñani_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pala;
            int num;
            num = 0;
            Console.WriteLine("Decime una palabra");
            pala = Console.ReadLine();
            while (num != 10)
            {
                num = num + 1;
                Console.WriteLine(pala);
            }


            Console.ReadKey();

        }
    }
}
