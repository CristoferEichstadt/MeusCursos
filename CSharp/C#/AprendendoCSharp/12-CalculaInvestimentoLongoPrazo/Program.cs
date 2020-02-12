using System;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatoreRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatoreRendimento;
                }
                fatoreRendimento += 0.0010;
            }

            Console.WriteLine("No final do investimento é de R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
