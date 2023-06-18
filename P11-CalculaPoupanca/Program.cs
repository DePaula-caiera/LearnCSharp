using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança");

        double investimento = 1000;


        //Rendimento de 0.5% (0.005) ao mês

        //mês 1
        //investimento = investimento + investimento * 0.005;
        //mês 2
        //investimento = investimento + investimento * 0.005;
        //mês3
        //investimento = investimento + investimento * 0.005;

        //Console.WriteLine(investimento);

        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + "," + "você tem " + investimento);

            //mes = mes + 1;
            //mes ++;
            mes += 1;
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

