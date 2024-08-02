using FactoryMethod.Interfaces;

namespace FactoryMethod.Entidades;

public class Navio : ITransporte
{
    public void Entrega()
    {
        Console.WriteLine("Entrega de navio à caminho");
    }
}
