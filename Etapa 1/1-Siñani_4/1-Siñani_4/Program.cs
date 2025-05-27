using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Siñani_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;
            Console.WriteLine("¿Que edad tenes?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuantos ingresos tienes mensualmente?");
            ingresos = Convert.ToInt32(Console.ReadLine());

            if (edad > 19 && ingresos <= 100000)
                Console.WriteLine("Obtuviste la Beca Chaval");
            else if (edad < 19 && ingresos == 0)
            {
                Console.WriteLine("Obtuviste la beca Chaval");
            }
            else if (edad == 19 && ingresos <= 50000)
                Console.WriteLine("Obtuviste la beca Chaval");
            else
                Console.WriteLine("No obtuviste la beca Chavalin");


            Console.ReadKey();
        }
    }
}
