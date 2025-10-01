using System;

class Program
{
    static void Main()
    {
        string[,] pochimons = new string[75, 5];
        int cantidadRegistrados = 0;
        Random rand = new Random();
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Pochimones Encontrados: {cantidadRegistrados}/75\n");

            Console.WriteLine("1. Registrar Pochimon");
            Console.WriteLine("2. Asignar Investigador a Pochimon");
            Console.WriteLine("3. Actualizar Nivel de Pochimon");
            Console.WriteLine("4. Marcar Pochimon como Investigado");
            Console.WriteLine("5. Mostrar Información de Pochimons");
            Console.WriteLine("6. Buscar Pochimons por Tipo");
            Console.WriteLine("7. Mostrar Pochimons por Investigador");
            Console.WriteLine("8. Mostrar Pochimons Picados");
            Console.WriteLine("9. Salir");
            Console.Write("Ingrese la opción deseada: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidadRegistrados < 75)
                    {
                        Console.Write("Ingrese el nombre del Pochimon: ");
                        pochimons[cantidadRegistrados, 0] = Console.ReadLine();

                        Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                        pochimons[cantidadRegistrados, 1] = Console.ReadLine().ToUpper();

                        Console.Write("Ingrese el nivel del Pochimon: ");
                        pochimons[cantidadRegistrados, 2] = Console.ReadLine();

                        pochimons[cantidadRegistrados, 3] = "0";
                        pochimons[cantidadRegistrados, 4] = "0";

                        cantidadRegistrados++;
                        Console.WriteLine("Pochimon registrado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("La Pochidex está llena.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Pochimons no investigados:");
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        if (pochimons[i, 3] == "0")
                        {
                            Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} |");
                        }
                    }
                    Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
                    int filaAsignar = int.Parse(Console.ReadLine()) - 1;
                    if (filaAsignar >= 0 && filaAsignar < cantidadRegistrados && pochimons[filaAsignar, 3] == "0")
                    {
                        Console.Write("Ingrese el código del Investigador: ");
                        pochimons[filaAsignar, 4] = Console.ReadLine();
                        pochimons[filaAsignar, 3] = "1";
                        Console.WriteLine("Investigador asignado.");
                    }
                    else
                    {
                        Console.WriteLine("Fila inválida o Pochimon ya investigado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Pochimons registrados:");
                    Console.WriteLine("| Fila | Nombre     | Nivel |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 2],5} |");
                    }
                    Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
                    int filaActualizar = int.Parse(Console.ReadLine()) - 1;
                    if (filaActualizar >= 0 && filaActualizar < cantidadRegistrados)
                    {
                        int incremento = rand.Next(1, 4);
                        int nivelActual = int.Parse(pochimons[filaActualizar, 2]);
                        pochimons[filaActualizar, 2] = (nivelActual + incremento).ToString();
                        Console.WriteLine($"Nivel actualizado. (+{incremento})");
                    }
                    else
                    {
                        Console.WriteLine("Fila inválida.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Pochimons en investigación:");
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        if (pochimons[i, 3] == "1")
                        {
                            Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} | {pochimons[i, 3],6} | {pochimons[i, 4],12} |");
                        }
                    }
                    Console.Write("Ingrese el número de fila del Pochimon a marcar como investigado: ");
                    int filaMarcar = int.Parse(Console.ReadLine()) - 1;
                    if (filaMarcar >= 0 && filaMarcar < cantidadRegistrados && pochimons[filaMarcar, 3] == "1")
                    {
                        pochimons[filaMarcar, 3] = "2";
                        Console.WriteLine("Pochimon marcado como investigado.");
                    }
                    else
                    {
                        Console.WriteLine("Fila inválida o estado incorrecto.");
                    }
                    break;

                case 5:
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel | Estado | Investigador Asignado |");
                    Console.WriteLine("|------|------------|-------|-------|--------|------------------------|");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} | {pochimons[i, 3],6} | {pochimons[i, 4],22} |");
                    }
                    break;

                case 6:
                    Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                    string tipoBuscar = Console.ReadLine().ToUpper();
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        if (pochimons[i, 1] == tipoBuscar)
                        {
                            Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} |");
                        }
                    }
                    break;

                case 7:
                    Console.Write("Ingrese el código del Investigador: ");
                    string codBuscado = Console.ReadLine();
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        if (pochimons[i, 4] == codBuscado)
                        {
                            Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} |");
                        }
                    }
                    break;

                case 8:
                    Console.WriteLine("Pochimons Picados:");
                    Console.WriteLine("| Fila | Nombre     | Tipo  | Nivel |");
                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        if (int.Parse(pochimons[i, 2]) > 30)
                        {
                            Console.WriteLine($"| {i + 1,4} | {pochimons[i, 0],-10} | {pochimons[i, 1],-5} | {pochimons[i, 2],5} |");
                        }
                    }
                    break;
            }

            if (opcion != 9)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 9);
    }
}
