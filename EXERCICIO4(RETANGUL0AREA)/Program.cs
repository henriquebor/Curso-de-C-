using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO4_RETANGUL0AREA_
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores valor = new Valores();
            
            
            Console.WriteLine("Entre com a largura e altura do retagulo:");
            valor.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valor.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            
            Console.WriteLine("Area = " + valor.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + valor.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + valor.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
