using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto.Entidades;

public class ISS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}
