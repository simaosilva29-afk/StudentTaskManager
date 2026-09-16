using System;

namespace Task02_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolhe o programa a executar:");
            Console.WriteLine("1 - Dice Game (Imperativo)");
            Console.WriteLine("2 - Student Information (Declarativo)");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            if (opcao == "1")
            {
                DiceGame.Executar();
            }
            else if (opcao == "2")
            {
                StudentInformation.Executar();
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}