using System;
class Atividade02_07
{
    private static void Main(string[] args)
    {
        double salFixo, vendas, percentual, salTotal;

        Console.WriteLine("Digite o salário fixo do vendedor: ");
        salFixo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o total de vendas do mês desse vendedor: ");
        vendas = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o percentual sobre o total das vendas: ");
        percentual = double.Parse(Console.ReadLine());

        salTotal = salFixo + (vendas * (percentual / 100));
        Console.WriteLine("O salário total do vendedor é de: " + salTotal);
    }
}
