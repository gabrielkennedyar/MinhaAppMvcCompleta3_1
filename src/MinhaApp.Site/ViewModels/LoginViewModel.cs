using System.ComponentModel.DataAnnotations;

namespace MinhaApp.Site.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(20,ErrorMessage = "O Formato do usuário está inválido!", MinimumLength = 5)]
        public string Usuario { get; set; }

        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "O Formato do usuário está inválido!", MinimumLength = 5)]
        public string Senha { get; set; }
    }
}
