using Proxy.Interfaces;

namespace Proxy.Entidades;

public class Client
{
    public void ClientCode(IAssunto assunto)
    {
        assunto.Requisicao();
    }
}
