using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsLower(c))
            {
               if (result[i] = (c == 'z'))
                    result[i] = 'a'; 
                    (char)(c + 1);
            }
            else if (char.IsUpper(c))
            {
              if ( result[i] = (c == 'Z'))
                    result[i] = 'A';
                    (char)(c + 1);
            }
            else
            {
                result[i] = c;
            }
        }
        // TODO: implementar
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        return new string(result);
    }
}