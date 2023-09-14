using System;
class Atividade02_09
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade total de segundos: ");
        int totalSegundos = int.Parse(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int resto = totalSegundos % 3600;
        int minutos = resto / 60;
        int segundos = resto % 60;

        Console.WriteLine("O valor correspondente é: "+horas+" horas "+minutos+" minutos e "+segundos+" segundos");
        
    }
}
