using Decorator.UseCases.FiltroContaBancaria.Entidades;
using Decorator.UseCases.FiltroContaBancaria.Filtros;
using Decorator.UseCases.ImpostoUseCase.Entidades;
using Decorator.UseCases.ImpostoUseCase.Entidades.Impostos;

namespace Decorator;

public static class ExecucaoDecorator
{
    public static void ExecutarImpostoUseCase()
    {
        Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ICMS(new ICPP(new IKCV(new ICCC()))));

        Orcamento orcamento = new Orcamento(500);

        var impostoCalculado = impostoMuitoAlto.Calcula(orcamento);

        Console.WriteLine(impostoCalculado);
    }

    public static void ExecutarFiltroUseCase()
    {
        Filtro filtroAberturaConta = 
            new ContaAbertaNoMesRecorrente(new SaldoMaiorQue500MilReais(new SaldoMenorQue100Reais()));

        var listaContas = new List<Conta>()
        {
            new Conta("titular1", new DateTime(2024, 08, 01), 20000),
            new Conta("titular2", new DateTime(2024, 09, 01), 500001),
            new Conta("titular3", new DateTime(2024, 09, 01), 10),
            new Conta("titular4", new DateTime(2024, 09, 01), 20000),
            new Conta("titular5", new DateTime(2024, 09, 01), 20000),
        };

        var contasFiltradas = filtroAberturaConta.Filtra(listaContas, new List<Conta>());

        foreach (var conta in contasFiltradas)
        {
            Console.WriteLine(conta.NomeDoTitular);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.DataAbertura);
            Console.WriteLine();
        }
    }
}
