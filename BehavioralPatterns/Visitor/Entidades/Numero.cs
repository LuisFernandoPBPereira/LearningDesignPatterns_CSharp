using Visitor.Interfaces;

namespace Visitor.Entidades;

public class Numero : IExpressao
{
    public int NumeroDaExpressao { get; set; }

    public Numero(int numero)
    {
        NumeroDaExpressao = numero;
    }

    public int Avalia()
    {
        return NumeroDaExpressao;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeNumero(this);
    }
}
