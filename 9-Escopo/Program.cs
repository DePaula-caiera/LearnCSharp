using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeArtur = 14;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "Artur está acompanhado.";
        }
        else 
        {
            textoAdicional = "Artur NÃO está acompanhado.";
        }

        if (idadeArtur >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode ter acesso ao evento!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode ter acesso ao evento.");
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

