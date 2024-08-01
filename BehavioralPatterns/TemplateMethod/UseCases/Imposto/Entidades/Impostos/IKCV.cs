namespace TemplateMethod.UseCases.Imposto.Entidades.Impostos;

public class IKCV : TemplateDeImpostoCondicional
{
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        var possuiItemMaiorQue100Reais = ItemMaiorQue100Reais(orcamento);

        return orcamento.Valor > 500 && possuiItemMaiorQue100Reais;
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }

    private bool ItemMaiorQue100Reais(Orcamento orcamento)
    {
        foreach (var item in orcamento.Itens)
        {
            if (item.Valor > 100) return true;
        }

        return false;
    }
}
