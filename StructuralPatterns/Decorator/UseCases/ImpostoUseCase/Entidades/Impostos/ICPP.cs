﻿using Decorator.UseCases.ImpostoUseCase.Entidades;

namespace Decorator.UseCases.ImpostoUseCase.Entidades.Impostos;

public class ICPP : TemplateDeImpostoCondicional
{
    public ICPP(Imposto outroImposto) : base(outroImposto) { }
    public ICPP() : base() { }

    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor >= 500;
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.07;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05;
    }
}
