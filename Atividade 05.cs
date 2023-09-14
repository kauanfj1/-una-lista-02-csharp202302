using System;
class Atividade02_05
{
    private static void Main(string[] args)
    {
        double salario, horas, valorHora, salFamilia; 
        int filhos;

        Console.WriteLine("Digite a quantidade de horas trabalhadas no mês: ");
        horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor da hora do funcionário: ");
        valorHora = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor do salário familia: ");
        salFamilia = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de filhos menores que 14 anos:");
        filhos = int.Parse(Console.ReadLine());

        if (filhos > 0)
        {
            salario = (horas * valorHora) + (salFamilia * filhos);
            Console.WriteLine("O salário bruto do funcionário é: " + salario);
            
        }
        else
        {
            salario = (horas * valorHora);
            Console.WriteLine("O salário bruto do funcionário é: " + salario);
        }        
    }
}
