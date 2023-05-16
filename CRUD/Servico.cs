namespace CRUD
{
    public class Servico
    {
        public static string ValidarCampos(Peca peca)
        {
            if (string.IsNullOrEmpty(peca.Nome))
            {
                return "campo Nome vazio!";
            }



            return string.Empty;
        }
    }
}
