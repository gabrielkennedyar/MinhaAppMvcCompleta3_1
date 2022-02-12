namespace MinhaApp.Business.Models.Validations
{
    public class AdicionarProdutoValidation : ProdutoValidation
    {
        public AdicionarProdutoValidation()
        {
            ValidateNome();
            ValidateDescricao();
            ValidateValor();
        }
    }
}
