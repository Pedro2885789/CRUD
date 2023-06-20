using CRUD.Dominio;

namespace CRUD
{
    public partial class CadastroDePecas : Form
    {
        public Peca peca = new();

        public CadastroDePecas(Peca? peca)
        {
            InitializeComponent();

            this.peca = peca == null
                ? new Peca()
                : VerificaPecaExistente(peca);
        }

        private Peca VerificaPecaExistente(Peca peca)
        {
            Text = "Editar Peça";
            textBox1.Text = peca.Nome;
            textBox2.Text = peca.Categoria;
            textBox3.Text = peca.Descricao;
            dateTimePicker1.Value = peca.DataDeFabricacao;
            numericUpDown1.Text = peca.Estoque.ToString();

            return peca;
        }

        private void AoClicarSalvar_Click(object sender, EventArgs e)
        {
            const string valorPadraoEstoque = "0";

            try
            {
                if (string.IsNullOrEmpty(numericUpDown1.Text))
                    numericUpDown1.Text = valorPadraoEstoque;

                var peca = new Peca()
                {
                    Nome = textBox1.Text,
                    Categoria = textBox2.Text,
                    Descricao = textBox3.Text,
                    DataDeFabricacao = dateTimePicker1.Value,
                    Estoque = (int)numericUpDown1.Value,
                };

                var errosDeValidação = Servico.ValidarCampos(peca);

                if (!string.IsNullOrEmpty(errosDeValidação))
                {
                    MessageBox.Show(errosDeValidação);
                    return;
                }

                this.peca = peca;

                DialogResult = DialogResult.OK;

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AoClicarCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
