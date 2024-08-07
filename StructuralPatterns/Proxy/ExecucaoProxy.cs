using Proxy.Entidades;

namespace Proxy;

public static class ExecucaoProxy
{
    public static void ExecutarExemploUseCase()
    {
        Client client = new Client();

        Console.WriteLine("Client: Executando código do cliente com o assunto real:");
        AssuntoReal assuntoReal = new AssuntoReal();
        client.ClientCode(assuntoReal);
        Console.WriteLine(assuntoReal.ResultadoDaRequisicao);

        Console.WriteLine();

        Console.WriteLine("Client: Executando o mesmo código do cliente com proxy:");
        ImplementacaoProxy proxy = new ImplementacaoProxy(assuntoReal);
        client.ClientCode(proxy);
        Console.WriteLine(proxy.ResultadoDaRequisicao);
    }
}
