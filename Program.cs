using System;
class Program
{
    static void Main(string[] args)
    {
        ProdutoCrud produtoCrud = new ProdutoCrud();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== CADASTRO DE PRODUTOS ===");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1) Adicionar");
            Console.WriteLine("2) Listar");
            Console.WriteLine("3) Atualizar");
            Console.WriteLine("4) Excluir");
            Console.WriteLine("5) Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Adicionar(produtoCrud);
                    break;
                case 2:
                    Listar(produtoCrud);
                    break;
                case 3:
                    Atualizar(produtoCrud);
                    break;
                case 4:
                    Excluir(produtoCrud);
                    break;
                case 5:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void Adicionar(ProdutoCrud produtoCrud)
    {
        Console.Write("\n=== ADICIONAR PRODUTO ===\n");
        Produto novoProduto = new Produto();
        Console.Write("Id: ");
        novoProduto.Id = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        novoProduto.Nome = Console.ReadLine();
        Console.Write("Fabricante: ");
        novoProduto.Fabricante = Console.ReadLine();
        Console.Write("Preço: ");
        novoProduto.Preco = decimal.Parse(Console.ReadLine());
        produtoCrud.Adicionar(novoProduto);
        Console.WriteLine("_____________________");
        Console.WriteLine("PRODUTO ADICIONADO!\n\n\n");
    }


    static void Atualizar(ProdutoCrud produtoCrud)
    {
        Console.Write("\n=== ATUALIZAR PRODUTO ===\n");
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());
        var produto = produtoCrud.ListarProdutoId(id);
        if (produto != null)
        {
            Console.Write("Novo Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Novo Fabricante: ");
            produto.Fabricante = Console.ReadLine();
            Console.Write("Novo Preço: ");
            produto.Preco = decimal.Parse(Console.ReadLine());
            produtoCrud.Atualizar(produto);
            Console.WriteLine("______________________");
            Console.WriteLine("PRODUTO ATUALIZADO!\n\n\n");
        }
        else
        {
            Console.WriteLine("__________________________");
            Console.WriteLine("PRODUTO NÃO ENCONTRADO!\n\n\n");
        }
    }

    static void Listar(ProdutoCrud produtoCrud)
    {
        Console.Write("\n=== TODOS OS PRODUTOS ===\n");
        var produtos = produtoCrud.ListarProdutosTodos();
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Id: {produto.Id}\nNome: {produto.Nome}\nFabricante: {produto.Fabricante}\nPreço: {produto.Preco}");
            Console.WriteLine("__________________\n");
        }
    }

    static void Excluir(ProdutoCrud produtoCrud)
    {
        Console.Write("\n=== EXCLUIR PRODUTO ===\n");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        produtoCrud.Excluir(id);
        Console.WriteLine("___________________");
        Console.WriteLine("PRODUTO EXCLUÍDO!\n\n\n");
    }
}
