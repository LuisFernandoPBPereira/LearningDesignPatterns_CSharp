using Prototype.Entidades;

namespace Prototype;

public static class ExecucaoPrototype
{
    public static void ExecutarCarroUseCase()
    {
        var carro = new Carro("Chevorlet", "Celta");

        var carroClonado = (Carro) carro.Clonar();

        Console.WriteLine(carro.Marca);
        Console.WriteLine(carro.Modelo);

        Console.WriteLine();
        
        Console.WriteLine(carroClonado.Marca);
        Console.WriteLine(carroClonado.Modelo);
    }
}
