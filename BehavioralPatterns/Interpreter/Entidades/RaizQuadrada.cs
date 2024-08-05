using Interpreter.Interfaces;

namespace Interpreter.Entidades;

public class RaizQuadrada : IExpressao
{
    public IExpressao Base { get; set; }
    public RaizQuadrada(IExpressao baseRaiz)
    {
        Base = baseRaiz;
    }

    public int Avalia()
    {
        var baseRaiz = Base.Avalia();

        return (int)Math.Sqrt(baseRaiz);
    }
}
