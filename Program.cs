using System;
using System.Collections.Generic;

class Produto
{
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Material { get; set; }
    public int Quantidade { get; set; }
}

class Program
{
    static List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        while (true)
        {
            ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    NovoProduto();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                    RemoverProduto();
                    break;
                case "4":
                    EntradaEstoque();
                    break;
                case "5":
                    SaidaEstoque();
                    break;
                case "0":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produtos");
        Console.WriteLine("[4] Entrada Estoque");
        Console.WriteLine("[5] Saída Estoque");
        Console.WriteLine("[0] Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void NovoProduto()
    {
        Produto novoProduto = new Produto();

        Console.Write("Informe o tipo da peça: ");
        novoProduto.Tipo = Console.ReadLine();

        Console.Write("Nome da peça: ");
        novoProduto.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        novoProduto.Preco = decimal.Parse(Console.ReadLine());

        Console.Write("Material: ");
        novoProduto.Material = Console.ReadLine();

        novoProduto.Quantidade = 0;

        produtos.Add(novoProduto);
        Console.WriteLine("Produto cadastrado com sucesso.");
    }

    static void ListarProdutos()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Não há produtos cadastrados.");
            return;
        }

        Console.WriteLine("=== LISTA DE PRODUTOS ===");
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"Posição: {i}");
            Console.WriteLine($"Tipo: {produtos[i].Tipo}");
            Console.WriteLine($"Nome: {produtos[i].Nome}");
            Console.WriteLine($"Preço: R${produtos[i].Preco:F2}");
            Console.WriteLine($"Material: {produtos[i].Material}");
            Console.WriteLine($"Quantidade em estoque: {produtos[i].Quantidade}");
            Console.WriteLine("----------------------------");
        }
    }

    static void RemoverProduto()
    {
        Console.Write("Informe a posição do produto a ser removido: ");
        int posicao = int.Parse(Console.ReadLine());

        if (posicao >= 0 && posicao < produtos.Count)
        {
            produtos.RemoveAt(posicao);
            Console.WriteLine("Produto removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }
    }

    static void EntradaEstoque()
    {
        Console.Write("Informar a posição do produto: ");
        int posicao = int.Parse(Console.ReadLine());

        if (posicao >= 0 && posicao < produtos.Count)
        {
            Console.Write("Informar a quantidade de Entrada: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos[posicao].Quantidade += quantidade;
            Console.WriteLine("Entrada de estoque registrada com sucesso.");
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }
    }

    static void SaidaEstoque()
    {
        Console.Write("Informe a posição do produto: ");
        int posicao = int.Parse(Console.ReadLine());

        if (posicao >= 0 && posicao < produtos.Count)
        {
            Console.Write("Informe a quantidade de Saída: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= produtos[posicao].Quantidade)
            {
                produtos[posicao].Quantidade -= quantidade;
                Console.WriteLine("Saída de estoque registrada com sucesso.");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }
    }
}
