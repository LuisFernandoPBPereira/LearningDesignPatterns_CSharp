
using Decorator.ImpostoUseCase.Entidades;

namespace Decorator.ImpostoUseCase;

public abstract class Imposto
{
    public Imposto OutroImposto { get; set; }

    protected Imposto() 
    {
        OutroImposto = null;
    }

    protected Imposto(Imposto outroImposto)
    {
        OutroImposto = outroImposto;
    }

    protected double CalculoDoOutroImposto(Orcamento orcamento)
    {
        if (OutroImposto == null) return 0;

        return OutroImposto.Calcula(orcamento);
    }

    public abstract double Calcula(Orcamento orcamento);
}
