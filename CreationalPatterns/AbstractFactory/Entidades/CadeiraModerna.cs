using AbstractFactory.Interfaces;

namespace AbstractFactory.Entidades;

public class CadeiraModerna : ICadeira
{
    public CadeiraModerna(int pernas, int almofadas)
    {
        Pernas = pernas;
        Almofadas = almofadas;
    }

    public int Pernas { get; set; }
    public int Almofadas { get; set; }

    public bool TemAlmofada()
    {
        if (Almofadas > 0) return true;

        return false;
    }

    public bool TemPernas()
    {
        if(Pernas > 0) return true;

        return false;
    }
}
