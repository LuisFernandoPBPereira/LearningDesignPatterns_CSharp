using State.Abstracao;
using State.Entidades;

namespace State.Estados;

public class Finalizado : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos finalizados não recebem descontos extras");
    }
}
