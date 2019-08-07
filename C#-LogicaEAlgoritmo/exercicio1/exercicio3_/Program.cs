using System;
using System.Globalization;
namespace exercicio3_
{
    class Program
    {
        static void Main(string[] args)
        {

            double b, a, AREA, PERIMETRO, DIAGONAL;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AREA = b * a;

            PERIMETRO = 2 * (b + a);

            DIAGONAL = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + AREA.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("PERIMETRO = " + PERIMETRO.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL = " + DIAGONAL.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
