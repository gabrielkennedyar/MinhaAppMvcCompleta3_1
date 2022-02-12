namespace MinhaApp.Business.Models.Validations
{
    public class AtualizarProdutoValidation : ProdutoValidation
    {
        public AtualizarProdutoValidation()
        {
            ValidateNome();
            ValidateDescricao();
            ValidateValor();
        }
    }
}
