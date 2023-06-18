using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de Variáveis");

        int idade = 40;
        int idadeZe = idade;

        Console.WriteLine(idadeZe);

        idade = 60;

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

