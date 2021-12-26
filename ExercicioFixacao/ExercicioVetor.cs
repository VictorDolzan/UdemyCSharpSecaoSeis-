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
           Console.WriteLine("Quantos quartos serão alugados: ");
           int quantidadeQuartos = int.Parse(Console.ReadLine());

           Students[] vectStudent = new Students[10];

           for(int cont = 1; cont <= quantidadeQuartos; cont++)
           {
               Console.WriteLine($"Rent #{cont}");
               Console.Write("Name: ");
               string nameStu = Console.ReadLine();
               Console.Write("Email: ");
               string emailStu = Console.ReadLine();
               Console.Write("Room: ");
               int roomNumber = int.Parse(Console.ReadLine());
               vectStudent[roomNumber] = new Students(nameStu, emailStu);               
           }

           Console.WriteLine("Busy Rooms:");
           for(int i = 0; i < 10; i++)
           {
               if(vectStudent[i] != null)
               {
                   Console.WriteLine($"{i}: {vectStudent[i]}");
               }
           }
        }
    }
}