using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto.Entidades;

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
