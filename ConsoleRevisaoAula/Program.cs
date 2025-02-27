namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a primeira nota do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }

        }
    }
}
