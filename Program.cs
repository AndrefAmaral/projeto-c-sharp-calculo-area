using System;
using System.Globalization;

namespace Calculo_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres valores: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = a * c / 2;
            Console.WriteLine("Triangulo = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

            double circulo = 3.14159 * Math.Pow(c, 2.0);
            Console.WriteLine("Circulo = " + circulo.ToString("F3", CultureInfo.InvariantCulture));

            double trapezio = (a + b) * c / 2;
            Console.WriteLine("Trapezio = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            double quadrado = Math.Pow(b, 2.0);
            Console.WriteLine("Quadrado = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

            double retangulo = a * b;
            Console.WriteLine("Retangulo = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
