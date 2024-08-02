using State.UseCases.OrcamentoUseCase.Abstracao;
using State.UseCases.OrcamentoUseCase.Entidades;

namespace State.UseCases.OrcamentoUseCase.Estados;

public class Finalizado : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos finalizados não recebem descontos extras");
    }
}
