using System;

namespace P12_AluraCalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12!");
            double fatorRendimento = 1.0036;
            double valorInvestido = 100;
            for (int i = 0; i < 10; i++)
            {
                for(int j=0;j<12;j++)
                {
                    valorInvestido += 1000;
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Estamos no ano {0}, mês {1} e nosso valor investido esta em: R$ {2:0.00}", i+1, j+1 , valorInvestido);
                }
                fatorRendimento += 0.0010;
            }

        }
    }
}
