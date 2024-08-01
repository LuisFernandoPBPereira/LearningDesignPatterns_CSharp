using Decorator.UseCases.ImpostoUseCase.Entidades;

namespace Decorator.UseCases.ImpostoUseCase.Entidades.Impostos;

public class ISS : Imposto
{
    public ISS(Imposto outroImposto) : base(outroImposto) { }
    public ISS() : base() { }

    public override double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
    }
}
