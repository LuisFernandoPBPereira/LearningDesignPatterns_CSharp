using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class FabricaDeMoveisDecorativos : IFabricaDeMoveis
{
    public ICadeira CriaCadeira()
    {
        return new CadeiraDecorativa(4, 2);
    }

    public IMesa CriaMesa()
    {
        return new MesaCentralDecorativa(4);
    }

    public ISofa CriaSofa()
    {
        return new SofaDecorativo(6, 4);
    }
}
