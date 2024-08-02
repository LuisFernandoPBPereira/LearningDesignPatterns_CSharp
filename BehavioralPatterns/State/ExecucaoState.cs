using State.UseCases.ContaUseCase.Entidades;
using State.UseCases.ContaUseCase.Estados;
using State.UseCases.OrcamentoUseCase.Entidades;

namespace State;

public static class ExecucaoState
{
    public static void ExecutarOrcamentoUseCase()
    {
        try
        {
            Orcamento orcamento = new Orcamento(500);
            Console.WriteLine(orcamento.Valor);

            orcamento.AplicaDescontoExtra();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();
        }
        catch (Exception excecao)
        {
            Console.WriteLine(excecao.Message);
        }
    }

    public static void ExecutarContaUseCase()
    {
        try
        {
            Conta conta1 = new Conta("titular1", 1000, new Positivo());
            Conta conta2 = new Conta("titular2", -1000, new Negativo());

            conta2.Deposito(2000);
            Console.WriteLine(conta2.Saldo);
            Console.WriteLine(conta2.EstadoConta);
            
            conta2.Positivar();
            Console.WriteLine(conta2.EstadoConta);

        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
