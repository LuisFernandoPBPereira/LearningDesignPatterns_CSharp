using Observer.UseCases.NotaFiscalUseCase.Builders;
using Observer.UseCases.NotaFiscalUseCase.Publishers;
using Observer.UseCases.NotaFiscalUseCase.Subscribers;

namespace Observer;

public static class ExecucaoObserver
{
    public static void ExecutarNotaFiscalUseCase()
    {
        NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder();
        ItemDaNotaBuilder itemDaNotaBuilder = new ItemDaNotaBuilder();

        itemDaNotaBuilder
            .ComNome("Item 1")
            .ComValor(100);

        var item = itemDaNotaBuilder.Build();

        notaFiscalBuilder
            .ParaEmpresa("empresa tal")
            .ComCnpj("000000000000")
            .ComItem(item)
            .ComObservacao("Observação");

        notaFiscalBuilder.AdicionaAcao(new EnviaEmail());
        notaFiscalBuilder.AdicionaAcao(new EnviaSms());
        notaFiscalBuilder.AdicionaAcao(new SalvaNoBanco());

        var notaFiscal = notaFiscalBuilder.Build();

        notaFiscal.ExibirNota();
    }
}
