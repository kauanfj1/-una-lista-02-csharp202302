using System;
class Atividade02_06
{
    private static void Main(string[] args)
    {
       double num1, num2, logaritmo;

        Console.WriteLine("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base logaritmica: ");
        num2 = double.Parse(Console.ReadLine());

        logaritmo = Math.Log(num1, num2);

        Console.WriteLine("O valor do logaritmo é: " + logaritmo.ToString("F"));
    }
}
