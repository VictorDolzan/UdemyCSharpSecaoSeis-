﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoSeis
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

            // Console.WriteLine("A partir de agora são os testes com Nullable: ");

            // NullableExample.ExecutarNullableExample();

            //Console.WriteLine("Testes com Vetor: ");
            //Vetor.ExecutarVetor();
            //SegundoVetor.ExecutarSegundoVetor();
            //ExercicioVetorPensao.ExecutarExercicioPensao();
            Console.WriteLine("Testes com Params: ");
            Calculator.ExecutarCalculator();
        }
    }
}