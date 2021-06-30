using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11!");

            double initValue;
            Console.WriteLine("Digite o valor inicial da poupança");
            initValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita a quantidade de meses");
            int qtdMes = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdMes; i++)
            {
                Console.Write("Estamos no mês {0} o valor de rendimento {0:0.00}", i + 1, (initValue * 0.0036));
                initValue += initValue * 0.0036;
                Console.WriteLine(" nosso valor parcial é de {0:0.00}", initValue);
            }

        }
    }
}
