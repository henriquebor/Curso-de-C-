using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VETOR_CLASSE_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Products[] vect = new Products[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Products { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;//acessando o price.
            }

            double avg = sum / n;
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
