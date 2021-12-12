using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7 - condicionais");

            int idadeJoao = 16;
            int quandidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos, entrada permitida.");
            }
            else
            {
                Console.WriteLine("Joao nao possui mais de 18 anos, entrada proibida");
            }

            Console.ReadLine();
        }
    }
}
