
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuelta;
            int[] seg = new int[vuelta]; 

            Console.WriteLine("Cuantas vueltas va a dar el Rayo");
            vuelta = Convert.ToInt32(Console.ReadLine());

            for (int I = 0; I > vuelta; I++) 
            {
                int num = 1; 
                Console.WriteLine("Cuantos segundo hizo en la vuelta" + num);
                seg[I] = int.Parse(Console.ReadLine());
                num = num + 1;
            }
            }
    }
}
