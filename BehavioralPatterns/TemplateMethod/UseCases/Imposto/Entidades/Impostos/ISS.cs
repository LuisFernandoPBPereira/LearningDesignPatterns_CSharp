using TemplateMethod.UseCases.Imposto.Entidades;
using TemplateMethod.UseCases.Imposto.Interfaces;

namespace TemplateMethod.UseCases.Imposto.Entidades.Impostos;

public class ISS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}
