using Observer.UseCases.NotaFiscalUseCase.Entidades;

namespace Observer.UseCases.NotaFiscalUseCase.Builders;

public class ItemDaNotaBuilder
{
    private string Nome { get; set; } = string.Empty;
    private double Valor { get; set; }

    public ItemDaNota Build()
    {
        return new ItemDaNota(Nome, Valor);
    }

    public ItemDaNotaBuilder ComNome(string nome)
    {
        Nome = nome;

        return this;
    }

    public ItemDaNotaBuilder ComValor(double valor)
    {
        Valor = valor;

        return this;
    }
}
