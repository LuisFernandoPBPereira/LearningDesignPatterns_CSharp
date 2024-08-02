using FactoryMethod.Entidades;

namespace FactoryMethod;

public static class ExecucaoFactoryMethod
{
    public static void ExecutarLogisticaUseCase()
    {
        var logisticaRodoviaria = new LogisticaRodoviaria();
        var logisticaMaritima = new LogisticaMaritima();

        var veiculoRodoviario = logisticaRodoviaria.PlanejaEntrega();
        var veiculoMaritimo = logisticaMaritima.PlanejaEntrega();

        veiculoRodoviario.Entrega();
        veiculoMaritimo.Entrega();

        Console.WriteLine();
        Console.WriteLine(veiculoRodoviario);
        Console.WriteLine(veiculoMaritimo);
    }
}
