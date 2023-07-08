using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual é a sua idade?");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Em qual bairro você mora?");
        string bairro = Console.ReadLine();

        string nomeMaiusculo = nome.ToUpper();

        Console.WriteLine($"Nome: {nomeMaiusculo}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Bairro: {bairro}");
    }
}
