using System;
using System.Globalization;

namespace exercicio8_salariobonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendas, salarioReal;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome = vet[0];
            salario = double.Parse(vet[1], CultureInfo.InvariantCulture);
            totalVendas = double.Parse(vet[2], CultureInfo.InvariantCulture);

            totalVendas = (double)totalVendas * 0.15;

            salarioReal = salario + totalVendas;

            Console.WriteLine("TOTAL = " + salarioReal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
