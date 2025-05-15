using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, resultado;
            Console.WriteLine("Decime un numero ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Decime otro numero ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error,No se puede dividir entre cero");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es: " + resultado);
            }
            Console.ReadKey();


        }
    }
}
