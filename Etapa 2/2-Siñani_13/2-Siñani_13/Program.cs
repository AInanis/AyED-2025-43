using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Siñani_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes (N): ");
            int n = int.Parse(Console.ReadLine());
            string[,] estudiantes = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEstudiante " + " " + (i + 1));
                Console.Write("Nombre: ");
                estudiantes[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i, 1] = Console.ReadLine();

                Console.Write("Calificación: ");
                estudiantes[i, 2] = Console.ReadLine();
            }

            
            Console.WriteLine("Listado de estudiantes:");
            Console.WriteLine("Nombre\tEdad\tCalificación");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");
                Console.WriteLine($"  Nombre: {estudiantes[i, 0]}");
                Console.WriteLine($"  Edad: {estudiantes[i, 1]}");
                Console.WriteLine($"  Calificación: {estudiantes[i, 2]}\n");
            }
            Console.ReadKey();
        }
    }
}
  