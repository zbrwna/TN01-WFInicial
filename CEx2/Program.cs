using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace CEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = @"
------------------------------------------------
1 - Domingo
2 - Segunda-feira
3 - Terça-feira
4 - Quarta-feira
5 - Quinta-feira
6 - Sexta-feira
7 - Sabado
------------------------------------------------
            ";

            Console.WriteLine(menu);
            byte opcao = byte.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    break;

            }
        }
    }
}
