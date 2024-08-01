using State.Entidades;
using State.Interfaces;

namespace State.Estados;

public class Reprovado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos repovados não recebem descontos extras");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("O orçamento está reprovado");
    }

    public void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("O orçamento está reprovado");
    }
}
