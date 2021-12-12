using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;
            double fatorRendimento = 0.0036;

            while (contadorMes <= 12)
            {
                contadorMes++;
                valorInvestido +=  valorInvestido * fatorRendimento;

                Console.WriteLine("Após " + contadorMes + " você terá R$" + valorInvestido + ".");
            }



            Console.ReadLine();
        }
    }
}
