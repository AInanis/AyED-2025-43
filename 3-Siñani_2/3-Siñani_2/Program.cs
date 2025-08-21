using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Siñani_2
{
    class Program
    {
    
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("bro,no se puede dividr por cero :v");
                return 0;
            }
            return (double)a / b;
        }

        static void Calculadora()
        {
            Console.WriteLine("Ingrese un número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Elija una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Sumar(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Restar(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Resultado: " + Dividir(num1, num2));
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Calculadora();
        }
    }
}