using System;
class Atividade02_02
{
    private static void Main(string[] args)
    {
        double valorAtual, valorNovo;

        Console.WriteLine("Informe o valor do produto: ");
        valorAtual = double.Parse(Console.ReadLine());

        valorNovo = valorAtual + (valorAtual * 0.10);

        Console.WriteLine("Novo valor do produto: " + valorNovo.ToString("F"));
    }
}
