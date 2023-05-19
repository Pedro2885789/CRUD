namespace CRUD
{
    public partial class CadastroDePecas : Form
    {
        public Peca _peca = new();
        public CadastroDePecas(Peca? peca)
        {
            InitializeComponent();
            VerificaPecaExistente(peca);
        }

       void VerificaPecaExistente(Peca? peca)
        {
            if (peca == null)
            {
                _peca = new Peca();
            }
            else
            {
                textBox1.Text = peca.Nome;
                textBox2.Text = peca.Categoria;
                textBox3.Text = peca.Descricao;
                dateTimePicker1.Value = peca.DataDeFabricacao;
                numericUpDown1.Value = peca.Estoque;
            }
        }

        private void AoClicarSalvar_Click(object sender, EventArgs e)
        {
            try
            {
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
                DialogResult = DialogResult.OK;
                _peca = peca;
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
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }    
        }
    }
}
