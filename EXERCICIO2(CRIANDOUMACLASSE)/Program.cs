using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2_CRIANDOUMACLASSE_
{
    class Program
    {
        static void Main(string[] args)
        {
            

           Pessoa Dados1 = new Pessoa();
           Pessoa Dados2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            Dados1.Nome = Console.ReadLine();
            Console.WriteLine("idade:");
            Dados1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome:");
            Dados2.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            Dados2.Idade = int.Parse(Console.ReadLine());

            if (Dados1.Idade > Dados2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Dados1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + Dados2.Nome);
            }
            Console.ReadLine();
            
        }
    }
}
