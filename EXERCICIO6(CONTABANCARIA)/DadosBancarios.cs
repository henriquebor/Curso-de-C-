using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO6_CONTABANCARIA_
{
    class DadosBancarios
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }

        public DadosBancarios (int numero, string titular) // construtor usando sobrecarga.
        {
            NumeroDaConta = numero;
            Titular = titular;
        }
        public DadosBancarios(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito (depositoInicial);
        }

        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia + 5.0; 
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                +", Titular: "
                + Titular
                + ", Saldo: $"
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }




    }



    
}
