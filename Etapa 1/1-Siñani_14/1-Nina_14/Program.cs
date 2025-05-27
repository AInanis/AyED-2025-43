using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Nina_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Brajan";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;
            int opc;

            do
            {
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada mágica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar poción de vida(vale 20 monedas)");
                Console.WriteLine("5. Salir del juego");
                Console.WriteLine("Seleccione una opción:");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine("Hola Brajan tu salud es de " + salud);
                            Console.WriteLine("Tus monedas son " + monedas);
                            Console.WriteLine("Los enemigos derrotados son " + enemigosDerrotados);
                            if (tieneEspada == false)
                                Console.WriteLine("Y tu no tienes la espada");
                            else
                                Console.WriteLine("Tu tienes la espada");
                        }
                        break;
                    case 2:
                        {
                            if (tieneEspada == false)
                            {
                                Console.WriteLine("¡Encontraste la espada mágica!");
                                tieneEspada = true;
                            }
                            else
                                Console.WriteLine("Ya tenés la espada mágica.");

                        }
                        break;
                    case 3:
                        {
                            if (tieneEspada == false)
                            {
                                Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30.");
                                salud = salud - 30;
                            } 
                            else
                                Console.WriteLine("¡Ganaste la batalla! Salud -10.");
                            salud = salud - 10;
                            enemigosDerrotados = enemigosDerrotados + 1;
                        }
                        break;
                    case 4:
                        {
                            if (monedas >= 20)
                            {
                                monedas = monedas - 20;
                                salud = salud + 20;
                                Console.WriteLine("Usaste una poción. +20 de salud.");
                            }
                            else
                            {
                                Console.WriteLine("No tenés suficientes monedas.");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("¡Gracias por jugar!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }


            }
            while (opc != 5);

            Console.ReadKey();
        
    }
        }
}
