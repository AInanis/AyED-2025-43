using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nina_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ancho, Altura;
            Console.WriteLine("Dime el ancho del rectangulo");
            Ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dime la altura del rectangulo");
            Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El area es " + (Altura * Ancho));
            Console.WriteLine("El Perimetro es " + ((Altura*2 + (Ancho*2))));
            Console.WriteLine("El area es " + (Math.Sqrt( Math.Pow(Ancho,2) + Math.Pow(Altura,2))));
            Console.ReadKey();
        }
    }
}
