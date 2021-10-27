using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project 4 running");

            double salario = 1200.50;
            int salarioEmInt = (int)salario;

            long idade = 13000000000;
            Console.WriteLine("A idade do universo é " + idade + " de anos.");

            short quantidadeDeProdutos = 15000;
            Console.WriteLine(quantidadeDeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine(salario);
            Console.WriteLine(salarioEmInt);
            

            Console.ReadLine();
        }
    }
}
