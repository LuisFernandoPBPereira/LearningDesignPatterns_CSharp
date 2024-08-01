using TemplateMethod.Imposto.Entidades;
using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod.Imposto;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, IImposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
