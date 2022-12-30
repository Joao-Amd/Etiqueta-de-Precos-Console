using System.Globalization;
namespace EtiquetaDePreco.Entidades
{
    internal class ProdutoImportado :   Produto
    {
        public double TaxaAlfandegaProduto { get; set; }

        public ProdutoImportado(string nomeProduto, double precoProduto, double taxaAlfandegaProduto) 
            : base (nomeProduto, precoProduto)
        {
            TaxaAlfandegaProduto = taxaAlfandegaProduto;
        }

        public double TotalPreco()
        {
            return PrecoProduto + TaxaAlfandegaProduto;
        }

        public override string EtiquetaDePreco()
        {
            return NomeProduto + " (Importado) $ " + TotalPreco().ToString("F2", CultureInfo.InvariantCulture)
            + " (Taxa da Alfandega: $ " + TaxaAlfandegaProduto.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
