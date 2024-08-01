using ChainOfResponsibility.UseCases.Imposto.Entidades;
using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto;

public class CalculadoraDeDescontos
{
    public double Calcular(Orcamento orcamento)
    {
        IDesconto desconto1 = new DescontoPor5Itens();
        IDesconto desconto2 = new DescontoPorMaisDe500Reais();
        IDesconto desconto3 = new DescontoVendaCasada();
        IDesconto desconto4 = new SemDesconto();

        desconto1.Proximo = desconto2;
        desconto2.Proximo = desconto3;
        desconto3.Proximo = desconto4;

        return desconto1.Desconto(orcamento);
    }
}
