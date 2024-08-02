using State.UseCases.OrcamentoUseCase.Abstracao;
using State.UseCases.OrcamentoUseCase.Entidades;

namespace State.UseCases.OrcamentoUseCase.Estados;

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
