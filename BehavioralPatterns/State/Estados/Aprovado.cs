using State.Abstracao;
using State.Entidades;

namespace State.Estados;

public class Aprovado : EstadoOrcamento
{
    public override void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.02;
    }

    public override void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }
}
