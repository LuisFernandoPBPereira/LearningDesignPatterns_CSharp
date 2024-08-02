using State.Entidades;

namespace State.Abstracao;

public abstract class EstadoOrcamento
{
    public abstract void AplicaDescontoExtra(Orcamento orcamento);
    public virtual void Aprova(Orcamento orcamento)
    {
        throw new Exception("Não é possível aprovar o orçamento");
    }
    public virtual void Reprova(Orcamento orcamento)
    {
        throw new Exception("Não é possível reprovar o orçamento");
    }
    public virtual void Finaliza(Orcamento orcamento)
    {
        throw new Exception("Não é possível finalizar o orçamento");
    }
}
