using Memento.Entidades;

namespace Memento;

public static class ExecucaoMemento
{
    public static void ExecutarContratoUseCase()
    {
        try
        {
            var contrato = new Contrato(DateTime.Now, "Luis", TipoContrato.Novo);

            var historico = new HistoricoContrato();

            historico.Adiciona(contrato);

            contrato.Avanca();
            historico.Adiciona(contrato);

            contrato.Avanca();
            historico.Adiciona(contrato);
            
            contrato.Avanca();
            historico.Adiciona(contrato);

            Console.WriteLine(contrato.TipoContrato);

            Console.WriteLine(historico.BuscarContrato(0).TipoContrato);
        }
        catch (Exception excecao)
        {
            Console.WriteLine(excecao.Message);
        }
    }
}
