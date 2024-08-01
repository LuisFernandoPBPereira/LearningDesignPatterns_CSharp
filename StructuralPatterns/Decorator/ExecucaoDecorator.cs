using Decorator.ImpostoUseCase;
using Decorator.ImpostoUseCase.Entidades;

namespace Decorator;

public static class ExecucaoDecorator
{
    public static void ExecutarImpostoUseCase()
    {
        Imposto iss = new ISS(new ICMS(new ICCC()));

        Orcamento orcamento = new Orcamento(500);

        var impostoCalculado = iss.Calcula(orcamento);

        Console.WriteLine(impostoCalculado);
    }
}
