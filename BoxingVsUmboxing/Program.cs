using System;

namespace BoxingVsUmboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int inteiro1 = 2;
            object objeto1 = inteiro1;
            //uma value type sendo amarzenada dentro de uma reference type

            //unboxing
            int inteiro2 = (int) objeto1; //isso se chama cast explicito, que é uma conversão de tipo
            Console.WriteLine("objeto1 = {0}, inteiro2 = {1}", objeto1, inteiro2);


        }
    }
}
