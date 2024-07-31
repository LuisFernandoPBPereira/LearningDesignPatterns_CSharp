using ChainOfResponsibility.Imposto.Entidades;
using ChainOfResponsibility.Imposto.Interfaces;

namespace ChainOfResponsibility.Imposto;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, IImposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
