using Interpreter.Interfaces;

namespace Interpreter.Entidades;

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
}
