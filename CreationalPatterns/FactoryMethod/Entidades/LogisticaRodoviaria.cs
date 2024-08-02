using FactoryMethod.Interfaces;

namespace FactoryMethod.Entidades;

public class LogisticaRodoviaria : Logistica
{
    public override ITransporte CriaTransporte()
    {
        return new Caminhao();
    }
}
