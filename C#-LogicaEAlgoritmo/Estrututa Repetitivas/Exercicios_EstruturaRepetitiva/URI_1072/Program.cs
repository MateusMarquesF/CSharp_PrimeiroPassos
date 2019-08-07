using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1072
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, x, den, fora;
            int intervalo = (10, 20);

            N = int.Parse(Console.ReadLine());
            

            den = 0;
            fora = 0;
         
            for (int i = 0; i <N; i++){
                x = int.Parse(Console.ReadLine());
                if (x == intervalo)
                {
                    den++;
                }
                else{
                    fora++;
                }
            }

            Console.WriteLine(den + " in ");
            Console.WriteLine(fora + " out ");

            Console.ReadLine();
        }
    }
}
