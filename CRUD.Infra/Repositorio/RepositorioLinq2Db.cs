using System.Configuration;
using CRUD.Dominio;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;



namespace CRUD.Infra.Repositorio
{
    public class RepositorioLinq2Db : IRepositorio
    {
        public static DataConnection ConexaoLinq2Db()
        {
            var DataConnection = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            return SqlServerTools.CreateDataConnection(DataConnection);
        }

        public List<Peca> ObterTodos()
        {
            var conexao = ConexaoLinq2Db();
            return conexao.GetTable<Peca>().ToList();
        }

        public Peca ObterPorId(int id)
        {
            var conexao = ConexaoLinq2Db();

            var listaPecas = ObterTodos();
            return listaPecas.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Peça não encontrada com id [{id}]");
        }

        public void Adicionar(Peca novaPeca)
        {
            var conexcao = ConexaoLinq2Db();
            conexcao.Insert(novaPeca);
        }

        public void Editar(int id, Peca pecaAtualizada)
        {
            var conexcao = ConexaoLinq2Db();
            conexcao.Update(pecaAtualizada);
        }

        public void Remover(int id)
        {
            var conexao = ConexaoLinq2Db();
            conexao.Delete(ObterPorId(id));
        }
    }
}
