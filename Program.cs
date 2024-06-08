using System;

namespace CadastroProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===== CADASTRO DE PRODUTOS =====\n");
            Console.Write("\nInforme os dados conforme forem solicitados:\n");
            // Perguntando os valores ao usuário
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Fabricante: ");
            string fabricante = Console.ReadLine();

            Console.Write("Preço (R$): ");
            double preco = double.Parse(Console.ReadLine());


            // Criando um objeto da classe produto com os valores fornecidos pelo usuário
            Produto produto = new Produto(id, nome, fabricante, preco);

            // Salvando o objeto no banco de dados
            try
            {
                produto.Criar();
                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao salvar a produto no banco de dados: " + ex.Message);
            }
        }
    }
}
