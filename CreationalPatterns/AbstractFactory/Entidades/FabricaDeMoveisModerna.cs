using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class FabricaDeMoveisModerna : IFabricaDeMoveis
{
    public ICadeira CriaCadeira()
    {
        return new CadeiraModerna(4, 2);
    }

    public IMesa CriaMesa()
    {
        return new MesaCentralModerna(4);
    }

    public ISofa CriaSofa()
    {
        return new SofaModerno(5, 5);
    }
}
