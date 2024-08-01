using Decorator.ImpostoUseCase.Entidades;
using Decorator.ImpostoUseCase.Entidades.Impostos;

namespace Decorator;

public static class ExecucaoDecorator
{
    public static void ExecutarImpostoUseCase()
    {
        Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ICMS(new ICPP(new IKCV(new ICCC()))));

        Orcamento orcamento = new Orcamento(500);

        var impostoCalculado = impostoMuitoAlto.Calcula(orcamento);

        Console.WriteLine(impostoCalculado);
    }
}
