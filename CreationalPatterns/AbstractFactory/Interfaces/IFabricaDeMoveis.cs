namespace AbstractFactory.Interfaces;

public interface IFabricaDeMoveis
{
    public ICadeira CriaCadeira();
    public IMesa CriaMesa();
    public ISofa CriaSofa();
}
