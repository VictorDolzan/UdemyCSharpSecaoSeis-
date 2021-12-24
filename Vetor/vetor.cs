using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Vetor
    {
        public static void ExecutarVetor()
        {
            int numeroInteiro;
            
            Console.WriteLine("Digite um valor N: ");
            numeroInteiro = int.Parse(Console.ReadLine());

            double[] vect = new double [numeroInteiro];

            for(int contador = 0; contador < numeroInteiro; contador++)
            {
                Console.WriteLine($"Digite o #{contador}");
                vect[contador] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for(int cont = 0; cont < numeroInteiro; cont++)
            {
                sum += vect[cont];
            }

            double avg = sum / numeroInteiro;

            Console.WriteLine("Average Height: " + avg.ToString("F2"));
        }
    }
}