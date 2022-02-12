using Microsoft.AspNetCore.Mvc;
using MinhaApp.Business.Interfaces;

namespace MinhaApp.Site.Controllers
{
    public abstract class MainController : Controller
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}
