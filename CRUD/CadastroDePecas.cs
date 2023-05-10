namespace CRUD
{
    public partial class CadastroDePecas : Form
    {
        public Peca _peca = new();
        public CadastroDePecas()
        {
            InitializeComponent();
        }

        private void AoClicarSalvar_Click(object sender, EventArgs e)
        {
            var peca = new Peca()
            {
                Nome = textBox1.Text,
                Categoria = textBox2.Text,
                Descricao = textBox3.Text,
                DataDeFabricacao = dateTimePicker1.Value,
                Estoque = (int)numericUpDown1.Value,
            };

            _peca = peca;

            this.Close();
        }
    }
}
