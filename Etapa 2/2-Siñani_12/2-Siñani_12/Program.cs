using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Siñani_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;

            Console.Write("Ingrese el tamaño de la matriz (n): ");
            n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = rnd.Next(1, 100);
                }
            }

            Console.WriteLine("\nMatriz generada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nDiagonal principal (como matriz):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(matriz[i, j].ToString("D2") + " ");
                    else
                        Console.Write("   "); 
                }
                Console.WriteLine();
            }
        }
    }
}
