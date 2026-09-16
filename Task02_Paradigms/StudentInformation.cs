using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02_Paradigms
{
    public class StudentInformation
    {
        public static void Executar()
        {
            List<double> grades = new List<double>();

            Console.WriteLine("=== INFORMAÇÃO DO ESTUDANTE (Declarativo) ===");
            Console.WriteLine("Introduz 5 notas:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Nota {i}: ");
                if (double.TryParse(Console.ReadLine(), out double grade))
                {
                    grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Valor inválido! Tenta novamente.");
                    i--;
                }
            }

            double maxGrade = grades.Max();
            double minGrade = grades.Min();
            double averageGrade = grades.Average();

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Nota máxima: {maxGrade}");
            Console.WriteLine($"Nota mínima: {minGrade}");
            Console.WriteLine($"Média: {averageGrade:F2}");
        }
    }
}