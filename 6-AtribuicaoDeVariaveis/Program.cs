using System;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");
            int idade = 32;
            int idadeGustavo = idade;

            idade = 123;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);
        }
    }
}
