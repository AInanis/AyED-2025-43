using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();
            int opc;

            do
            {
                int probabilidad = rand.Next(1, 101);
                Console.WriteLine("Día " + dia + "– ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.WriteLine("Elija una opción:");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            if (probabilidad <= 30)
                            {
                                salud = salud - 15;
                                Console.WriteLine("Comiste algo en mal estado.Salud - 15.");
                            }
                            else
                            {
                                hambre = hambre + 20;
                                energia = energia - 15;
                            }
                        }
                        break;
                    case 2:
                        {
                            energia = energia + 30;
                            hambre = hambre - 10;

                        }
                        break;
                    case 3:
                        {
                            energia = energia - 20;
                            hambre = hambre - 15;
                            if (probabilidad >= 50)
                            {
                                Console.WriteLine("¡Encontraste una planta curativa! Salud + 10.");
                                salud = salud + 10;
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Tu salud es de " + salud);
                            Console.WriteLine("Tu hambre es de " + hambre);
                            Console.WriteLine("Tu energia es de " + energia);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Juego finalizado");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                    sigueVivo = false;
                }
                dia = dia + 1;
            }
            while (opc != 5);

            Console.ReadKey();
        }
    }
}
