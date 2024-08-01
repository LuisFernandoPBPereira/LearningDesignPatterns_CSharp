using ChainOfResponsibility.UseCases.Imposto;
using ChainOfResponsibility.UseCases.Imposto.Entidades;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Enums;

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

    public static void ExecutarContaBancariaUseCase()
    {
        var requisicao = new Requisicao(E_Formato.PORCENTO);

        var conta = new Conta("Fernando", 1000);

        requisicao.Executar(conta);

        Console.WriteLine("Arquivo criado");
    }
}
