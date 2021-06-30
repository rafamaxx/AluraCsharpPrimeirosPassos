using System;

namespace _7_AluraCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais!");

            int idadeJoao = 17;
            int qtdPessoas = 2;

            if (idadeJoao >= 18 || qtdPessoas>1)
                Console.WriteLine("João é maior de idade!");
            else
                Console.WriteLine("João é menor de idade!");


        }
    }
}
