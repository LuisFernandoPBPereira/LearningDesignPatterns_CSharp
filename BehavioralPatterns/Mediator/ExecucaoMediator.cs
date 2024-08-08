using Mediator.Entidades;

namespace Mediator;

public static class ExecucaoMediator
{
    public static void ExecutarCalculadoraUseCase()
    {
        var calculadora = new Calculadora();

        calculadora.CriarCalculadora();
    }
}
