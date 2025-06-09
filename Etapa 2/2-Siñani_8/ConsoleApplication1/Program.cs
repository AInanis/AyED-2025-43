using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila, colum;

            Console.WriteLine("Decime la cantidad de filas");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Decime la cantidad de columnas");
            colum = int.Parse(Console.ReadLine());
            int[,] Matriz = new int[fila, colum];
            for( int i = 0;i < fila;i++)
            {
                for  (int j = 0;i < colum;j++)
                {
                    Console.WriteLine(Matriz[i,j]+ " ");
                } 
            }
            Console.ReadKey();
        }
    }
}
