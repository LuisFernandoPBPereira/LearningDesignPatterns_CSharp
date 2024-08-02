using FactoryMethod.Interfaces;

namespace FactoryMethod.Entidades;

public class LogisticaMaritima : Logistica
{
    public override ITransporte CriaTransporte()
    {
        return new Navio();
    }
}
