using System;

namespace _9_AluraCondicionais3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 !");

            bool acompanhado = false;
            string messageadc;

            if (acompanhado == true)
            {
                messageadc = "João esta acompanhado!";
            }
            else
            {
                messageadc = "João não esta acompanhado!";
            }

            Console.WriteLine(messageadc);
        }
    }
}

