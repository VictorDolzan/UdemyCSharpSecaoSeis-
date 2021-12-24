using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class SegundoVetor
    {
        public static void ExecutarSegundoVetor()
        {
            Console.WriteLine("Digite a quantidade de Produtos: ");
            int numeroDeProdutos = int.Parse(Console.ReadLine());

            Product[] vect = new Product[numeroDeProdutos];

            for(int cont = 0; cont < numeroDeProdutos; cont++)
            {
                Console.WriteLine($"Digite o nome do produto {cont}");
                string name = Console.ReadLine();
                Console.WriteLine($"Digite o valor do produto {cont}");
                double price = double.Parse(Console.ReadLine());

                vect[cont] = new Product(name, price);
            }

            double sum = 0.0;
            for(int cont = 0; cont < numeroDeProdutos; cont++)
            {
                sum += vect[cont].Price;
            }

            double avg = sum / numeroDeProdutos;

            Console.WriteLine("Average Price: " + avg.ToString("F2"));
        }
    }
}