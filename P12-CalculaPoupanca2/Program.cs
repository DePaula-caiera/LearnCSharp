using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Calcula Poupança 2");

        /*
         while (mes <= 12)
         {
             investimento = investimento + investimento * 0.005;
             Console.WriteLine("No mês " + mes + "," + "você tem " + investimento);

             //mes = mes + 1;
             //mes ++;
             mes += 1;
         }
         */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + "," + "você tem " + investimento);
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

