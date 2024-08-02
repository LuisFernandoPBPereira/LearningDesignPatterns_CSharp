using Observer.UseCases.NotaFiscalUseCase.Entidades;
using Observer.UseCases.NotaFiscalUseCase.Interfaces;

namespace Observer.UseCases.NotaFiscalUseCase.Subscribers;

public class Multiplicador : IAcaoNotaFiscalGerada
{
    public double Fator { get; set; }
    
    public Multiplicador(double fator)
    {
        Fator = fator;
    }

    public void Executar(NotaFiscal notaFiscal)
    {
        notaFiscal.ValorBruto *= Fator;

        Console.WriteLine("Evento Disparado: Nota com valor multiplicado\n");
    }
}
