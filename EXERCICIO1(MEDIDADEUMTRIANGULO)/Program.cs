using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO1_MEDIDADEUMTRIANGULO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            X.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = X.Area();
            double areaY = Y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX < areaY)
            {
                Console.WriteLine("Maior area: Y");
            }
            else
            {
                Console.WriteLine("Maior area: X");
            }
            Console.ReadLine();
        }
    }
}
