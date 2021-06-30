using System;

namespace _5_AluraCaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 Caracteres e Textos!");

            char firstLetter = 'a';
            Console.WriteLine(firstLetter);

            firstLetter = (char)123;
            Console.WriteLine(firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine(firstLetter);

            string title = "Alura Cursos";
            Console.WriteLine(title + " Blaa");

        }
    }
}
