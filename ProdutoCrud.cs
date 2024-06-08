using System;
using System.Collections.Generic;
using System.Linq;

public class ProdutoCrud
{
  private List<Produto> produtos = new List<Produto>();

  // Create
  public void Adicionar(Produto produto)
  {
    produtos.Add(produto);
  }

  // Read
  public List<Produto> ListarProdutosTodos()
  {
    return produtos;
  }

  public Produto ListarProdutoId(int id)
  {
    return produtos.FirstOrDefault(p => p.Id == id);
  }

  // Update
  public void Atualizar(Produto produtoAtualizado)
  {
    var produto = produtos.FirstOrDefault(p => p.Id == produtoAtualizado.Id);
    if (produto != null)
    {
      produto.Nome = produtoAtualizado.Nome;
      produto.Fabricante = produtoAtualizado.Fabricante;
      produto.Preco = produtoAtualizado.Preco;
    }
  }

  // Delete
  public void Excluir(int id)
  {
    var produto = produtos.FirstOrDefault(p => p.Id == id);
    if (produto != null)
    {
      produtos.Remove(produto);
    }
  }
}
