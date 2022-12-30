using System;
using EtiquetaDePreco.Entidades;
using EtiquetaDePreco.Entidades.Execao;
using System.Collections.Generic;
using System.Globalization;

namespace EtiquetaDePreco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Produto> list = new List<Produto>();

                Console.Write("Quantidade de produtos: ");
                int QuantidadeProduto = int.Parse(Console.ReadLine());

                for (int i = 1; i <= QuantidadeProduto; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Dados do Produto {i}");
                    Console.Write("O produto é Novo, Usado ou Importado (N/U/I)?: ");
                    char tipoProduto = char.Parse(Console.ReadLine());
                    list.Add(new Produto(Char.ToUpper(tipoProduto)));
                    Console.Write("Nome do Produto: ");
                    string nomeProduto = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (tipoProduto == 'c')
                    {
                        list.Add(new Produto(nomeProduto, precoProduto));
                    }
                    if (tipoProduto == 'u')
                    {
                        Console.Write("Data de fabricação (DD/MM/YYYY): ");
                        DateTime dataDefabricacaoProduto = DateTime.Parse(Console.ReadLine());
                        list.Add(new ProdutoUsado(nomeProduto, precoProduto, dataDefabricacaoProduto));
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
                foreach (Produto produto in list)
                {
                    Console.WriteLine(produto.EtiquetaDePreco());
                }
            }
            catch (ExecaoDominio e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (FormatException) { Console.WriteLine("Erro: Formato não aceito");
            }
        }
    }
}
