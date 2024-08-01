namespace Decorator.ImpostoUseCase.Entidades;

public abstract class TemplateDeImpostoCondicional : Imposto
{
    protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto){}
    protected TemplateDeImpostoCondicional() : base(){}

    public override double Calcula(Orcamento orcamento)
    {
        if (DeveUsarMaximaTaxacao(orcamento))
            return MaximaTaxacao(orcamento);

        return MinimaTaxacao(orcamento);
    }

    public abstract double MinimaTaxacao(Orcamento orcamento);
    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
}
