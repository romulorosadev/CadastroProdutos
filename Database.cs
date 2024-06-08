using MySql.Data.MySqlClient;

namespace CadastroProdutos
{
  public static class Database
  {
    private static string connectionString = "Server=localhost;Database=dbProduct;User Id=root;Password=;";

    public static MySqlConnection GetConnection()
    {
      return new MySqlConnection(connectionString);
    }
  }
}
