using Proxy.Interfaces;

namespace Proxy.Entidades;

public class ImplementacaoProxy : IAssunto
{
    public AssuntoReal AssuntoReal { get; set; }
    public string ResultadoDaRequisicao { get; set; } = string.Empty;

    public ImplementacaoProxy(AssuntoReal assuntoReal)
    {
        AssuntoReal = assuntoReal;
        ResultadoDaRequisicao = assuntoReal.ResultadoDaRequisicao;
    }

    public string Requisicao()
    {
        if (ResultadoDaRequisicao == string.Empty)
        {
            if (AssuntoReal == null)
                AssuntoReal = new AssuntoReal();

            ResultadoDaRequisicao = AssuntoReal.Requisicao();
            LogAccess();

            return ResultadoDaRequisicao;
        }

        LogAccess();

        return ResultadoDaRequisicao;
    }

    private void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request.");
    }
}
