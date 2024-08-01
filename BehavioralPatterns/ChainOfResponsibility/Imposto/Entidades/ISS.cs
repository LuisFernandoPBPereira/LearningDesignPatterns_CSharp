using ChainOfResponsibility.Imposto.Interfaces;

namespace ChainOfResponsibility.Imposto.Entidades;

public class ISS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}
