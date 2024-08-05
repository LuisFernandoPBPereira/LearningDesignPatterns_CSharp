using Visitor.Entidades;

namespace Visitor.Interfaces;

public interface IVisitor
{
    public void ImprimeSoma(Soma soma);
    public void ImprimeSubtracao(Subtracao subtracao);
    public void ImprimeNumero(Numero numero);
}
