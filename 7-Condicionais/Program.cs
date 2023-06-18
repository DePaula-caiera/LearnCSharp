using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeArtur = 14;
        int quantidadePessoas = 1;

        if (idadeArtur >= 18)
        {
            Console.WriteLine("Pode ter acesso ao evento!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode ter acesso ao evento.");
            }
            else
            {
                Console.WriteLine("Não pode ter acesso ao evento.");
            }
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

