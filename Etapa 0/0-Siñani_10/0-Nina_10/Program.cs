using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nina_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int grado;

            Console.WriteLine("decime el grado centigrado");
            grado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("este grado celsius en kelvin seria " + (273 + grado));
            Console.WriteLine("este grado celsius en fahrenheit seria " + ((grado * 1.8) + 32));



            Console.ReadKey();
        }
    }
}
