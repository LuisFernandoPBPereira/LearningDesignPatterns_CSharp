using Flyweight.Interfaces;

namespace Flyweight.Entidades;

public class Piano
{
    public void Toca(List<INota> musica)
    {
        foreach (var nota in musica)
        {
            Console.Beep(nota.Frequencia, 300);
        }
    }
}
