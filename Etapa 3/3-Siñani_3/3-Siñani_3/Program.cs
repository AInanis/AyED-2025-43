using System;

namespace CodigoBonito2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] datos = new int[25, 5];
            int cantencargos = 0;
            int opc;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opción deseada: ");
                Console.WriteLine("1. Registrar encargo");
                Console.WriteLine("2. Imprimir encargos");
                Console.WriteLine("3. Imprimir encargos asignados (con camión)");
                Console.WriteLine("4. Imprimir encargos no asignados");
                Console.WriteLine("5. Promedio de ganancia por sede");
                Console.WriteLine("6. Encargo de mayor distancia");
                Console.WriteLine("7. Mostrar códigos de camiones");
                Console.WriteLine("8. Salir");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: cantencargos = Registrar(cantencargos, datos); break;
                    case 2: Imprimir(cantencargos, datos); break;
                    case 3: ImprimirAsig(cantencargos, datos); break;
                    case 4: ImprimirNoAsig(cantencargos, datos); break;
                    case 5: Promediosede(cantencargos, datos); break;
                    case 6: Mayordistancia(cantencargos, datos); break;
                    case 7: MostrarCod(cantencargos, datos); break;
                    case 8: Console.WriteLine("Cerrando programa..."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                if (opc != 8)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opc != 8);
        }

        static int Registrar(int cantencargos, int[,] datos)
        {
            if (cantencargos >= 25)
            {
                Console.WriteLine("No hay más espacio para encargos.");
                return cantencargos;
            }

            int distancia;
            do
            {
                Console.Write("Ingrese la distancia (km): ");
                distancia = int.Parse(Console.ReadLine());

                if (distancia <= 0)
                    Console.WriteLine("Distancia inválida, intente nuevamente.");
            }
            while (distancia <= 0);

            Console.Write("Ingrese la ganancia: ");
            int ganancia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la sede (1=BSAS, 2=BB, 3=MDQ): ");
            int sede = int.Parse(Console.ReadLine());

            datos[cantencargos, 0] = 0;
            datos[cantencargos, 1] = distancia;
            datos[cantencargos, 2] = sede;
            datos[cantencargos, 3] = ganancia;
            datos[cantencargos, 4] = 0;

            cantencargos++;
            return cantencargos;
        }

        static void Imprimir(int cantencargos, int[,] datos)
        {
            Console.WriteLine("Mostrando todos los encargos:");
            for (int i = 0; i < cantencargos; i++)
            {
                Console.WriteLine($"{i + 1}. Distancia: {datos[i, 1]} km | Ganancia: ${datos[i, 3]} | " +
                                  $"Sede: {(datos[i, 2] == 1 ? "BSAS" : datos[i, 2] == 2 ? "BB" : "MDQ")} | " +
                                  $"Camión: {(datos[i, 0] == 0 ? "Sin asignar" : datos[i, 0].ToString())}");
            }
        }

        static void ImprimirAsig(int cantencargos, int[,] datos)
        {
            Console.WriteLine("Encargos asignados a camión:");
            for (int i = 0; i < cantencargos; i++)
            {
                if (datos[i, 4] == 1)
                    Console.WriteLine($"Encargo {i + 1}: Camión {datos[i, 0]}, Distancia {datos[i, 1]} km");
            }
        }

        static void ImprimirNoAsig(int cantencargos, int[,] datos)
        {
            Console.WriteLine("Encargos no asignados:");
            for (int i = 0; i < cantencargos; i++)
            {
                if (datos[i, 4] == 0)
                    Console.WriteLine($"Encargo {i + 1}: Distancia {datos[i, 1]} km, Ganancia ${datos[i, 3]}");
            }
        }

        static void Promediosede(int cantencargos, int[,] datos)
        {
            double[] suma = new double[4];
            int[] cuenta = new int[4];

            for (int i = 0; i < cantencargos; i++)
            {
                int sede = datos[i, 2];
                suma[sede] += datos[i, 3];
                cuenta[sede]++;
            }

            Console.WriteLine("Promedio de ganancia por sede:");
            for (int s = 1; s <= 3; s++)
            {
                if (cuenta[s] > 0)
                    Console.WriteLine($"{(s == 1 ? "BSAS" : s == 2 ? "BB" : "MDQ")}: ${suma[s] / cuenta[s]:F2}");
                else
                    Console.WriteLine($"{(s == 1 ? "BSAS" : s == 2 ? "BB" : "MDQ")}: sin datos");
            }
        }

        static void Mayordistancia(int cantencargos, int[,] datos)
        {
            if (cantencargos == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
                return;
            }

            int maxDist = datos[0, 1];
            int idx = 0;

            for (int i = 1; i < cantencargos; i++)
            {
                if (datos[i, 1] > maxDist)
                {
                    maxDist = datos[i, 1];
                    idx = i;
                }
            }

            Console.WriteLine($"El encargo con mayor distancia es el {idx + 1}: {maxDist} km, Ganancia ${datos[idx, 3]}");
        }

        static void MostrarCod(int cantencargos, int[,] datos)
        {
            Console.WriteLine("Códigos de camiones asignados:");
            for (int i = 0; i < cantencargos; i++)
            {
                Console.WriteLine($"Encargo {i + 1}: {(datos[i, 0] == 0 ? "Sin asignar" : "Camión " + datos[i, 0])}");
            }
        }
    }
}
