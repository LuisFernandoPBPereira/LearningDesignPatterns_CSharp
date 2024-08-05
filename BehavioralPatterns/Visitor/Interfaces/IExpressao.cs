using Visitor.Entidades;

namespace Visitor.Interfaces;

public interface IExpressao
{
    public int Avalia();
    public void Aceita(IVisitor impressora);
}
