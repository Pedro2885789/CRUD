namespace CRUD.Repositorio
{
    internal class RepositorioListaSingleton : IRepositorio
    {
        protected List<Peca> ListaDePeca = Singleton.Instancia()._listaDePecas;

        public List<Peca> ObterTodos()
        {
            return ListaDePeca.ToList();
        }
        public Peca ObterPorId(int id)
        {
            return ListaDePeca.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Peça não encontrada com id:[{id}]");
        }
        public void Adicionar(Peca novaPeca)
        {
            ListaDePeca.Add(novaPeca);
        }
        public void Editar(int id, Peca pecaEditada)
        {
            var pecaAMudar = ObterPorId(id);
            var index = ListaDePeca.IndexOf(pecaAMudar);
            
            ListaDePeca[index] = index != -1 ?
            pecaEditada : throw new Exception($"Peça não encontrada com id [{id}]");
        }
        public void Remover(int id)
        {
            var pecaSelecionada = ObterPorId(id);
            ListaDePeca.Remove(pecaSelecionada);
        }
    }
}
