using State.UseCases.OrcamentoUseCase.Abstracao;
using State.UseCases.OrcamentoUseCase.Entidades;

namespace State.UseCases.OrcamentoUseCase.Estados;

public class EmAprovacao : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.05;
        orcamento.DescontosEmAprovacao++;
    }

    public override void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public override void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }
}
