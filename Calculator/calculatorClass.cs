using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class CalculatorClass
    {
        // //CALCULO COM VETOR USANDO PARAMS
        // public static int Sum(params int[] numbers)
        // {
        //     int sum = 0;
        //     for(int i = 0; i < numbers.Length; i++){
        //         sum += numbers[i];
        //     }
        //     return sum;
        // }

        //CALCULO COM REF
        // public static void Triple(ref int x)
        // {
        //     x = x * 3;
        // }

        //CALCULO USANDO REF
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
