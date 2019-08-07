using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-Feira";
                    break;
                case 3:
                    dia = "Terça-Feira";
                    break;
                case 4:
                    dia = "Quarta-Feira";
                    break;
                case 5:
                    dia = "Quinta-Feira";
                    break;
                case 6:
                    dia = "Sexta-Feira";
                    break;
                case 7:
                    dia = "Sábado";
                    break;

                default:
                    dia = "Data Inválida";
                    break;
            }

            Console.WriteLine("Dia da Semana: " + dia);
            Console.ReadLine();
        }
    }
}
