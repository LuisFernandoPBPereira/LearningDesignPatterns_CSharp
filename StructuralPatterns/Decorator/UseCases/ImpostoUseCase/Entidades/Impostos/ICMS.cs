using Decorator.UseCases.ImpostoUseCase.Entidades;

namespace Decorator.UseCases.ImpostoUseCase.Entidades.Impostos;
public class ICMS : Imposto
{
    public ICMS(Imposto outroImposto) : base(outroImposto) { }
    public ICMS() : base() { }

    public override double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
    }
}
