using System;

namespace P13_AluraForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13....!");

            for(int i = 0; i < 10; i++)
            {
                for (int j = i; j >= 0; j--)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
