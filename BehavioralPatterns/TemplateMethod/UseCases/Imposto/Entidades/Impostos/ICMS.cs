using TemplateMethod.UseCases.Imposto.Entidades;
using TemplateMethod.UseCases.Imposto.Interfaces;

namespace TemplateMethod.UseCases.Imposto.Entidades.Impostos;
public class ICMS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }
}
