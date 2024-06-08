using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace CadastroProdutos
{
  public class Produto
  {
    // Propriedades da classe Produto
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Fabricante { get; set; }
    public double Preco { get; set; }

    // Construtor da classe Produto
    public Produto(int id, string nome, string fabricante, double preco)
    {
      Id = id;
      Nome = nome;
      Fabricante = fabricante;
      Preco = preco;
    }

    // Método para criar um registro de Produto no banco de dados
    public void Criar()
    {
      // Inicia um bloco `using` para garantir que a conexão com o banco de dados será fechada corretamente após o uso.
      using (MySqlConnection conn = Database.GetConnection())
      {
        // Define a consulta SQL para inserir um novo registro na tabela `dbPerson`.
        string query = "INSERT INTO dbProduct (id, nome, fabricante, preco) VALUES (@Id, @Nome, @Fabricante, @Preco)";

        // Cria um objeto `MySqlCommand` com a consulta SQL e a conexão `conn`.
        MySqlCommand cmd = new MySqlCommand(query, conn);

        // Adiciona os parâmetros à consulta SQL. Esses parâmetros serão substituídos pelos valores reais ao executar a consulta.
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.Parameters.AddWithValue("@Nome", Nome);
        cmd.Parameters.AddWithValue("@Idade", Fabricante);
        cmd.Parameters.AddWithValue("@Preco", Preco);

        // Abre a conexão com o banco de dados.
        conn.Open();

        // Executa a consulta SQL definida anteriormente.
        cmd.ExecuteNonQuery();
      }

    }

    // Método estático para ler registros de Produto no banco de dados
    public void Ler()
    {

    }

    // Método para editar um registro de Produto no banco de dados
    public void Editar()
    {


    }

    // Método estático para excluir um registro de Produto no banco de dados
    public void Excluir()
    {

    }
  }
}
