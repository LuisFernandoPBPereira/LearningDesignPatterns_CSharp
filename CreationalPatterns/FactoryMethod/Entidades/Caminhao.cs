using FactoryMethod.Interfaces;

namespace FactoryMethod.Entidades;

public class Caminhao : ITransporte
{
    public void Entrega()
    {
        Console.WriteLine("Entrega de caminhão à caminho");
    }
}
