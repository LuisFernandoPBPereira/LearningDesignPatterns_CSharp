using Decorator.UseCases.ImpostoUseCase.Entidades;

namespace Decorator.UseCases.ImpostoUseCase;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, Imposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
