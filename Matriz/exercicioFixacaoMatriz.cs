using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class ExercicioFixacaoMatriz
    {
        public static void ExecutarExercicioFixacaoMatriz()
        {
            Console.Write("Digite o número de linhas: ");
            int nLinhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            int nColunas = int.Parse(Console.ReadLine());

            double[,] mat = new double[nLinhas, nColunas];

            for (int contLinha = 0; contLinha < nLinhas; contLinha++)
            {
                Console.Write($"Digite os valores da linha {contLinha}: ");
                string[] values = Console.ReadLine().Split(' ');

                for (int contCol = 0; contCol < nColunas; contCol++)
                {
                    mat[contLinha, contCol] = int.Parse(values[contCol]);
                }
            }

            Console.Write("Selecione um número pertencente a matriz: ");
            int nSelect = int.Parse(Console.ReadLine());


            for (int contLinha = 0; contLinha < nLinhas; contLinha++)
            {
                for (int contCol = 0; contCol < nColunas; contCol++)
                {
                    if (mat[contLinha, contCol] == nSelect)
                    {                        
                        Console.WriteLine("Position: " + contLinha + "," + contCol + ":"); 
                        if(contCol > 0)
                        {
                            Console.WriteLine("Left: " + mat[contLinha, contCol - 1]);
                        }
                        if(contLinha > 0)
                        {
                            Console.WriteLine("UP: " + mat[contLinha - 1, contCol]);
                        } 
                        if(contCol < nColunas - 1)
                        {
                            Console.WriteLine("Right: " + mat[contLinha, contCol + 1]);
                        }                      
                        if(contLinha < nLinhas - 1)
                        {
                            Console.WriteLine("Down: " + mat[contLinha +1, contCol]);
                        }
                    }
                }
            }
        }
    }
}