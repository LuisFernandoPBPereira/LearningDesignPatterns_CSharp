using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto.Entidades;

public class DescontoVendaCasada : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconto(Orcamento orcamento)
    {
        var contemCaneta = ContemItem("CANETA", orcamento);
        var contemLapis = ContemItem("LAPIS", orcamento);

        if (contemCaneta && contemLapis)
            return orcamento.Valor * 0.05;

        return Proximo.Desconto(orcamento);
    }

    private bool ContemItem(string nomeDoItem, Orcamento orcamento)
    {
        foreach (var item in orcamento.Itens)
        {
            if (item.Nome.Equals(nomeDoItem))
                return true;
        }
        return false;
    }
}
