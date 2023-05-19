using System.ComponentModel;

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
            dataGridView1.DataSource = listaDePecas.ToList();
        }

        public int ObterProximoId()
        {
            return ++proximoId;
        }

        private void AoClicarAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroDePecas cadastroDePecas = new(null);
                cadastroDePecas.ShowDialog();

                var pecaPreenchida = cadastroDePecas._peca;
                pecaPreenchida.Id = ObterProximoId();

                listaDePecas.Add(pecaPreenchida);
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AoClicarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um item");
                    return;
                }
                var linhaSelecionada = (int)dataGridView1.SelectedRows[0].Cells[0].RowIndex;
                var pecaSelecionada = (Peca)dataGridView1.Rows[linhaSelecionada].DataBoundItem;

                CadastroDePecas cadastroPeca = new CadastroDePecas(pecaSelecionada);
                cadastroPeca.ShowDialog();

                var pecaAtualizada = cadastroPeca._peca;
                

                if (cadastroPeca.DialogResult == DialogResult.OK)
                {
                    pecaAtualizada.Id = ObterProximoId();
                    listaDePecas[linhaSelecionada] = pecaAtualizada;
                }

                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}