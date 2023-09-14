using System;
class Atividade02_09
{
    private static void Main(string[] args)
    {
        double num1, num2, num3, mediaAritmetica, mediaHarmonica, mediaGeometrica;

        Console.WriteLine("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        num3 = double.Parse(Console.ReadLine());

        mediaAritmetica = (num1 + num2 + num3) / 3;
        mediaHarmonica = 3 / ((1 / num1) + (1 / num2) + (1 / num3));
        mediaGeometrica = Math.Cbrt((num1 * num2 * num3));

        Console.WriteLine("O valor da média aritmética é: " + mediaAritmetica.ToString("F"));
        Console.WriteLine("O valor da média harmonica é: " + mediaHarmonica.ToString("F"));
        Console.WriteLine("O valor da média geométrica é: " + mediaGeometrica.ToString("F"));
    }
}
