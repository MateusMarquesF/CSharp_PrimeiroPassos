﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio URI 1067

            int x;

            x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++){
                if( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}