﻿namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nInforme o numero de horas trabalhadas: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\nInforme o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorHora * quantidadeHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");

        }
    }
}
