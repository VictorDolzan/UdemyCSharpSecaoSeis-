using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class ExercicioVetorPensao
    {
        public static void ExecutarExercicioPensao()
        {
            Students[] vect = new Students[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numRooms = int.Parse(Console.ReadLine());
            

            for(int cont = 1; cont <= numRooms; cont++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{cont}:");
                Console.Write("Nome: ");
                string NomeStudent = Console.ReadLine();
                Console.Write("Email: ");
                string EmailSudent = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Students(NomeStudent, EmailSudent);                 
            }

            Console.WriteLine();
            Console.WriteLine("Quartos que estão ocupados: ");
            for(int cont = 0; cont < 10; cont++)
            {
                if(vect[cont] != null)
                {
                    Console.WriteLine(cont + ": " + vect[cont]);
                }
            }
        }
    }
}