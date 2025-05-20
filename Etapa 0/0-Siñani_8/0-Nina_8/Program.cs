using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nina_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("decime un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("decime un numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El Resto de los 2 numeros es " + (num1 % num2));

            Console.ReadKey();
        }
    }
}
