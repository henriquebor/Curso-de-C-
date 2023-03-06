using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO2._1_CRIACAODECLASSES_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados_Funcionario F1 = new Dados_Funcionario();
            Dados_Funcionario F2 = new Dados_Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            F1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (F1.Salario + F2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
