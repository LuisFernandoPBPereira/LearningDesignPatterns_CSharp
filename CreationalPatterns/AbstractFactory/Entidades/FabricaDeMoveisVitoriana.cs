using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class FabricaDeMoveisVitoriana : IFabricaDeMoveis
{
    public ICadeira CriaCadeira()
    {
        return new CadeiraVitoriana(4, 2);
    }

    public IMesa CriaMesa()
    {
        return new MesaCentralVitoriana(6);
    }

    public ISofa CriaSofa()
    {
        return new SofaVitoriano(10, 8);
    }
}
