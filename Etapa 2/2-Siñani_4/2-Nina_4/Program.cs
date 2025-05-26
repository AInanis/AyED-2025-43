using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Nina_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            Console.WriteLine("¿Cuantos productos fueron vendidos en el HotSale?");
            cantidad = int.Parse(Console.ReadLine());

            int[] precios = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Cual es el precio del producto " + (i + 1));
                precios[i] = int.Parse(Console.ReadLine());

            }
            int May = precios [0], Men = precios [0];
            for (int i = 0; i < cantidad - 1; i++)
            {
                    if ( May < precios[i])
                    {
                        May = precios[i];
                        
                    }
                    if (Men > precios[i])
                    {
                        Men = precios[i];

                    }
                
            }

            Console.WriteLine("El precio mas bajo es " + Men);
            Console.WriteLine("El precio Mas alto es " + May);

            Console.ReadKey();
        }
    }
}
