using System.Globalization;
namespace EtiquetaDePreco.Entidades
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }

        public Produto()
        {
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
