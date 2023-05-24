namespace CRUD.Repositorio
{
    public interface IRepositorio
    {
        public List<Peca> ObterTodos();
        public Peca ObterPorId(int id);
        public void Adicionar(Peca novaPeca);
        public void Editar(int id, Peca peca);
        public void Remover(int id);
    }
}
