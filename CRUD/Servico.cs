using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD
{
    public class Servico
    {
        public static string ValidarCampos(Peca peca)
        {
            var tamanhoMinimo = 3;

            if (string.IsNullOrEmpty(peca.Nome) || peca.Nome.Length < tamanhoMinimo || Regex.IsMatch(peca.Nome, @"[^a-zA-Z0-9 ]"))
            {
                return "Campo Nome inválido. Preencha o campo corretamente, utilizando apenas letras, números e espaços";
            }
            if (string.IsNullOrEmpty(peca.Categoria) || peca.Categoria.Length < tamanhoMinimo || Regex.IsMatch(peca.Categoria, @"[^a-zA-Z0-9 ]"))
            {
                return "Campo Categoria inválido. Preencha o campo corretamente, utilizando apenas letras, números e espaços";
            }
            if (string.IsNullOrEmpty(peca.Descricao) || peca.Descricao.Length < tamanhoMinimo || Regex.IsMatch(peca.Descricao, @"[^a-zA-Z0-9 ]"))
            {
                return "Campo Descrição inválido. Preencha o campo corretamente, utilizando apenas letras, números e espaços";
            }
            if (peca.DataDeFabricacao > DateTime.Now)
            {
                return "Campo Data de Fabricação inferior a data atual";
            }
            if (peca.Estoque < 1)
            {
                return "campo Estoque vazio!";
            }

            return string.Empty;
        }
    }
}
