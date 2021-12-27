using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Matriz
    {
        public static void ExecutarMatriz()
        {
            double[,] mat = new double[2,3];

            Console.WriteLine("Mat.Length: ");
            Console.WriteLine(mat.Length);
            Console.WriteLine("Mat.Rank: ");
            Console.WriteLine(mat.Rank);
            Console.WriteLine("Mat.GetLength 0: ");
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine("Mat.GetLength(1)");
            Console.WriteLine(mat.GetLength(1));
        }
    }
}