using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod.Imposto.Entidades.Impostos;
public class ICMS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }
}
