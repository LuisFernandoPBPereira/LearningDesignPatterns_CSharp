using Flyweight.Entidades;
using Flyweight.Interfaces;

namespace Flyweight;

public static class ExecucaoFlyweight
{
    public static void ExecutarNotasUseCase()
    {
        var notas = new NotasMusicais();

        List<INota> musica = new List<INota>()
        {
            notas.GetNota("do"),
            notas.GetNota("re"),
            notas.GetNota("mi"),
            notas.GetNota("fa"),
            notas.GetNota("fa"),
            notas.GetNota("fa")
        };

        var piano = new Piano();

        piano.Toca(musica);
    }
}
