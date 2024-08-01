using State.Entidades;

namespace State.Interfaces;

public interface IEstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento);
    public void Aprova(Orcamento orcamento);
    public void Reprova(Orcamento orcamento);
    public void Finaliza(Orcamento orcamento);
}
