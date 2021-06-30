using System;

namespace _10_AluraCalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupanca!");

            double valorInvestido = 1000;
            int nMeses = 0;

            Console.WriteLine("Valor inicial"+valorInvestido);

            while (valorInvestido < 10000)
            {
                valorInvestido += valorInvestido * 0.0036;
                nMeses++;
                Console.WriteLine("Estamos no mês " +nMeses+ " o valor atual é de {0:0.00}",valorInvestido);
            }
            Console.WriteLine("Serão necessarios {0} anos para chegar a R$ 10000,00", (nMeses / 12));
        }
    }
}
