using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string contraseñaU;
            string contraseñaGuardada = "PROGRAMACION";
            Console.Write("Introduce la contraseña: ");
            contraseñaU = (Console.ReadLine().Toupper);
            if (contraseñaU == contraseñaGuardada)
            {
                Console.WriteLine("Exacto!,la contraseña es" + contraseñaU);
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta..");
            }
            Console.ReadKey();


        }
    }
}
