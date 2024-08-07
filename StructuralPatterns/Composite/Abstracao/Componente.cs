using System.ComponentModel;

namespace Composite.Abstracao;

public abstract class Componente
{
    public Componente() { }

    public abstract string Operacao();

    public virtual void Add(Componente componente)
    {
        throw new Exception("Não foi possível adicionar");
    }

    public virtual void Remove(Componente componente)
    {
        throw new Exception("Não foi possível remover");
    }

    public virtual bool IsComposite()
    {
        return true;
    }
}
