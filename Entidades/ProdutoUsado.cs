using System.Globalization;
namespace EtiquetaDePreco.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacaoProduto { get; set; }

        public ProdutoUsado()
        {
        }
        public ProdutoUsado(string nomeProduto, double precoProduto, DateTime dataDeFabricacaoProduto) : base(nomeProduto, precoProduto)
        {
            DataDeFabricacaoProduto = dataDeFabricacaoProduto;
        }

        public override string EtiquetaDePreco()
        {
            return NomeProduto + " (Usado) $ " + PrecoProduto.ToString("F2", CultureInfo.InvariantCulture)
            + " (Data de fabricação: " + DataDeFabricacaoProduto.ToString("dd/MM/yyyy") + ")";
        }
    }
}
