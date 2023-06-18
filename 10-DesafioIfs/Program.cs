using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3200;

        if(salario >= 1900.00 && salario <= 2800.00)
        {
            Console.WriteLine("O IR é de 7,5% e a dedução seria de R$142,00.");
        }
        if(salario > 2800.00 && salario <= 3751.00)
        {
            Console.WriteLine("O IR é de 15% e a dedução seria de R$350,00.");
        }
        if(salario > 3751.00)
        {
            Console.WriteLine("O IR é de 22,5% e a dedução seria de R$636,00.");
        }
        else if(salario < 1900.00)
        {
            Console.WriteLine("Não terá desconto de IR.");
        }

        Console.WriteLine("Pressione ENTER pra fechar o programa ...");
        Console.ReadLine();
    }
}