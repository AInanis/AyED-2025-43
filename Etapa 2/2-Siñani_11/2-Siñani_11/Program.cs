using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Siñani_11
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] original = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

                int[,] rotada = new int[3, 3];

                // Usamos for, pero el tamaño 3 está codificado directamente
                for (int i = 0; i < 3; i++) // filas
                {
                    for (int j = 0; j < 3; j++) // columnas
                    {
                        rotada[j, 2 - i] = original[i, j];
                    }
                }

                // Imprimir original
                Console.WriteLine("Matriz original:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(original[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                // Imprimir rotada
                Console.WriteLine("Matriz rotada 90° en sentido horario:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(rotada[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
}
