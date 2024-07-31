using ChainOfResponsibility.Imposto;
using ChainOfResponsibility.Imposto.Entidades;

namespace ChainOfResponsibility;

public static class ExecucaoChainOfResponsibility
{
    public static void ExecutarDescontoUseCase()
    {
        CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

        Orcamento orcamento = new Orcamento(400);

        orcamento.AdicionarItem(new Item("CANETA", 500));
        orcamento.AdicionarItem(new Item("LAPIS", 500));
        orcamento.AdicionarItem(new Item("Borracha", 500));
        orcamento.AdicionarItem(new Item("Apontador", 500));

        double desconto = calculadora.Calcular(orcamento);

        Console.WriteLine(desconto);
    }
}
