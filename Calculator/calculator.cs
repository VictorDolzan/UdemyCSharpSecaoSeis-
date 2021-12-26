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
            int s1 = CalculatorClass.Sum( 2, 3 );
            int s2 = CalculatorClass.Sum( 2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1 + s2);
        }
    }
}