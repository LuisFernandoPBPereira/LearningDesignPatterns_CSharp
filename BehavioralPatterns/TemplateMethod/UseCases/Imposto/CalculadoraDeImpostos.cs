using TemplateMethod.UseCases.Imposto.Entidades;
using TemplateMethod.UseCases.Imposto.Interfaces;

namespace TemplateMethod.UseCases.Imposto;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, IImposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
