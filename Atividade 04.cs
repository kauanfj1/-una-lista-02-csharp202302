using System;
class Atividade02_04
{
    private static void Main(string[] args)
    {
        double capital, juros, montante;
        int prazo;

        Console.WriteLine("Digite o valor do capital que será aplicado: ");
        capital = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tempo te aplicação em meses: ");
        prazo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros mensal em %: ");
        juros = double.Parse(Console.ReadLine());

        montante = capital * Math.Pow((1 + (juros / 100)), prazo);

        Console.WriteLine("O montante a ser recebido ao final de " + prazo + " mes(es), é: " + montante.ToString("F"));
    }
}
