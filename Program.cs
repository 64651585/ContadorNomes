using System;

namespace ContadorNomes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Contador de Nomes ==========");
            Console.WriteLine("");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("O seu nome: {0}, possui {1} caracteres", nome, nome.Length);

        }
    }
}