﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido_URI1078
{
    class Program
    {
        //EXERCICIO DO URI - EX:1078
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for(int i=1; i <= 10; i++){
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }

            Console.ReadLine();
            
        }
    }
}
