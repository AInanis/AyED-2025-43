using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, Valor;

            Console.WriteLine("Ingrese la cantidad de objetos");
            cantidad = int.Parse(Console.ReadLine());
            int[] objetos = new int[cantidad];
            Console.WriteLine("Ingrese el valor minimo requerido");
            Valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el valor del objeto " + (i + 1));
                objetos[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < cantidad; i++)
            {
                if (objetos[i] > Valor)
                {
                    Console.WriteLine("Posicion " + i + " " + objetos[i]);
                }
                

            }
            Console.ReadKey();

        }
    }
}
