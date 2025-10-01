using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Torrez_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("introdusca un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El total de la resta de esos dos numeros es: " + (num1 - num2));
            Console.ReadKey();
        }
    }
}
