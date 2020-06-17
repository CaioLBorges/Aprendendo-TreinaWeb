using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //passagem por valor (valueType)
            int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;

            Console.WriteLine("numero1 = {0}, numero2 = {1}", numero1, numero2);
        
            //passagem por referência (referenceType)
            Teste teste1 = new Teste();
            teste1.quantidade = 3;
            Teste teste2 = teste1;
            teste1.quantidade = 10;
            Console.WriteLine("teste1.quantidade {0}, teste2.quantidade {1}", teste1.quantidade, teste2.quantidade);


        }
    }

    class Teste
    {
        public int quantidade;

    }
}
