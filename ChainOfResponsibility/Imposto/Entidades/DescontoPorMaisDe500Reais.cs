using ChainOfResponsibility.Imposto.Interfaces;

namespace ChainOfResponsibility.Imposto.Entidades;

public class DescontoPorMaisDe500Reais : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconto(Orcamento orcamento)
    {
        if (orcamento.Valor >= 500)
            return orcamento.Valor * 0.07;

        return Proximo.Desconto(orcamento);
    }
}
