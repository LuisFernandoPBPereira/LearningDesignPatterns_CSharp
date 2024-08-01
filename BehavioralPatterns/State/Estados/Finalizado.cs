using State.Entidades;
using State.Interfaces;

namespace State.Estados;

public class Finalizado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos finalizados não recebem descontos extras");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("O orçamento está finalizado");
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("O orçamento está finalizado");
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("O orçamento está finalizado");
    }
}
