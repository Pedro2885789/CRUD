namespace CRUD.Repositorio
{
    public interface IRepositorio
    {
        public List<Peca> ObterTodos();
        public Peca ObterPorId(int id);
        public void Adicionar(Peca novaPeca);
        public void Editar(int id, Peca pecaAtualizada);
        public void Remover(int id);
    }
}
