namespace CRUD
{
    internal class Singleton
    {
        private static Singleton? _instancia;
        private static int proximoId = 0;
        public List<Peca> _listaDePecas= new();

        public static Singleton Instancia()
        {
            lock (typeof(Singleton))
            {
                _instancia ??=
                    new Singleton();
            }
            return _instancia;
        }

        public static int ObterProximoId()
        {
            return ++proximoId;
        }
    }
}
