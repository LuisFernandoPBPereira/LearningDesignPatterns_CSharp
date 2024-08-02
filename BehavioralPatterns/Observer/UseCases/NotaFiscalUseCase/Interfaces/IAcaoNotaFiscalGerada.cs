using Observer.UseCases.NotaFiscalUseCase.Entidades;

namespace Observer.UseCases.NotaFiscalUseCase.Interfaces;

public interface IAcaoNotaFiscalGerada
{
    public void Executar(NotaFiscal notaFiscal);
}
