using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod.Imposto.Entidades.Impostos;
public class ICCC : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        if (orcamento.Valor < 1000)
            return orcamento.Valor * 0.05;

        if (orcamento.Valor >= 1000 && orcamento.Valor < 3000)
            return orcamento.Valor * 0.07;

        return orcamento.Valor * 0.08 + 30;
    }
}
