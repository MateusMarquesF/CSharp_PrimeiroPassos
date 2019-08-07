using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA 1019
            int N, hora, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            hora = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);

            Console.ReadLine();

        }
    }
}
