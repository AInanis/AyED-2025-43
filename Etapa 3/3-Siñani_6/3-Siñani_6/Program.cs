
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
        // 1) Generar mano aleatoria
        string[] mano = GenerarManoAleatoria();
        // 2) Determinar tipo de mano
        string tipo = TipoDeMano(mano);
        // 3) Calcular puntaje base
        int basePts = PuntajeBase(mano);
        // 4) Obtener multiplicador
        double mult = Multiplicador(tipo);
        // 5) Calcular puntaje final
        double total = basePts * mult;
        // 6) Aplicar jokers
        bool jokerX2 = true;
        bool jokerMas10 = true;
        total = AplicarJokers(total, jokerX2, jokerMas10);
        // 7) Mostrar resumen final
        MostrarResumen(mano, tipo, basePts, mult, total);
    }
    static string[] GenerarManoAleatoria()
    {
        string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] palos = { "H", "D", "C", "S" };

        Random rnd = new Random();
        string[] mano = new string[5];

        for (int i = 0; i < 5; i++)
        {
            string rango = rangos[rnd.Next(rangos.Length)];
            string palo = palos[rnd.Next(palos.Length)];
            mano[i] = rango + palo;
        }

        return mano;
    }
    static string TipoDeMano(string[] mano)
    {
        string[] rangos = new string[mano.Length];
        for (int i = 0; i < mano.Length; i++)
        {
            rangos[i] = mano[i][0].ToString();
        }

        int[] conteos = new int[rangos.Length];
        for (int i = 0; i < rangos.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < rangos.Length; j++)
            {
                if (rangos[i] == rangos[j]) count++;
            }
            conteos[i] = count;
        }

        bool hay4 = false, hay3 = false, hay2 = false;
        for (int i = 0; i < conteos.Length; i++)
        {
            if (conteos[i] == 4) hay4 = true;
            if (conteos[i] == 3) hay3 = true;
            if (conteos[i] == 2) hay2 = true;
        }

        if (hay4) return "Poker";
        if (hay3 && hay2) return "Full";
        if (hay3) return "Trio";
        if (hay2) return "Par";
        return "Nada";
    }
    static int PuntajeBase(string[] mano)
    {
        int total = 0;

        for (int i = 0; i < mano.Length; i++)
        {
            char r = mano[i][0];
            int valor = 0;

            if (r == 'A') valor = 14;
            else if (r == 'K') valor = 13;
            else if (r == 'Q') valor = 12;
            else if (r == 'J') valor = 11;
            else if (r == 'T') valor = 10;
            else valor = int.Parse(r.ToString());

            total += valor;
        }

        return total;
    }
    static double Multiplicador(string tipo)
    {
        if (tipo == "Par") return 1.5;
        else if (tipo == "Trio") return 2.5;
        else if (tipo == "Full") return 3.5;
        else if (tipo == "Poker") return 4.0;
        else return 1.0;
    }
    static double AplicarJokers(double puntaje, bool x2, bool mas10)
    {
        if (x2) puntaje = puntaje * 2;
        if (mas10) puntaje = puntaje + 10;
        return puntaje;
    }
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.Write("Mano: ");
        for (int i = 0; i < mano.Length; i++)
        {
            Console.Write(mano[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Puntaje base: " + basePts);
        Console.WriteLine("Multiplicador: x" + mult);
        Console.WriteLine("Total (con Jokers): " + total);
        // ⚠️ Todas las funciones que se llaman en el Main
        // deben ser creadas acá abajo por ustedes.
        Console.ReadKey();
    }
}