using FactoryMethod.Interfaces;

namespace FactoryMethod.Entidades;

public abstract class Logistica
{
    public ITransporte PlanejaEntrega()
    {
        return CriaTransporte();
    }

    public abstract ITransporte CriaTransporte();
}
