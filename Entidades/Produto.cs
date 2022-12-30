using System.Globalization;
using EtiquetaDePreco.Entidades.Execao;
namespace EtiquetaDePreco.Entidades
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public char TipoProduto { get; set;}

        public Produto(char tipoProduto)
        {
            if (tipoProduto == 'N' || tipoProduto == 'U' || tipoProduto == 'I')
            {
                TipoProduto = tipoProduto;
            }
            else
            {
                throw new ExecaoDominio("O tipo de pessoa só pode ser N, U ou I");
            }   
        }
        public Produto(string nomeProduto, double precoProduto)
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
        }

        public  virtual string EtiquetaDePreco()
        {
            return NomeProduto + " $ " + PrecoProduto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
