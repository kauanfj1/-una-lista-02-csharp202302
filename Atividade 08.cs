using System;
class Atividade02_08
{
    private static void Main(string[] args)
    {
        int veiculos, rodas, totalMoto, totalCarro;

        Console.WriteLine("Digite a quantidade de veiculos no estacionamento: ");
        veiculos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade total de rodas: ");
        rodas = int.Parse(Console.ReadLine());

        totalMoto = ((4 * veiculos) - rodas) / 2;
        totalCarro = veiculos - totalMoto;

        Console.WriteLine("O total de motos é: " + totalMoto);
        Console.WriteLine("O total de carros é: " + totalCarro);
    }
}
