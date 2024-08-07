using Proxy.Interfaces;

namespace Proxy.Entidades;

public class AssuntoReal : IAssunto
{
    public string ResultadoDaRequisicao { get; set; } = string.Empty;
    public string Requisicao()
    {
        Console.WriteLine("Realizando requisição.");
        Thread.Sleep(5000);

        ResultadoDaRequisicao = "Requisição realizada\n";

        return ResultadoDaRequisicao;
    }
}
