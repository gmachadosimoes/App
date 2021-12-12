﻿using System;

namespace CalculaRendimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
          
            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 00.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido + ".");

            Console.ReadLine();
        }
    }
}
