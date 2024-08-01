using ChainOfResponsibility.UseCases.Imposto.Entidades;
using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, IImposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
