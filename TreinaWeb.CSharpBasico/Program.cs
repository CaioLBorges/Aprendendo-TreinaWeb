using System;

namespace TreinaWeb.CSharpBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Caio";
            dynamic idade = 2;
            Console.WriteLine("idade = {0}", idade);
            idade = "caio";
            Console.WriteLine("idade = {0}", idade);
            Console.WriteLine("Seu nome é {0}", nome);
            string s = "ab\\nbc";
            Console.WriteLine(s);


        }
    }
}
