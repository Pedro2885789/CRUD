using Microsoft.Data.SqlClient;
using System.Configuration;

namespace CRUD.Repositorio
{
    internal class RepositorioSql : IRepositorio
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
                    Categoria = lerExecucaoQuer[1].ToString(),
                    Nome = lerExecucaoQuer[2].ToString(),
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
            throw new NotImplementedException();
        }
        public void Adicionar(Peca peca)
        {
        }

        public void Editar(int id, Peca peca)
        {
        }
        public void Remover(int id)
        {
        }
    }
}
