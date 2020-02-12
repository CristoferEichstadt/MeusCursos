using System;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 0.2;

                Console.WriteLine( "Após " + contadorMes + " meses, você terá R$ " + (int)valorInvestido );
            }


            Console.ReadLine();
        }
    }
}
