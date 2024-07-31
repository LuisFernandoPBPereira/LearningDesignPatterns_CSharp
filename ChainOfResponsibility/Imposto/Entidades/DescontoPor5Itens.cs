using ChainOfResponsibility.Imposto.Interfaces;

namespace ChainOfResponsibility.Imposto.Entidades;

public class DescontoPor5Itens : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconto(Orcamento orcamento)
    {
        if (orcamento.Itens.Count > 5)
            return orcamento.Valor * 0.1;

        return Proximo.Desconto(orcamento);
    }
}
