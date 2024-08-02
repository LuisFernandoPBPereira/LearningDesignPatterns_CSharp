using Observer.UseCases.NotaFiscalUseCase.Entidades;
using Observer.UseCases.NotaFiscalUseCase.Interfaces;

namespace Observer.UseCases.NotaFiscalUseCase.Subscribers;

public class EnviaEmail : IAcaoNotaFiscalGerada
{
    public void Executar(NotaFiscal notaFiscal)
    {
        Console.WriteLine("email");
    }
}
