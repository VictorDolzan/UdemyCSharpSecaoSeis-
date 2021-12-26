using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Calculator
    {
        public static void ExecutarCalculator()
        {
            // //CALCULANDO USANDO PARAMS
            // int s1 = CalculatorClass.Sum( 2, 3 );
            // int s2 = CalculatorClass.Sum( 2, 4, 3);

            // Console.WriteLine(s1);
            // Console.WriteLine(s2);
            // Console.WriteLine(s1 + s2);

            //CALCULANDO USANDO REF
            // int a = 10;
            // CalculatorClass.Triple(ref a);
            // Console.WriteLine(a);

            //CALCULANDO USANDO OUT

            int a = 10;
            int triple;
            CalculatorClass.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}