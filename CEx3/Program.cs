﻿namespace CEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o 1º Numero: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o 2º Numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\nO número {maior} é o maior valor!");
        }
    }
}
