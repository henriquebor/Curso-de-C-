using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO5_SALARIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.WriteLine("Nome:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario.Nome + ", " + " $ " + funcionario.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário:");

            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcent);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + funcionario.Nome + "," + " $ " + funcionario.AumentarSalario(porcent).ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
