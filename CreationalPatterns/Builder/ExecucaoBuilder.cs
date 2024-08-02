using Builder.UseCases.NotaFiscalUseCase.Builders;

namespace Builder;

public static class ExecucaoBuilder
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

        var notaFiscal = notaFiscalBuilder.Build();

        notaFiscal.ExibirNota();
    }
}
