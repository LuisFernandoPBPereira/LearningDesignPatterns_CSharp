
using Decorator.ImpostoUseCase.Entidades;

namespace Decorator.ImpostoUseCase;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, Imposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
