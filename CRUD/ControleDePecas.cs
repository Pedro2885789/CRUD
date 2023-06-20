using CRUD.Dominio;

namespace CRUD
{
    public partial class ControleDePecas : Form
    {
        private readonly IRepositorio _repositorio;

        public ControleDePecas(IRepositorio repositorio)
        {
            _repositorio = repositorio;

            InitializeComponent();

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _repositorio.ObterTodos();
        }

        private void AoClicarAdicionar_Click(object sender, EventArgs e)
        {
            try
            {               
                CadastroDePecas cadastroDePecas = new(null);
                cadastroDePecas.ShowDialog();

                var pecaPreenchida = cadastroDePecas.peca;

                if (cadastroDePecas.DialogResult == DialogResult.OK)
                {
                    //pecaPreenchida.Id = Singleton.ObterProximoId(); Apenas quando se usa Singleton
                    _repositorio.Adicionar(pecaPreenchida);
                }
                AtualizarLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um item!");
                    return;
                }

                var linhaSelecionada = dataGridView1.SelectedRows[0].Cells[0].RowIndex;
                var pecaSelecionada = (Peca)dataGridView1.Rows[linhaSelecionada].DataBoundItem;

                CadastroDePecas cadastroPeca = new(pecaSelecionada);
                cadastroPeca.ShowDialog();

                var pecaAtualizada = cadastroPeca.peca;
                pecaAtualizada.Id = pecaSelecionada.Id;

                if (cadastroPeca.DialogResult == DialogResult.OK)
                {

                    _repositorio.Editar(pecaAtualizada.Id, pecaAtualizada);

                    AtualizarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado ao editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AoClicarRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um item!");
                    return;
                }

                var linhaSelecionada = dataGridView1.SelectedRows[0].Cells[0].RowIndex;
                var pecaSelecionada = (Peca)dataGridView1.Rows[linhaSelecionada].DataBoundItem;

                string mensagem = "Tem certeza ?";
                var resultado = MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    _repositorio.Remover(pecaSelecionada.Id);
                    AtualizarLista();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado ao remover");
            }
        }
    }
}
