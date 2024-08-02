using Builder.UseCases.NotaFiscalUseCase.Builders;
using Builder.UseCases.NotaFiscalUseCase.Entidades;

namespace Builder;

public static class ExecucaoBuilder
{
    public static void ExecutarNotaFiscalUseCase()
    {
        NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder();

        notaFiscalBuilder
            .ParaEmpresa("empresa tal")
            .ComCnpj("000000000000")
            .ComItem(new ItemDaNota("Item 1", 100))
            .ComItem(new ItemDaNota("Item 2", 100))
            .NaDataAtual()
            .ComObservacao("Observação");

        var notaFiscal = notaFiscalBuilder.Build();

        notaFiscal.ExibirNota();
    }
}
