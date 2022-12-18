using System;
using EtiquetaDePreco.Entidades;
using System.Collections.Generic;
using System.Globalization;

namespace EtiquetaDePreco
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list  = new List<Produto>();

            Console.Write("Quantidade de produtos: ");
            int QuantidadeProduto = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuantidadeProduto; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do Produto {i}");
                Console.Write("O produto é Novo, Usado ou Importado (N/U/I)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'c')
                {
                    list.Add(new Produto(nomeProduto, precoProduto));
                }
                if(ch == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime dataDefabricacaoProduto = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nomeProduto,precoProduto, dataDefabricacaoProduto));
                }
                else
                {
                    Console.Write("Taxa da Alfandaga: ");
                    double taxaAlfandegaProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nomeProduto, precoProduto, taxaAlfandegaProduto));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Preço das etiquetas");
            foreach(Produto produto in list)
            {
                Console.WriteLine(produto.EtiquetaDePreco());
            }
        }
    }
}
