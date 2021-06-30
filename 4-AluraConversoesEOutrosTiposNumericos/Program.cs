using System;

namespace _4_AluraConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando porjeto 4, teste de conversões e novos tipos numericos.");
            double salario;
            salario = 1250.50;

            int salarioInt;
            salarioInt = (int)salario;


            long idade;
            idade = 99999999999999999;
            Console.WriteLine(idade);
            short quantidadeDeProdutos;
            quantidadeDeProdutos = 15000;
            Console.WriteLine(quantidadeDeProdutos);
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.WriteLine(salario);
            Console.WriteLine(salarioInt);
        }
    }
}
