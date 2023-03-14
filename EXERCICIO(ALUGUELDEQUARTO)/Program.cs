using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_ALUGUELDEQUARTO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Hospedes[] vet = new Hospedes[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome:");
                string name = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto:");
                int numeroQuarto = int.Parse(Console.ReadLine());
                vet[i] = new Hospedes { Name = name, Email = email, Numeroquarto = numeroQuarto };

            }
            
            
        }
    }
}
