using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 4800.45;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long é um tipo de variável de 64bits
        long x = 20000000000000;
        Console.WriteLine(x);

        short y = 2000;
        Console.WriteLine(y);

        float altura = 1.90f;
        Console.WriteLine(altura);

        double idade = 35.0;
        Console.WriteLine("A idade de PK é " + idade + " anos.");


        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}

