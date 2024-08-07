using Composite.Abstracao;

namespace Composite.Entidades;

public class Produto : Componente
{
    public override string Operacao()
    {
        return "Produto";
    }

    public override bool IsComposite()
    {
        return false;
    }
}
