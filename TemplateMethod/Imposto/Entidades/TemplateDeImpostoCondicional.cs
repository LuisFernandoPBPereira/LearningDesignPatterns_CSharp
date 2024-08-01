using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod.Imposto.Entidades;

public abstract class TemplateDeImpostoCondicional : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        if (DeveUsarMaximaTaxacao(orcamento))
            return MaximaTaxacao(orcamento);

        return MinimaTaxacao(orcamento);
    }

    public abstract double MinimaTaxacao(Orcamento orcamento);
    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
}
