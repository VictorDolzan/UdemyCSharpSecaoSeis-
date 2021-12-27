using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class ExercicioMatriz
    {
        public static void ExecutarExercicioResolvidoMatriz()
        {
            Console.WriteLine("Digite o numero da Matriz");
            int nMatriz = int.Parse(Console.ReadLine());

            int[,] mat = new int[nMatriz,nMatriz];

            for(int contLinha = 0; contLinha < nMatriz; contLinha++)
            {
                Console.WriteLine($"Digite os valores da linha {contLinha}");
                string[] values = Console.ReadLine().Split(' ');

                for(int contCol = 0; contCol < nMatriz; contCol++)
                {                    
                    mat[contLinha, contCol] = int.Parse(values[contCol]);
                }
            }

            Console.WriteLine("MAIN DIAGONAL: ");
            for(int cont = 0; cont < nMatriz; cont ++)
            {
                Console.Write(mat[cont, cont] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int contLinha = 0; contLinha < nMatriz; contLinha++)
            {
                for(int contCol = 0; contCol < nMatriz; contCol++)
                {
                    if(mat[contLinha, contCol] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Negative Numbers: {count}");
        }
    }
}