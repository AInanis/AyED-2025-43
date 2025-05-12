using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con
{
    class Program
    {
        static void Main(string[] args)
        {

            int num,num1;

            Console.WriteLine("Decime un numero ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decime un numero ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La resta de los 2 numeros es " + (num - num1));


            Console.ReadKey();
        }
    }
}
