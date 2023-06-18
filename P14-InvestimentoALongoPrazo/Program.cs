using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 14 - Investimento à Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos < 6; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;

                Console.WriteLine("No mês " + mes + " do ano " + anos);
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine("Após 5 anos, você terá R$ " + investimento);
        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

