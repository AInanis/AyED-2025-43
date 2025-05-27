using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            
 
            Console.WriteLine("----Menu-----");
            Console.WriteLine("1.Saludar");
            Console.WriteLine("2.sumar 2 numeros ");
            Console.WriteLine("3.division de 2 numeros");
            Console.WriteLine("4.Salir");
            do
            {
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("bienvenido al progama");
                        break;
                    case 2:
                        Console.WriteLine("Decime un numero  ");
                        int num1;
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Decime un numero  ");
                        int num2;
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma es " + (num1 + num2));
                        break;
                    case 3:
                        Console.WriteLine("Decime un numero  ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Decime un numero  ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division es " + (num1 / num2));
                        break;
                    case 4:
                        Console.WriteLine("Chau Chavalin");
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            }
            while (opc != 4);
                     
            }
    }
}
