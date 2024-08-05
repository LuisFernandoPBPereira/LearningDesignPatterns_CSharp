using Flyweight.Interfaces;

namespace Flyweight.Entidades;

public class NotasMusicais
{
    public static IDictionary<string, INota> Notas = new Dictionary<string, INota>()
    {
        {"do", new Do() },
        {"re", new Re() },
        {"mi", new Mi() },
        {"fa", new Fa() },
        {"sol", new Sol() },
        {"la", new La() },
        {"si", new Si() },
    };

    public INota GetNota(string nota)
    {
        return Notas[nota];
    }
}
