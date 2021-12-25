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
            Console.Write("Quantos quartos serão alugados: ");
            int quartosAlugados = int.Parse(Console.ReadLine());

            Students[] vect = new Students[10];

            for(int cont = 0; cont < quartosAlugados; cont++)
            {
                Console.Write("Nome: ");
                string studentName = Console.ReadLine();
                Console.Write("Email: ");
                string studentEmail = Console.ReadLine();
                Console.Write("Quarto: ");
                int quartoEscolhido = int.Parse(Console.ReadLine());
                vect[quartoEscolhido] = new Students(studentName, studentEmail);                                           
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }            
        }
    }
}