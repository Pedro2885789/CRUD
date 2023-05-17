using System.Windows.Forms;

namespace CRUD
{
    public partial class controleDePecas : Form
    {
        public List<Peca> listaDePecas = new();
        private int proximoId = 0;

        public controleDePecas()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDePecas;
        }

        public int ObterProximoId()
        {
            return ++proximoId;
        }

        private void AoClicarAdicionar_Click(object sender, EventArgs e)
        {
            CadastroDePecas cadastroDePecas = new();
            cadastroDePecas.ShowDialog();

            var pecaPreenchida = cadastroDePecas._peca;
            pecaPreenchida.Id = ObterProximoId();

            listaDePecas.Add(pecaPreenchida);
            AtualizarLista();
        }

        private void AoClicarEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0].Cells[0].RowIndex;

        }
    }
}