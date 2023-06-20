using LinqToDB.Mapping;

namespace CRUD.Dominio
{
    public class Peca
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public int Estoque { get; set; }
        public DateTime DataDeFabricacao { get; set; }
    }
}
