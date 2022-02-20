using Microsoft.AspNetCore.Mvc;
using MinhaApp.Site.ViewModels;

namespace MinhaApp.Site.Areas.Autenticacao_ParaCasa.Controllers
{
    [Area("Autenticacao")]
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            //Parte responsável por logar
            return View(loginViewModel);
        }
    }
}
