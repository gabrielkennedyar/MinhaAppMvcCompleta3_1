using MinhaApp.Business.Notificacoes;
using System.Collections.Generic;

namespace MinhaApp.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
