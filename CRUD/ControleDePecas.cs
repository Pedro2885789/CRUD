namespace CRUD
{
    public partial class controleDePecas : Form
    {
        public List<Peca> listaDePecas = new();
        public int proximoId = 0;

        public controleDePecas()
        {
            InitializeComponent();
        }

        private void AoClicarAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDePecas cadastroDePecas = new();
            cadastroDePecas.ShowDialog();

            var pecaPreenchida = cadastroDePecas._peca;
            pecaPreenchida.Id = obterProximoId();


            listaDePecas.Add(pecaPreenchida);
            controleDePecas_Load();
        }
        private void controleDePecas_Load()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDePecas;
        }
        public int obterProximoId()
        {
            return ++proximoId;
        }
    }
}