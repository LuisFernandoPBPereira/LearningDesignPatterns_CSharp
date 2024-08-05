using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class MesaCentralVitoriana : IMesa
{
    public MesaCentralVitoriana(int pernas)
    {
        Pernas = pernas;
    }

    public int Pernas { get; set; }

    public bool TemPernas()
    {
        if (Pernas > 0) return true;

        return false;
    }
}
