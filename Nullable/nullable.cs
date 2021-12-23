using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class NullableExample
    {
        public static void ExecutarNullableExample()
        {
            double? x = null;
            double? y = 10.0;            

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nulo");
            }

            double? z = null;
            double? v = 10;

            double a = z ?? 5;
            double b = v ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}