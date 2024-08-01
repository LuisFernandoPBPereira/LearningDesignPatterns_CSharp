using State.Entidades;
using State.Interfaces;

namespace State.Estados;

public class Aprovado : IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.02;
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("O orçamento já está aprovado");
    }

    public void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("Um orçamento aprovado não pode ser reprovado");
    }
}
