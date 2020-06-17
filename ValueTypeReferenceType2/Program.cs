using System;

namespace ValueTypeReferenceType2
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            /*int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;
            Console.WriteLine("numero1 = {0}, numero2 = {1}", numero1, numero2);
            */
            //reference type
            Teste numero1 = new Teste();
            numero1.valor = 3;
            Teste numero2 = numero1;
            numero1.valor = 10;
            Console.WriteLine("numero1.valor = {0}, numero2.valor = {1}", numero1.valor, numero2.valor);
        }

            class Teste
            {
                public int valor;

            }
   
     
    }
}
