﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
        }

        void ExecutarPrograma()
        {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = SomarNumeros(numero1, numero2);
            Console.WriteLine("O resultado da soma é {0}", soma);
        }

        int LerInteiro()
        {
            Console.Write("Digite um número: ");
            return int.Parse(Console.ReadLine());
        }

        int SomarNumeros(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }
}
