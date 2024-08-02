using State.Entidades;

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
}
