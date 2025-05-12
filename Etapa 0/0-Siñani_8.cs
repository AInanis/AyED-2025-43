using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con
{
    class Program
    {
        static void Main(string[] args)
        {

            int radio;
         
            Console.WriteLine("decime el radio de la esfera");
            radio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("la superficie/volumen es " + (4/3*Math.PI*Math.Pow(radio,2)));



            Console.ReadKey();
        }
    }
}
