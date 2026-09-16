using System;

namespace Task02_Paradigms
{
    public class DiceGame
    {
        public static void Executar()
        {
            Random random = new Random();
            int playerRoll;
            int computerRoll;

            Console.WriteLine("=== JOGO DOS DADOS (Imperativo) ===");

            do
            {
                playerRoll = random.Next(1, 7);
                computerRoll = random.Next(1, 7);

                Console.WriteLine($"\nO teu lançamento: {playerRoll}");
                Console.WriteLine($"Lançamento do computador: {computerRoll}");

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("-> Ganhaste!");
                }
                else if (computerRoll > playerRoll)
                {
                    Console.WriteLine("-> O computador ganhou!");
                }
                else
                {
                    Console.WriteLine("-> Empate! A lançar novamente os dados...");
                }

            } while (playerRoll == computerRoll);
        }
    }
}