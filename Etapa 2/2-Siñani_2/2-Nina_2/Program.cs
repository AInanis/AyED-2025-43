using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Siñani_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int canttps, cantexam;
            Console.WriteLine("Decime la cantidad de los TPS que tuviste");
            canttps = int.Parse(Console.ReadLine());
            Console.WriteLine("Decime la cantidad de los Examenes que tuviste");
            cantexam = int.Parse(Console.ReadLine());
            int[] notasexam = new int[cantexam];
            int[] notastps = new int[canttps];
            for (int i = 0; i < canttps; i++)
            {
                Console.WriteLine("Decime las notas de los tps que tuviste");
                notastps[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < cantexam; i++)
            {
                Console.WriteLine("Decime las notas de los examenes que tuviste");
                notasexam[i] = int.Parse(Console.ReadLine());
            }
            int tpsAprobados = 0;
            for (int i = 0; i < canttps; i++)
            {
                if (notastps[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            double porcentajetpsapr = (double)tpsAprobados / canttps * 100;
            int sumaExamenes = 0;
            for (int i = 0; i < cantexam; i++)
            {
                sumaExamenes += notasexam[i];
            }

            double promedioexam = (double)sumaExamenes / cantexam;
            if (promedioexam >= 6 && porcentajetpsapr >= 75)
            {
                Console.WriteLine("Phineas y Ferb pueden aprobar la materia");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb NO pueden aprobar la materia");
            }

            Console.ReadKey();
        }
    }
}


