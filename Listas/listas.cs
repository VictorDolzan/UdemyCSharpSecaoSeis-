using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Listas
    {
        public static void ExecutarListas()
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");


            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count());

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int position1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + position1);

            int position2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + position2);

            List<string> list1 = list.FindAll(x => x.Length == 5);
            
            Console.WriteLine("---------------------");
            foreach(string obj in list1)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            //list.RemoveAt(3);
            //list.RemoveRange(2, 2);
            Console.WriteLine("Após remoção de usuário: ");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("Após remoção de todos que possuem 'M'");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}