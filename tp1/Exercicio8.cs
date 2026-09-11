using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    internal class Exercicio8
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");

            string? nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + "!");
        }
    }
}