using State.Entidades;
using State.Interfaces;

namespace State.Estados;

public class EmAprovacao : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.05;
    }

    public void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("O orçamento não pode ser finalizado quando estive em aprovação");
    }

    public void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }
}
