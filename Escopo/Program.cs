using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - condicionais 2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado.";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado.";
            }
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
            Console.ReadLine();
        }
    }
}