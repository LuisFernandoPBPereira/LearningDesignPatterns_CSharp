using State.Abstracao;
using State.Entidades;

namespace State.Estados;

public class Reprovado : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos repovados não recebem descontos extras");
    }

    public override void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

}
