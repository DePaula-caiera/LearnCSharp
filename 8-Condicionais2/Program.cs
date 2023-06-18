using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeArtur = 14;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeArtur >= 18 || grupo)
        {
            Console.WriteLine("Pode ter acesso ao evento!");
        }
        else
        {
            Console.WriteLine("Não pode ter acesso ao evento.");
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

