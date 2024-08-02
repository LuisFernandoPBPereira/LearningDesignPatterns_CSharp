using State.Abstracao;
using State.Entidades;

namespace State.Estados;

public class EmAprovacao : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.05;
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
