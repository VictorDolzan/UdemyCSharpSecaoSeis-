using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class LacoForEach
    {
        public static void ExecutarLacoForEach()
        {
            string[] vectLaco = new string[] {"Maria", "Victor", "Jasmin"};

            Console.WriteLine("------------------USANDO FOR:-----------------");
            for( int cont = 0; cont < vectLaco.Length; cont++)
            {
                Console.WriteLine(vectLaco[cont]);
            }   

            Console.WriteLine("------------------USANDO FOREACH:-----------------");    
           
            foreach(string obj in vectLaco)
            {
                Console.WriteLine($"Usando FOREACH: {obj} ");
            }
        }
    }
}