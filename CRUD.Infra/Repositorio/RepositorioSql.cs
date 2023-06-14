using Microsoft.Data.SqlClient;
using System.Configuration;
using CRUD.Dominio;

namespace CRUD.Infra.Repositorio
{
    public class RepositorioSql : IRepositorio
    {
        private static readonly string connectionSttring = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        public List<Peca> ObterTodos()
        {
            SqlConnection conexaoBanco = new(connectionSttring);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new("SELECT * FROM Peca", conexaoBanco);

            var lerExecucaoQuer = comandoDeExecucao.ExecuteReader();

            List<Peca> lista = new();

            Peca peca;

            while (lerExecucaoQuer.Read())
            {
                peca = new Peca
                {
                    Id = Convert.ToInt32(lerExecucaoQuer[0]),
                    Nome = lerExecucaoQuer[1].ToString(),
                    Categoria = lerExecucaoQuer[2].ToString(),
                    Descricao = lerExecucaoQuer[3].ToString(),
                    Estoque = Convert.ToInt32(lerExecucaoQuer[4]),
                    DataDeFabricacao = Convert.ToDateTime(lerExecucaoQuer[5])
                };

                lista.Add(peca);
            }
            conexaoBanco.Close();

            return lista;
        }
        public Peca ObterPorId(int id)
        {
            Peca peca = new();

            SqlConnection conexaoBanco = new(connectionSttring);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new($"SELECT * FROM Peca WHERE Id = {id}", conexaoBanco);

            var lerExecucaoQuer = comandoDeExecucao.ExecuteReader();

            while (lerExecucaoQuer.Read())
            {
                peca.Id = Convert.ToInt32(lerExecucaoQuer[0]);
                peca.Nome = lerExecucaoQuer[1].ToString();
                peca.Categoria = lerExecucaoQuer[2].ToString();
                peca.Descricao = lerExecucaoQuer[3].ToString();
                peca.Estoque = Convert.ToInt32(lerExecucaoQuer[4]);
                peca.DataDeFabricacao = Convert.ToDateTime(lerExecucaoQuer[5]);
            }
            conexaoBanco.Close();

            return peca;
        }
        public void Adicionar(Peca novaPeca)
        {
            SqlConnection conexaoBanco = new(connectionSttring);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new("INSERT INTO Peca (Nome, Categoria, Descricao, Estoque, DataDeFabricacao) VALUES" +
                $"('{novaPeca.Nome}', '{novaPeca.Categoria}', '{novaPeca.Descricao}', {novaPeca.Estoque}, '{novaPeca.DataDeFabricacao}')", conexaoBanco);

            comandoDeExecucao.ExecuteNonQuery();

            conexaoBanco.Close();
        }

        public void Editar(int id, Peca pecaAtualizada)
        {
            SqlConnection conexaoBanco = new(connectionSttring);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new($"UPDATE Peca SET Categoria = '{pecaAtualizada.Categoria}', Nome = '{pecaAtualizada.Nome}', Descricao = '{pecaAtualizada.Descricao}', Estoque = {pecaAtualizada.Estoque}, DataDeFabricacao = '{pecaAtualizada.DataDeFabricacao}' WHERE Id ={id} ", conexaoBanco);

            comandoDeExecucao.ExecuteNonQuery();

            conexaoBanco.Close();
        }
        public void Remover(int id)
        {
            SqlConnection conexaoBanco = new(connectionSttring);

            conexaoBanco.Open();

            SqlCommand comandoDeExecucao = new($"DELETE FROM Peca where Id = {id}", conexaoBanco);

            var pecaARemover = ObterPorId(id);

            if (pecaARemover != null)
            {
                comandoDeExecucao.ExecuteNonQuery();
            }

            conexaoBanco.Close();
        }
    }
}
