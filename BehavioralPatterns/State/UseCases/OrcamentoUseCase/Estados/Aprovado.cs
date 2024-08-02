using State.UseCases.OrcamentoUseCase.Abstracao;
using State.UseCases.OrcamentoUseCase.Entidades;

namespace State.UseCases.OrcamentoUseCase.Estados;

public class Aprovado : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.02;
        orcamento.DescontosAprovado++;
    }

    public override void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }
}
