namespace TemplateMethod.Imposto.Entidades.Impostos;

public class IHIT : TemplateDeImpostoCondicional
{
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return Contem2ItensComMesmoNome(orcamento);
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.13) + 100;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Itens.Count() * 0.01;
    }

    private bool Contem2ItensComMesmoNome(Orcamento orcamento)
    {
        foreach (var item in orcamento.Itens)
        {
            var itensComMesmoNome = orcamento.Itens.Where(i => i.Nome == item.Nome).ToList();

            if (itensComMesmoNome.Count == 2)
                return true;
        }

        return false;
    }
}
