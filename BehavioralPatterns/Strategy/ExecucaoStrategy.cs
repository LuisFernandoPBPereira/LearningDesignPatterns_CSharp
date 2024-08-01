using Strategy.UseCases.Imposto;
using Strategy.UseCases.Investimento;

namespace Strategy;

public static class ExecucaoStrategy
{
    public static void ExecutarImpostoUseCase()
    {
        IImposto icms = new ICMS();
        IImposto iss = new ISS();
        IImposto iccc = new ICCC();

        Orcamento orcamento = new Orcamento(10000);

        CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

        var impostoCalculado = calculadora.Calcula(orcamento, iccc);

        Console.WriteLine(impostoCalculado);
    }
    
    public static void ExecutarInvestimentoUseCase()
    {
        IInvestimento conservador = new Conservador();
        IInvestimento moderado = new Moderado();
        IInvestimento arrojado = new Arrojado();

        Conta conta = new Conta(1000);

        CalculaInvestimento calculadora = new CalculaInvestimento();

        var investimentoCalculado = calculadora.Calcular(conta, arrojado);

        Console.WriteLine(investimentoCalculado);
    }
}
