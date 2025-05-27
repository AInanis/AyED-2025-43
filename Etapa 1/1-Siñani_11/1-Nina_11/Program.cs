
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Decime un numero N");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; num > 1; i++)
            {
                num = num - 1;
                if (num % 2 == 0)
                    Console.WriteLine(num);

            }
                
            Console.ReadKey();       
      }
    }
}
