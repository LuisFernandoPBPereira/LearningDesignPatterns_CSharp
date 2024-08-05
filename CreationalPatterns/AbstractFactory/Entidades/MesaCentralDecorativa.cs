using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class MesaCentralDecorativa : IMesa
{
    public MesaCentralDecorativa(int pernas)
    {
        Pernas = pernas;
    }

    public int Pernas { get; set; }
    
    public bool TemPernas()
    {
        if(Pernas > 0) return true;

        return false;
    }
}
