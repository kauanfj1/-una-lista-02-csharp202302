using System;
class Atividade02_03
{
    private static void Main(string[] args)
    {
        double celsius, fahrenheit;
        Console.WriteLine("Digite a temperatura em FAHRENHEIT: ");
        fahrenheit = double.Parse(Console.ReadLine());

        celsius = (fahrenheit - 32) / 1.8;

        Console.WriteLine("A temperatura em CELSIUS é: " + celsius.ToString("F"));
    }
}
