using Composite.Abstracao;

namespace Composite.Entidades;

public class Cliente
{
    public void Exemplo1(Componente componente)
    {
        Console.WriteLine($"RESULTADO: {componente.Operacao()}\n");
    }

    public void Exemplo2(Componente componente1, Componente componente2)
    {
        if (componente1.IsComposite())
        {
            componente1.Add(componente2);
        }

        Console.WriteLine($"RESULTADO: {componente1.Operacao()}");
    }
}
