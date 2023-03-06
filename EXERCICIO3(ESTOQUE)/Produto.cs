using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO3_ESTOQUE_
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void Adicionarprodutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverPodutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " unidades, total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
